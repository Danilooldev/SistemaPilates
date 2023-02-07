using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Controles.Cadastros;
using WindowsFormsApp6.Controles.Impressao;
using WindowsFormsApp6.Enumeradores;
using WindowsFormsApp6.Interface.Movimentacao;
using WindowsFormsApp6.Menus.Movimentacao;
using WindowsFormsApp6.Modelos;
using WindowsFormsApp6.Modelos.Movimentacao;
using WindowsFormsApp6.Relatorio.Impressao;
using WindowsFormsApp6.Repositorios.Movimentacao;
using WindowsFormsApp6.Repositorios.Utilitarios;
using WindowsFormsApp6.Utilitarios;

namespace WindowsFormsApp6.Controles.Movimentacao
{
    public class CtrlSaida
    {
        IMovimentacaoSaidaView SaidaView { get; set; }

        RegraCliente regraCliente = new RegraCliente();

        RepositorioConfiguracao repCfg = new RepositorioConfiguracao();

        IList<ModeloCidade> listaCidades = new List<ModeloCidade>();

        Int64 idCliente = 0;

        IPrincipalView Pai;

        private RepositorioMovimentacao repositorio = new RepositorioMovimentacao();

        decimal adicionalFrete = 0;


        ModelCliente clienteGlobal = null;

        public CtrlSaida(IPrincipalView Pai)
        {
            SaidaView = new FrmSaidas();

            this.Pai = Pai;

            SaidaView.SaidaView.MdiParent = Pai.PrincipalView;

            SaidaView.SaidaView.StartPosition = FormStartPosition.CenterScreen;

            SaidaView.SaidaView.Show();

            DelegarEventos();

            ObjetoParaTela();

            AtualizaDescontosAcrescimos(false);


        }

        private void DelegarEventos()
        {
            SaidaView.BtnPesquisar.Click += BtnPesquisar_Click;
            SaidaView.BtnAdd.Click += BtnAdd_Click;
            SaidaView.BtnExc.Click += BtnExc_Click;
            SaidaView.BtnFinalizar.Click += BtnFinalizar_Click;

            SaidaView.TxtDescAcres.KeyPress += Validadores.CampoNumericoDecimalNegPos;

            SaidaView.TxtDescAcres.LostFocus += Validadores.DecimalAposFoco;
            SaidaView.TxtDescAcres.LostFocus += TxtDescAcres_LostFocus;
            SaidaView.SemFrete.CheckedChanged += SemFrete_CheckedChanged;

            SaidaView.SaidaView.FormClosing += FormClosing;

            listaCidades = regraCliente.ListarCidades();

        }

        private void SemFrete_CheckedChanged(object sender, EventArgs e)
        {
            bool chk = (sender as CheckBox).Checked;

            AtualizaDescontosAcrescimos(chk);

        }

        private void TxtDescAcres_LostFocus(object sender, EventArgs e)
        {
            AtualizaDescontosAcrescimos(true);


        }

        private void AtualizaFrete()
        {
            ModelConfiguracao cfg = repCfg.Listar();

            adicionalFrete = cfg.ValorFrete;
        }

        private void AtualizaDescontosAcrescimos(bool frete)
        {
            AtualizaFrete();

            decimal valorFrete = 0;

            if (!frete)
                valorFrete = adicionalFrete;

            else if (!this.SaidaView.SemFrete.Checked)
                valorFrete = adicionalFrete;

            string valorString = this.SaidaView.TxtValorBruto.Text;
            string descAcresString = this.SaidaView.TxtDescAcres.Text;

            decimal.TryParse(valorString, out decimal valorTotal);
            decimal.TryParse(descAcresString, out decimal descAcres);

            this.SaidaView.LblValorLiquido.Text = (valorTotal + descAcres + valorFrete).ToString("C2");
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            EStatusMovimento eStatus = EStatusMovimento.P;

            var idNota = GravacaoNota(eStatus);

            if (idNota == 0)
                return;

            ObjetoParaTela();


        }

        private void Imprimir(Int64 idPedido, decimal totalPedido, IList<ModelItemMovimentacao> lista)
        {
            string porta = repCfg.Listar().PortaImpressora;

            // new CtrlImpressao(clienteGlobal, lista, idPedido, totalPedido, porta);

            new CtrlImpressaoReport(clienteGlobal, lista, idPedido, totalPedido, porta);
        }


        private Int64 GravacaoNota(EStatusMovimento eStatus)
        {
            try
            {
                ModelMovimentacao movimentacao = TelaParaObjeto(eStatus);
                IList<ModelItemMovimentacao> lista = this.SaidaView.DgvMercadorias.DataSource as List<ModelItemMovimentacao>;

                bool naoValido = ValidacaoSalvar(movimentacao, lista);

                if (naoValido) return 0;

                Int64 idDocumento = repositorio.Salvar(movimentacao);

                var listaAtualizada = lista.Select(c =>
                {
                    c.IdDocumento = idDocumento;
                    c.Operacao = EOperacaoMovimento.Saida;
                    c.Status = eStatus;
                    return c;
                }).ToList();

                repositorio.SalvarItens(listaAtualizada);

                MessageBox.Show($"Venda realizada com sucesso!");

                decimal totalPedido = movimentacao.ValorTotal + movimentacao.DescAcres + adicionalFrete;

                bool naoImprmir = this.SaidaView.NaoImprimir.Checked;

                if (!naoImprmir)
                    Imprimir(idDocumento, totalPedido, lista);

                return idDocumento;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return 0;
        }

        private bool ValidacaoSalvar(ModelMovimentacao movimentacao, IList<ModelItemMovimentacao> lista)
        {
            //bool data = entrada.Data.V
            bool descAcres = movimentacao.DescAcres * -1 >= movimentacao.ValorTotal && movimentacao.ValorTotal > 0;
            bool desc = movimentacao.IdParceiro < 1;

            bool qtdItem = (lista is null) || lista?.Count < 1;

            bool retorno = desc || qtdItem || descAcres;

            string semItens = qtdItem ? "\n\nE também deve ter pelo menos uma mercadoria" : "";

            string descAc = descAcres ? "\n\nO desconto não pode ser maior ou igual ao valor da nota" : "";

            if (retorno)
                MessageBox.Show("Preencha os campos obrigatórios" + semItens + descAc);


            this.SaidaView.TxtCliente.BackColor = desc ? Color.Yellow : Color.White;
            this.SaidaView.TxtDescAcres.BackColor = descAcres ? Color.Yellow : Color.White;

            return retorno;
        }

        private void BtnExc_Click(object sender, EventArgs e)
        {
            if (this.SaidaView.DgvMercadorias.RowCount < 1)
                return;

            if (this.SaidaView.DgvMercadorias.CurrentRow is null)
                this.SaidaView.DgvMercadorias.Focus();

            ModelItemMovimentacao mercadoriaSelecionada = this.SaidaView.DgvMercadorias.CurrentRow.DataBoundItem as ModelItemMovimentacao;

            AtualizaListaMercadoria(mercadoriaSelecionada, false);

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var add = new CtrlSaidaMercadoria();

            AtualizaListaMercadoria(add.RetornaObjetoSelecionado());
        }


        private ModelMovimentacao TelaParaObjeto(EStatusMovimento status)
        {
            string valorString = this.SaidaView.TxtValorBruto.Text;

            //long.TryParse(this.SaidaView.TxtId.Text, out long id);
            decimal.TryParse(this.SaidaView.TxtDescAcres.Text, out decimal descAcres);
            decimal.TryParse(valorString, out decimal valorTotal);

            DateTime data = this.SaidaView.DteVenda.Value;
            string numero = "Saída de mercadorias";
            string descricao = "Venda de mercadoria";



            return new ModelMovimentacao
            {
                Descricao = descricao,
                Id = 0,
                Data = data,
                DescAcres = descAcres,
                IdParceiro = idCliente,
                Operacao = EOperacaoMovimento.Saida,
                Status = status,
                ValorTotal = valorTotal,
                NumeroNota = numero,
                Frete = adicionalFrete
            };
        }


        private void AtualizaListaMercadoria(ModelItemMovimentacao mercadoria = null, bool add = true)
        {
            if (mercadoria == null)
                return;

            IList<ModelItemMovimentacao> listaMercadoria = SaidaView.DgvMercadorias.DataSource as List<ModelItemMovimentacao> ?? new List<ModelItemMovimentacao>();

            if (add)
                listaMercadoria.Add(mercadoria);
            else
                listaMercadoria.Remove(mercadoria);

            SaidaView.DgvMercadorias.DataSource = listaMercadoria.ToList();

            decimal.TryParse(this.SaidaView.TxtDescAcres.Text, out decimal descontoAcrescimo);

            decimal totalBruto = listaMercadoria.Sum(x => x.ValorTotal);

            CustomizaGridMercadoria();

            SaidaView.LblValorLiquido.Text = (totalBruto + descontoAcrescimo).ToString("C2");
            SaidaView.TxtValorBruto.Text = totalBruto.ToString();

            AtualizaDescontosAcrescimos(true);
        }

        private void CustomizaGridMercadoria()
        {
            SaidaView.DgvMercadorias.Columns["Descricao"].DisplayIndex = 0;
            SaidaView.DgvMercadorias.Columns["Descricao"].Width = 115;


            if (SaidaView.DgvMercadorias.Columns["Id"] != null)
                SaidaView.DgvMercadorias.Columns["Id"].Visible = false;

            if (SaidaView.DgvMercadorias.Columns["IdDocumento"] != null)
                SaidaView.DgvMercadorias.Columns["IdDocumento"].Visible = false;

            if (SaidaView.DgvMercadorias.Columns["IdMercadoria"] != null)
                SaidaView.DgvMercadorias.Columns["IdMercadoria"].Visible = false;

            if (SaidaView.DgvMercadorias.Columns["PrecoVenda"] != null)
            {
                SaidaView.DgvMercadorias.Columns["PrecoVenda"].DisplayIndex = 1;
                SaidaView.DgvMercadorias.Columns["PrecoVenda"].Width = 50;
            }

            //SaidaView.DgvMercadorias.Columns["PrecoCusto"].DisplayIndex = 2;
            SaidaView.DgvMercadorias.Columns["PrecoCusto"].Visible = false;

            if (SaidaView.DgvMercadorias.Columns["Quantidade"] != null)
            {
                SaidaView.DgvMercadorias.Columns["Quantidade"].DisplayIndex = 3;
                SaidaView.DgvMercadorias.Columns["Quantidade"].Width = 45;
            }

            if (SaidaView.DgvMercadorias.Columns["ValorTotal"] != null)
            {
                SaidaView.DgvMercadorias.Columns["ValorTotal"].DisplayIndex = 4;
                SaidaView.DgvMercadorias.Columns["ValorTotal"].Width = 50;
            }
        }


        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            var lista = regraCliente.ListaClientes().Cast<Object>().ToList();

            CtrlPesquisar Pesquisa = new CtrlPesquisar(Pai, lista, 690, "Pesquisa de Clientes");

            ObjetoParaTela(Pesquisa.RetornaObjetoSelecionado() as ModelCliente);

        }

        private void ObjetoParaTela(ModelCliente modelCliente = null)
        {
            if (modelCliente != null)
            {
                ModeloCidade cidade = listaCidades.Where(x => x.Id == modelCliente.Cidade).FirstOrDefault();

                SaidaView.TxtCliente.Text = modelCliente.Nome;
                SaidaView.LblEndereco.Text = "Endereço: " + modelCliente.Endereco + ", " + modelCliente.Numero + " - " + modelCliente.Bairro;
                SaidaView.LblTelefone.Text = "Telefone: " + modelCliente.Telefone.TelefoneMascara();
                SaidaView.LblCidade.Text = "Cidade: " + cidade.Nome;

                idCliente = modelCliente.Id;

                clienteGlobal = modelCliente;
            }
            else
            {
                SaidaView.TxtCliente.Text = null;
                SaidaView.LblEndereco.Text = "...";
                SaidaView.LblTelefone.Text = "...";
                SaidaView.LblCidade.Text = "...";
                idCliente = 0;
                SaidaView.DgvMercadorias.DataSource = null;

                this.SaidaView.TxtValorBruto.Text = "0,00";
                this.SaidaView.TxtDescAcres.Text = "0,00";

                clienteGlobal = null;

                AtualizaDescontosAcrescimos(true);
            }
        }

        public virtual void FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show(this.Pai.PrincipalView, "Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }

}


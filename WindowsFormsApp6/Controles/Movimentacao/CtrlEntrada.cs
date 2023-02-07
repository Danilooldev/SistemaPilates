using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Controles.Cadastros;
using WindowsFormsApp6.Enumeradores;
using WindowsFormsApp6.Interface.Movimentacao;
using WindowsFormsApp6.Modelos;
using WindowsFormsApp6.Modelos.Movimentacao;
using WindowsFormsApp6.Movimentacao;
using WindowsFormsApp6.Repositorios.Movimentacao;
using WindowsFormsApp6.Utilitarios;

namespace WindowsFormsApp6.Controles.Movimentacao
{

    public class CtrlEntrada
    {
        private IList<ModelCliente> listaFornecedores = new RegraCliente().ListaClientes().Where(x => x.Fornecedor).ToList();

        private RepositorioMovimentacao repositorio = new RepositorioMovimentacao();

        public IMovimentacaoEntradaView MovimentacaoEntradaView { get; set; }

        IPrincipalView Pai;

        public CtrlEntrada(IPrincipalView Pai)
        {
            this.Pai = Pai;

            MovimentacaoEntradaView = new FrmEntradas();

            MovimentacaoEntradaView.MovimentacaoEntradaView.MdiParent = Pai.PrincipalView;


            MovimentacaoEntradaView.MovimentacaoEntradaView.StartPosition = FormStartPosition.CenterScreen;


            MovimentacaoEntradaView.MovimentacaoEntradaView.Show();

            DelegarEventos();

            ObjetoParaTela();
        }

        private void DelegarEventos()
        {
            MovimentacaoEntradaView.BtnAdd.Click += BtnAdd_Click;
            MovimentacaoEntradaView.BtnEstornar.Click += BtnEstornar_Click;
            MovimentacaoEntradaView.BtnLimpar.Click += BtnLimpar_Click;
            MovimentacaoEntradaView.BtnPesquisar.Click += BtnPesquisar_Click;
            MovimentacaoEntradaView.BtnProcessar.Click += BtnProcessar_Click;
            MovimentacaoEntradaView.BtnRemove.Click += BtnRemove_Click;
            MovimentacaoEntradaView.BtnSalvar.Click += BtnSalvar_Click;

            MovimentacaoEntradaView.CbmFornecedor.DataSource = listaFornecedores;
            MovimentacaoEntradaView.CbmFornecedor.DisplayMember = "Nome";
            MovimentacaoEntradaView.CbmFornecedor.ValueMember = "Id";
            MovimentacaoEntradaView.CbmFornecedor.DropDownStyle = ComboBoxStyle.DropDownList;

            MovimentacaoEntradaView.TxtDescAcres.LostFocus += TxtDescAcres_LostFocus;
            MovimentacaoEntradaView.TxtDescAcres.KeyPress += Validadores.CampoNumericoDecimalNegPos;

            MovimentacaoEntradaView.MovimentacaoEntradaView.FormClosing += FormClosing;

        }

        private void TxtDescAcres_LostFocus(object sender, EventArgs e)
        {
            string valorString = this.MovimentacaoEntradaView.TxtValorTotal.Text;
            string descAcresString = this.MovimentacaoEntradaView.TxtDescAcres.Text;

            decimal.TryParse(valorString, out decimal valorTotal);
            decimal.TryParse(descAcresString, out decimal descAcres);

            this.MovimentacaoEntradaView.ValorTotal.Text = (valorTotal + descAcres).ToString("C2");
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            ObjetoParaTela();
        }

        #region Eventos

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            EStatusMovimento eStatus = EStatusMovimento.M;

            var idNota = GravacaoNota(eStatus);

            if (idNota == 0)
                return;

            var entrada = repositorio.Listar(EOperacaoMovimento.Entrada, eStatus).Where(x => x.Id == idNota).FirstOrDefault();

            ObjetoParaTela(entrada);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (this.MovimentacaoEntradaView.DgvMercadorias.RowCount < 1)
                return;

            if (this.MovimentacaoEntradaView.DgvMercadorias.CurrentRow is null)
                this.MovimentacaoEntradaView.DgvMercadorias.Focus();

            ModelItemMovimentacao mercadoriaSelecionada = this.MovimentacaoEntradaView.DgvMercadorias.CurrentRow.DataBoundItem as ModelItemMovimentacao;

            AtualizaListaMercadoria(mercadoriaSelecionada, false);
        }

        private void BtnProcessar_Click(object sender, EventArgs e)
        {
            EStatusMovimento eStatus = EStatusMovimento.P;

            var idNota = GravacaoNota(eStatus);

            if (idNota == 0)
                return;

            ObjetoParaTela();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            EStatusMovimento status = EStatusMovimento.E | EStatusMovimento.P | EStatusMovimento.M;

            var lista = repositorio.Listar(EOperacaoMovimento.Entrada, status).Cast<Object>().ToList();

            CtrlPesquisar Pesquisa = new CtrlPesquisar(Pai, lista, 690, "Pesquisa notas de entrada");

            ObjetoParaTela(Pesquisa.RetornaObjetoSelecionado() as ModelMovimentacao);

        }

        private void BtnEstornar_Click(object sender, EventArgs e)
        {
            EStatusMovimento eStatus = EStatusMovimento.E;

            Int64 idNota = GravacaoNota(eStatus);

            if (idNota == 0)
                return;

            var entrada = repositorio.Listar(EOperacaoMovimento.Entrada, eStatus).Where(x => x.Id == idNota).FirstOrDefault();

            if (entrada != null)
            {
                ObjetoParaTela(entrada);
                this.MovimentacaoEntradaView.BtnPesquisar.Enabled = false;
            }


        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var add = new CtrlAddMercadoria();

            AtualizaListaMercadoria(add.RetornaObjetoSelecionado());
        }

        #endregion

        private void AtualizaListaMercadoria(ModelItemMovimentacao mercadoria = null, bool add = true)
        {
            if (mercadoria == null)
                return;

            IList<ModelItemMovimentacao> listaMercadoria = MovimentacaoEntradaView.DgvMercadorias.DataSource as List<ModelItemMovimentacao> ?? new List<ModelItemMovimentacao>();

            if (add)
                listaMercadoria.Add(mercadoria);
            else
                listaMercadoria.Remove(mercadoria);

            MovimentacaoEntradaView.DgvMercadorias.DataSource = listaMercadoria.ToList();

            decimal.TryParse(this.MovimentacaoEntradaView.TxtDescAcres.Text, out decimal descontoAcrescimo);

            decimal totalBruto = listaMercadoria.Sum(x => x.ValorTotal);

            CustomizaGridMercadoria();

            MovimentacaoEntradaView.ValorTotal.Text = (totalBruto + descontoAcrescimo).ToString("C2");
            MovimentacaoEntradaView.TxtValorTotal.Text = totalBruto.ToString();
        }



        private void CustomizaGridMercadoria()
        {
            MovimentacaoEntradaView.DgvMercadorias.Columns["Descricao"].DisplayIndex = 0;
            MovimentacaoEntradaView.DgvMercadorias.Columns["Descricao"].Width = 115;


            if (MovimentacaoEntradaView.DgvMercadorias.Columns["Id"] != null)
                MovimentacaoEntradaView.DgvMercadorias.Columns["Id"].Visible = false;

            if (MovimentacaoEntradaView.DgvMercadorias.Columns["IdDocumento"] != null)
                MovimentacaoEntradaView.DgvMercadorias.Columns["IdDocumento"].Visible = false;

            if (MovimentacaoEntradaView.DgvMercadorias.Columns["IdMercadoria"] != null)
                MovimentacaoEntradaView.DgvMercadorias.Columns["IdMercadoria"].Visible = false;

            if (MovimentacaoEntradaView.DgvMercadorias.Columns["PrecoVenda"] != null)
            {
                MovimentacaoEntradaView.DgvMercadorias.Columns["PrecoCusto"].DisplayIndex = 1;
                MovimentacaoEntradaView.DgvMercadorias.Columns["PrecoCusto"].Width = 50;
            }

            if (MovimentacaoEntradaView.DgvMercadorias.Columns["PrecoVenda"] != null)
                MovimentacaoEntradaView.DgvMercadorias.Columns["PrecoVenda"].Visible = false;

            //MovimentacaoEntradaView.DgvMercadorias.Columns["PrecoCusto"].DisplayIndex = 2;
            //MovimentacaoEntradaView.DgvMercadorias.Columns["PrecoCusto"].Width = 50;

            if (MovimentacaoEntradaView.DgvMercadorias.Columns["Quantidade"] != null)
            {
                MovimentacaoEntradaView.DgvMercadorias.Columns["Quantidade"].DisplayIndex = 3;
                MovimentacaoEntradaView.DgvMercadorias.Columns["Quantidade"].Width = 45;
            }

            if (MovimentacaoEntradaView.DgvMercadorias.Columns["ValorTotal"] != null)
            {
                MovimentacaoEntradaView.DgvMercadorias.Columns["ValorTotal"].DisplayIndex = 4;
                MovimentacaoEntradaView.DgvMercadorias.Columns["ValorTotal"].Width = 50;
            }
        }

        private Int64 GravacaoNota(EStatusMovimento eStatus)
        {
            try
            {
                ModelMovimentacao movimentacao = TelaParaObjeto(eStatus);
                IList<ModelItemMovimentacao> lista = this.MovimentacaoEntradaView.DgvMercadorias.DataSource as List<ModelItemMovimentacao>;

                if (movimentacao is null)
                    return 0;

                bool naoValido = ValidacaoSalvar(movimentacao, lista);

                if (naoValido) return 0;

                Int64 idDocumento = repositorio.Salvar(movimentacao);

                var listaAtualizada = lista.Select(c =>
                {
                    c.IdDocumento = idDocumento;
                    c.Operacao = EOperacaoMovimento.Entrada;
                    c.Status = eStatus;
                    return c;
                }).ToList();

                repositorio.SalvarItens(listaAtualizada);

                string tipoGravacao = "estornada";

                if (movimentacao.Status.Equals(EStatusMovimento.M))
                    tipoGravacao = "salva";
                else if (movimentacao.Status.Equals(EStatusMovimento.P))
                    tipoGravacao = "processada";

                MessageBox.Show($"Nota de entrada {tipoGravacao} com sucesso!");

                return idDocumento;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return 0;
        }

        private void ObjetoParaTela(ModelMovimentacao modelMovimentacao = null)
        {
            if (modelMovimentacao != null)
            {
                this.MovimentacaoEntradaView.TxtId.Text = modelMovimentacao.Id.ToString();
                this.MovimentacaoEntradaView.TxtDescAcres.Text = modelMovimentacao.DescAcres.ToString();

                this.MovimentacaoEntradaView.DteData.Value = modelMovimentacao.Data;
                this.MovimentacaoEntradaView.TxtNumeroNota.Text = modelMovimentacao.NumeroNota;
                this.MovimentacaoEntradaView.TxtDescricao.Text = modelMovimentacao.Descricao;
                this.MovimentacaoEntradaView.TxtValorTotal.Text = modelMovimentacao.ValorTotal.ToString();

                this.MovimentacaoEntradaView.ValorTotal.Text = modelMovimentacao.ValorLiquidoTotal.ToString("C2");


                this.MovimentacaoEntradaView.CbmFornecedor.SelectedValue = modelMovimentacao.IdParceiro;

                EStatusMovimento status = EStatusMovimento.E | EStatusMovimento.P | EStatusMovimento.M;
                EOperacaoMovimento eOperacao = EOperacaoMovimento.Entrada;

                MovimentacaoEntradaView.DgvMercadorias.DataSource = repositorio.ListaMercadoriasNotas(modelMovimentacao.Id, eOperacao, status);


                Color cor = Color.Orange;
                string textoProc = "Memória";
                bool somenteLeitura = false;

                bool estornoIrreversivel = false;

                switch (modelMovimentacao.Status)
                {
                    case EStatusMovimento.E:
                        cor = Color.Red;
                        textoProc = "Estornada";
                        estornoIrreversivel = true;
                        break;
                    case EStatusMovimento.P:
                        cor = Color.Green;
                        textoProc = "Processada";
                        somenteLeitura = true;
                        break;
                    case EStatusMovimento.M:
                    default:
                        cor = Color.Orange;
                        textoProc = "Memória";
                        break;
                }

                this.MovimentacaoEntradaView.Status.Text = textoProc;
                this.MovimentacaoEntradaView.Status.ForeColor = cor;


                this.MovimentacaoEntradaView.TxtId.ReadOnly = somenteLeitura;
                this.MovimentacaoEntradaView.TxtDescAcres.ReadOnly = somenteLeitura;

                this.MovimentacaoEntradaView.DteData.Enabled = !somenteLeitura;
                this.MovimentacaoEntradaView.TxtNumeroNota.ReadOnly = somenteLeitura;
                this.MovimentacaoEntradaView.TxtDescricao.ReadOnly = somenteLeitura;

                this.MovimentacaoEntradaView.ValorTotal.Text = modelMovimentacao.ValorLiquidoTotal.ToString("C2");

                this.MovimentacaoEntradaView.CbmFornecedor.Enabled = !somenteLeitura;

                this.MovimentacaoEntradaView.BtnAdd.Enabled = !somenteLeitura;
                this.MovimentacaoEntradaView.BtnRemove.Enabled = !somenteLeitura;

                this.MovimentacaoEntradaView.BtnProcessar.Enabled = !somenteLeitura;
                this.MovimentacaoEntradaView.BtnSalvar.Enabled = !somenteLeitura;
                this.MovimentacaoEntradaView.BtnEstornar.Enabled = somenteLeitura;
                this.MovimentacaoEntradaView.BtnPesquisar.Enabled = !somenteLeitura;


                if (estornoIrreversivel)
                {
                    this.MovimentacaoEntradaView.BtnProcessar.Enabled = false;
                    this.MovimentacaoEntradaView.BtnSalvar.Enabled = false;
                    this.MovimentacaoEntradaView.BtnEstornar.Enabled = false;

                    this.MovimentacaoEntradaView.TxtId.ReadOnly = false;
                    this.MovimentacaoEntradaView.TxtDescAcres.ReadOnly = false;

                    this.MovimentacaoEntradaView.DteData.Enabled = false;
                    this.MovimentacaoEntradaView.TxtNumeroNota.ReadOnly = false;
                    this.MovimentacaoEntradaView.TxtDescricao.ReadOnly = false;

                    this.MovimentacaoEntradaView.CbmFornecedor.Enabled = false;

                    this.MovimentacaoEntradaView.BtnAdd.Enabled = false;
                    this.MovimentacaoEntradaView.BtnRemove.Enabled = false;

                }



                CustomizaGridMercadoria();

            }
            else
            {
                this.MovimentacaoEntradaView.TxtId.Text = null;
                this.MovimentacaoEntradaView.TxtDescAcres.Text = null;

                this.MovimentacaoEntradaView.DteData.Value = DateTime.Now;
                this.MovimentacaoEntradaView.TxtNumeroNota.Text = null;
                this.MovimentacaoEntradaView.TxtDescricao.Text = null;
                this.MovimentacaoEntradaView.TxtValorTotal.Text = null;

                if (this.MovimentacaoEntradaView.CbmFornecedor.SelectedIndex >= 0)
                    this.MovimentacaoEntradaView.CbmFornecedor.SelectedIndex = 0;

                this.MovimentacaoEntradaView.DgvMercadorias.DataSource = null;

                this.MovimentacaoEntradaView.Status.Text = "Memória";
                this.MovimentacaoEntradaView.Status.ForeColor = Color.Orange;

                this.MovimentacaoEntradaView.ValorTotal.Text = decimal.Zero.ToString("C2");


                this.MovimentacaoEntradaView.BtnProcessar.Enabled = true;
                this.MovimentacaoEntradaView.BtnSalvar.Enabled = true;
                this.MovimentacaoEntradaView.BtnEstornar.Enabled = false;


                bool somenteLeitura = false;

                this.MovimentacaoEntradaView.TxtId.ReadOnly = somenteLeitura;
                this.MovimentacaoEntradaView.TxtDescAcres.ReadOnly = somenteLeitura;

                this.MovimentacaoEntradaView.DteData.Enabled = !somenteLeitura;
                this.MovimentacaoEntradaView.TxtNumeroNota.ReadOnly = somenteLeitura;
                this.MovimentacaoEntradaView.TxtDescricao.ReadOnly = somenteLeitura;

                this.MovimentacaoEntradaView.ValorTotal.Text = decimal.Zero.ToString("C2");

                this.MovimentacaoEntradaView.CbmFornecedor.Enabled = !somenteLeitura;

                this.MovimentacaoEntradaView.BtnAdd.Enabled = !somenteLeitura;
                this.MovimentacaoEntradaView.BtnRemove.Enabled = !somenteLeitura;

                this.MovimentacaoEntradaView.BtnProcessar.Enabled = !somenteLeitura;
                this.MovimentacaoEntradaView.BtnSalvar.Enabled = !somenteLeitura;
                this.MovimentacaoEntradaView.BtnEstornar.Enabled = somenteLeitura;
                this.MovimentacaoEntradaView.BtnPesquisar.Enabled = !somenteLeitura;



            }
        }

        private ModelMovimentacao TelaParaObjeto(EStatusMovimento status)
        {
            string valorString = this.MovimentacaoEntradaView.TxtValorTotal.Text;

            long.TryParse(this.MovimentacaoEntradaView.TxtId.Text, out long id);
            decimal.TryParse(this.MovimentacaoEntradaView.TxtDescAcres.Text, out decimal descAcres);
            decimal.TryParse(valorString, out decimal valorTotal);

            DateTime data = this.MovimentacaoEntradaView.DteData.Value;
            string numero = this.MovimentacaoEntradaView.TxtNumeroNota.Text;
            string descricao = this.MovimentacaoEntradaView.TxtDescricao.Text;

            ModelCliente fornec = MovimentacaoEntradaView.CbmFornecedor.SelectedItem as ModelCliente;

            if (fornec is null)
            {
                MessageBox.Show("Cadastre um fornecedor antes de continuar");
                return null;
            }

            return new ModelMovimentacao
            {
                Descricao = descricao,
                Id = id,
                Data = data,
                DescAcres = descAcres,
                IdParceiro = fornec.Id,
                Operacao = EOperacaoMovimento.Entrada,
                Status = status,
                ValorTotal = valorTotal,
                NumeroNota = numero
            };
        }


        private bool ValidacaoSalvar(ModelMovimentacao entrada, IList<ModelItemMovimentacao> itens)
        {


            //bool data = entrada.Data.V
            bool descAcres = entrada.DescAcres * -1 > entrada.ValorTotal;
            bool desc = string.IsNullOrEmpty(entrada.Descricao);
            bool num = string.IsNullOrEmpty(entrada.NumeroNota);
            bool qtdItem = itens is null || itens?.Count < 1;

            bool retorno = desc || num || qtdItem;

            string semItens = qtdItem ? "\n\nE também deve ter pelo menos uma mercadoria" : "";

            string descAc = descAcres ? "\n\nO desconto não pode ser maior que o valor da nota" : "";

            if (retorno)
                MessageBox.Show("Preencha os campos obrigatórios" + semItens + descAc);


            this.MovimentacaoEntradaView.TxtDescricao.BackColor = desc ? Color.Yellow : Color.White;
            this.MovimentacaoEntradaView.TxtNumeroNota.BackColor = num ? Color.Yellow : Color.White;

            this.MovimentacaoEntradaView.TxtDescAcres.BackColor = descAcres ? Color.Yellow : Color.White;

            return retorno;
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

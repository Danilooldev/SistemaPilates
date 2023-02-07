using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Interface.Cadastros;
using WindowsFormsApp6.Menus;
using WindowsFormsApp6.Modelos;
using WindowsFormsApp6.Repositorios.Cliente;
using WindowsFormsApp6.Utilitarios;

namespace WindowsFormsApp6.Controles.Cadastros
{
    public class CtrlCadastroMercadoria
    {
        private RegraMercadoria regraMercadoria = new RegraMercadoria();
        public IMercadoriaCadastroView MercadoriaView { get; set; }

        IPrincipalView Pai;

        public CtrlCadastroMercadoria(IPrincipalView Pai)
        {
            this.Pai = Pai;

            MercadoriaView = new FrmCadastroMercadorias();

            MercadoriaView.MercadoriaView.MdiParent = Pai.PrincipalView;

            MercadoriaView.MercadoriaView.StartPosition = FormStartPosition.CenterScreen;

            MercadoriaView.MercadoriaView.Show();

            DelegarEventos();
        }

        private void DelegarEventos()
        {
            MercadoriaView.BtnPesquisar.Click += BtnPesquisar_Click;
            MercadoriaView.BtnExcluir.Click += BtnExcluir_Click;
            MercadoriaView.BtnLimpar.Click += BtnLimpar_Click;
            MercadoriaView.BtnSalvar.Click += BtnSalvar_Click;

            MercadoriaView.TxtPrecoCusto.KeyPress += Validadores.CampoNumericoDecimal;
            MercadoriaView.TxtPrecoVenda.KeyPress += Validadores.CampoNumericoDecimal;

            MercadoriaView.TxtPrecoCusto.LostFocus += Validadores.DecimalAposFoco;
            MercadoriaView.TxtPrecoVenda.LostFocus += Validadores.DecimalAposFoco;

            MercadoriaView.MercadoriaView.FormClosing += FormClosing;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            SalvarExcluir(true);
        }

        private void SalvarExcluir(bool ativo)
        {

            ModelMercadoria mercadoria = TelaParaObjeto();

            mercadoria.Ativo = ativo;

            bool camposObrig = CamposObrigatorios(mercadoria);

            if (!camposObrig)
            {
                bool salvou = regraMercadoria.Salvar(mercadoria);

                if (salvou)
                    ObjetoParaTela();
            }
        }
        private bool CamposObrigatorios(ModelMercadoria mercadoria)
        {

            bool descricao = string.IsNullOrEmpty(mercadoria.Descricao);

            bool custo = mercadoria.PrecoCusto == 0;
            bool venda = mercadoria.PrecoVenda == 0;


            bool retorno = descricao || custo || venda;

            string custoString = custo ? "\nPreço de custo deve ser maior que zero" : "";
            string vendaString = venda ? "\nPreço de venda deve ser maior que zero" : "";


            if (retorno)
                MessageBox.Show($"Preencha os campos obrigatórios\n{custoString}{vendaString}");

            this.MercadoriaView.TxtDescricao.BackColor = descricao ? Color.Yellow : Color.White;
            this.MercadoriaView.TxtPrecoCusto.BackColor = custo ? Color.Yellow : Color.White;
            this.MercadoriaView.TxtPrecoVenda.BackColor = venda ? Color.Yellow : Color.White;

            return retorno;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            ObjetoParaTela();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            SalvarExcluir(false);

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            var lista = regraMercadoria.ListaMercadorias().Cast<Object>().ToList();

            CtrlPesquisar Pesquisa = new CtrlPesquisar(Pai, lista, 492, "Pesquisa de Mercadorias");

            ObjetoParaTela(Pesquisa.RetornaObjetoSelecionado() as ModelMercadoria);

        }


        private void ObjetoParaTela(ModelMercadoria mercadoria = null)
        {
            if (mercadoria is null)
            {
                MercadoriaView.TxtId.Text = null;
                MercadoriaView.TxtDescricao.Text = null;
                MercadoriaView.TxtPrecoCusto.Text = null;
                MercadoriaView.TxtPrecoVenda.Text = null;
                MercadoriaView.TxtQtd.Text = null;
                MercadoriaView.LblAtivo.Text = null;

                MercadoriaView.DgvHistorico.DataSource = null;

                MercadoriaView.TxtDescricao.BackColor = Color.White;
                MercadoriaView.TxtPrecoCusto.BackColor = Color.White;
                MercadoriaView.TxtPrecoVenda.BackColor = Color.White;
                MercadoriaView.TxtQtd.BackColor = Color.White;

            }
            else
            {
                MercadoriaView.TxtId.Text = mercadoria.Id.ToString();
                MercadoriaView.TxtDescricao.Text = mercadoria.Descricao;
                MercadoriaView.TxtPrecoCusto.Text = mercadoria.PrecoCusto.ToString();
                MercadoriaView.TxtPrecoVenda.Text = mercadoria.PrecoVenda.ToString();
                MercadoriaView.TxtQtd.Text = mercadoria.Quantidade.ToString();

                MercadoriaView.LblAtivo.Text = mercadoria.Ativo ? "Ativo" : "Inativo";
                MercadoriaView.LblAtivo.ForeColor = mercadoria.Ativo ? Color.DarkGreen : Color.Red;

                MercadoriaView.DgvHistorico.DataSource = regraMercadoria.ListaNotasHistoricas(mercadoria.Id);

                MercadoriaView.DgvHistorico.Columns["Id"].Width = 30;
                MercadoriaView.DgvHistorico.Columns["Nota"].Width = 180;

            }
        }

        private ModelMercadoria TelaParaObjeto()
        {
            ModelMercadoria mercadoria = new ModelMercadoria();

            long.TryParse(MercadoriaView.TxtId.Text, out long id);

            decimal.TryParse(MercadoriaView.TxtPrecoCusto.Text, out decimal custo);
            decimal.TryParse(MercadoriaView.TxtPrecoVenda.Text, out decimal venda);
            decimal.TryParse(MercadoriaView.TxtQtd.Text, out decimal qtd);

            mercadoria.Id = id;
            mercadoria.Descricao = MercadoriaView.TxtDescricao.Text;
            mercadoria.PrecoCusto = custo;
            mercadoria.PrecoVenda = venda;
            mercadoria.Quantidade = qtd;

            return mercadoria;
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
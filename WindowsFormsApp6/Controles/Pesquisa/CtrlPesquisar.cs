using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Interface;
using WindowsFormsApp6.Pesquisar;
using WindowsFormsApp6.Utilitarios;

namespace WindowsFormsApp6.Controles
{
    public class CtrlPesquisar
    {
        public IPesquisar Pesquisa { get; set; }

        private IList<Object> ListaGenerica;
        private IList<Object> ListaIntacta;

        /// <summary>
        /// Controle para acessar tela de pesquisa genérica
        /// </summary>
        /// <param name="Pai"></param> Form principal
        /// <param name="ListaGenerica"></param> Lista de object castada para que todo o objeto se adapte a grid
        /// <param name="tamanhoDaTela"></param> Tamanho da tela de pesquisa para ficar proporcional à quantidade de dados
        public CtrlPesquisar(IPrincipalView Pai, IList<Object> ListaGenerica, int tamanhoDaTela, string tituloTela)
        {
            Pesquisa = new FrmPesquisar();

            this.Pesquisa.TelaPesquisa.StartPosition = FormStartPosition.CenterParent;

            DelegarEventos();

            PreencheListaGenerica(ListaGenerica, tamanhoDaTela, tituloTela);

            Pesquisa.TelaPesquisa.ShowDialog();

        }

        private void DelegarEventos()
        {
            this.Pesquisa.TxtPesquisar.KeyPress += TxtPesquisar_KeyPress;

            this.Pesquisa.GrdPesquisar.DoubleClick += GrdPesquisar_DoubleClick;

            this.Pesquisa.GrdPesquisar.KeyDown += GrdPesquisar_KeyDown;

            this.Pesquisa.GrdPesquisar.KeyPress += GrdPesquisar_KeyPress;

            this.Pesquisa.TelaPesquisa.Resize += TamanhoTela;


        }

        private void TextoPesquisar(IList<Object> lista, string texto)
        {
            if (lista == null || lista.Count == 0) return;

            IList<Object> ListaTratada = lista;

            this.Pesquisa.GrdPesquisar.DataSource = null;

            ListaTratada = lista.Cast<IModeloGenerico>().ToList().Where(x => x.Consulta.ToUpper().Contains(texto.ToUpper())).ToList().Cast<Object>().ToList();

            this.Pesquisa.GrdPesquisar.DataSource = ListaTratada;
        }

        void GrdPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.Pesquisa.TelaPesquisa.DialogResult = DialogResult.OK;
                RetornaObjetoSelecionado();

            }

            if (e.KeyChar == 27)
            {
                this.Pesquisa.TelaPesquisa.DialogResult = DialogResult.Cancel;
            }

        }

        void GrdPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            // 32 = space / 13 enter
            if (e.KeyValue.Equals(13))
            {
                e.SuppressKeyPress = true;
                this.Pesquisa.TelaPesquisa.DialogResult = DialogResult.OK;

                RetornaObjetoSelecionado();
            }
            ///e.SuppressKeyPress = true;
        }

        void TamanhoTela(object sender, EventArgs e)
        {
            Console.WriteLine("Tamanho da tela " + this.Pesquisa.TelaPesquisa.Width);

        }

        void GrdPesquisar_DoubleClick(object sender, EventArgs e)
        {
            this.Pesquisa.TelaPesquisa.DialogResult = DialogResult.OK;

            RetornaObjetoSelecionado();

        }

        void TxtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string texto = sender.RetornaTextoParaBusca(e);

            texto = texto.Replace("\r", "");

            TextoPesquisar(this.ListaGenerica, texto);

            if (e.KeyChar == 13)
            {
                this.Pesquisa.TelaPesquisa.DialogResult = DialogResult.OK;
                RetornaObjetoSelecionado();
            }
        }

        private void PreencheListaGenerica(IList<Object> ListaGenerica, int tamanhoDaTela, string tituloDatela)
        {
            this.ListaIntacta = ListaGenerica;

            this.ListaGenerica = ListaGenerica;

            this.Pesquisa.GrdPesquisar.DataSource = ListaGenerica.ToList();

            TratamentosLista(new object[] { tamanhoDaTela, tituloDatela });
        }

        private void TratamentosLista(object[] objetosTela)
        {
            this.Pesquisa.GrdPesquisar.RowHeadersWidth = 25;

            this.Pesquisa.TelaPesquisa.Width = Convert.ToInt16(objetosTela[0]);

            this.Pesquisa.TelaPesquisa.Text = objetosTela[1].ToString();

            try
            {
                if (Pesquisa.GrdPesquisar.Columns["Ativo"] != null)
                    this.Pesquisa.GrdPesquisar.Columns["Ativo"].Visible = false;

                if (Pesquisa.GrdPesquisar.Columns["Id"] != null)
                    this.Pesquisa.GrdPesquisar.Columns["Id"].Width = 50;

                if (Pesquisa.GrdPesquisar.Columns["TiposParceiro"] != null)
                    this.Pesquisa.GrdPesquisar.Columns["TiposParceiro"].Width = 205;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Não foi possível alterar algumas colunas");
            }
        }

        public Object RetornaObjetoSelecionado()
        {
            if (this.Pesquisa.TelaPesquisa.DialogResult == DialogResult.OK &&
                this.Pesquisa.GrdPesquisar.Rows.Count > 0)
                return this.Pesquisa.GrdPesquisar.Rows[this.Pesquisa.GrdPesquisar.CurrentRow.Index].DataBoundItem as Object;

            return null;
        }
    }
}

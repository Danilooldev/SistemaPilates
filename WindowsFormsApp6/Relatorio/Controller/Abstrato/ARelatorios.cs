using Relatorios.Enumeradores;
using Relatorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp6;
using WindowsFormsApp6.Utilitarios;
using static WindowsFormsApp6.Utilitarios.Util;

namespace Relatorios.Controller
{
    public abstract class ARelatorios// : AValidacaoMensagens
    {
        protected IRelatorio RelatorioView { get; set; }

        protected ARelatorios(IPrincipalView Pai, string categoria)
        {
            this.RelatorioView = new FrmRelatorio();

            this.RelatorioView.RelatorioView.StartPosition = FormStartPosition.CenterScreen;

            this.RelatorioView.RelatorioView.MdiParent = Pai.PrincipalView;

            this.RelatorioView.RelatorioView.Show();

            CarregaListaComOsRelatorios(categoria);

            this.DelegarEventos();

        }

        private void DelegarEventos()
        {
            this.RelatorioView.ListaRelatorio.DoubleClick += ListaRelatorio_DoubleClick;

            this.RelatorioView.AbreRelatorio.Click += AbreRelatorio_Click;
            this.RelatorioView.FechaTela.Click += FechaTela_Click;

        }

        private void FechaTela_Click(object sender, EventArgs e)
        {
            this.RelatorioView.RelatorioView.Dispose();
        }

        private void AbreRelatorio_Click(object sender, EventArgs e)
        {
            AbrirRelatorioDesejado();
        }

        private void ListaRelatorio_DoubleClick(object sender, EventArgs e)
        {
            AbrirRelatorioDesejado();
        }

        private void CarregaListaComOsRelatorios(string categoria = null)
        {
            var semFiltro = Enum.GetValues(typeof(ERelatorio)).Cast<ERelatorio>().ToList();
            var comFiltro = Enum.GetValues(typeof(ERelatorio)).Cast<ERelatorio>().ToList().Where(e => !e.PegarCategoria().Equals(categoria)).ToList();

            bool todos = string.IsNullOrEmpty(categoria);

            IList<ERelatorio> lista = todos ? semFiltro : comFiltro;

            var listaFiltrada = SetDataSource.Carregar(typeof(ERelatorio));

            List<int> pos = new List<int>();

            for (int i = 0; i < listaFiltrada.Count; i++)
            {
                ERelatorio? rel = ((KeyValuePair<Enum, string>)listaFiltrada[i]).Key as ERelatorio?;

                if (lista.Where(x => x.Equals(rel)).Count() > 0)
                    pos.Add(i);
            }

            if(!todos)
            for (int i = pos.Count; i > 0; i--)
                listaFiltrada.RemoveAt(pos[i - 1]);

            this.RelatorioView.ListaRelatorio.DataSource = listaFiltrada;
            this.RelatorioView.ListaRelatorio.DisplayMember = SetDataSource.Mostrador;
            this.RelatorioView.ListaRelatorio.ValueMember = SetDataSource.Valor;

        }

        public abstract void AbrirRelatorioDesejado();
    }
}

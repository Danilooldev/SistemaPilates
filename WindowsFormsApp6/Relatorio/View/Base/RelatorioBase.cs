using Relatorios.Enumeradores;
using System;
using System.Diagnostics.CodeAnalysis;
using WindowsFormsApp6.Utilitarios;

namespace Relatorios.View.Cadastros.Venda
{
    [Serializable]
    [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Retrato"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1010:CollectionsShouldImplementGenericInterface")]
    public partial class RelatorioBase : DevExpress.XtraReports.UI.XtraReport
    {
        public RelatorioBase(ERelatorio relatorio, string nomeTotal, string valor)
        {
            InitializeComponent();

            this.lblTitulo.Text = relatorio.Descricao();
            this.xrNome.Text = nomeTotal;
            this.xrTotal.Text = valor;
        }

        private RelatorioBase() { }

        public RelatorioBase(ERelatorio relatorio)
        {
            InitializeComponent();

            this.xrNome.Visible = false;
            this.xrTotal.Visible = false;

            this.lblTitulo.Text = relatorio.Descricao();
        }
    }
}
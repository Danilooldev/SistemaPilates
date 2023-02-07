using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using DevExpress.Data;
using Relatorios.Enumeradores;
using Relatorios.View.Cadastros.Venda;

namespace Relatorios.View.Cadastros.Entrada
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1010:CollectionsShouldImplementGenericInterface")]
    public partial class Relatorio04VendaDeMercadoriaPorPeriodo : RelatorioBase
    {
        public Relatorio04VendaDeMercadoriaPorPeriodo(ERelatorio relatorio, string nomeTotal, string total) : base(relatorio, nomeTotal, total)
        {
            InitializeComponent();
        }

    }
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using DevExpress.Data;
using Relatorios.Enumeradores;

namespace Relatorios.View.Cadastros.Venda
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1010:CollectionsShouldImplementGenericInterface")]
    public partial class Relatorio03NotasDeEntrada : RelatorioBase
    {
        public Relatorio03NotasDeEntrada(ERelatorio relatorio) : base(relatorio)
        {
            InitializeComponent();
        }

        #region Turno

        public XRLabel LblEntrada { get { return this.lblEntrada; } }

        public XRLabel LblSaida { get { return this.lblSaida; } }

        public XRLabel LblId { get { return this.lblTurnoId; } }

        public XRLabel LblTotalTurno { get { return this.lblTotalTurno; } }

        #endregion


        #region Mercadorias

        public XRLabel LblMercadoria { get { return this.lblMercadoria; } }

        public XRLabel LblPreco { get { return this.lblPrecoUnit; } }

        public XRLabel LblQtd { get { return this.lblQtd; } }

        public XRLabel LblTotal { get { return this.lblTotal; } }

        #endregion


    }
}

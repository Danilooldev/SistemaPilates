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
    public partial class Relatorio02VendaPorFinalizadoraSinteticoPorTurno : RelatorioBase
    {
        public Relatorio02VendaPorFinalizadoraSinteticoPorTurno(ERelatorio relatorio) : base(relatorio)
        {
            InitializeComponent();
        }

        public XRLabel LblEntrada { get { return this.lblEntrada; } }

        public XRLabel LblSaida { get { return this.lblSaida; } }

        public XRLabel LblId { get { return this.lblId; } }

        public XRLabel LblFinalizadora { get { return this.lblFinalizadora; } }

        public XRLabel LblTotal { get { return this.lblTotal; } }

    }
}

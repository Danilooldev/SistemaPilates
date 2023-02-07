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

namespace Relatorios.View.Cadastros.Mercadorias
{
    [Serializable]
    public partial class RelatorioModelo : RelatorioBase
    {
        public RelatorioModelo(ERelatorio relatorio) : base(relatorio)
        {
            InitializeComponent();

        }


        public XRLabel LblPrecoVenda { get { return this.lblPrecoVenda; } }

        public XRLabel LblEstoque { get { return this.lblEstoque; } }






    }
}

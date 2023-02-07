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

namespace Relatorios.Impressao
{
    [Serializable]
    public partial class ImpressaoSaida : XtraReport
    {
        public ImpressaoSaida()
        {
            InitializeComponent();

        }


    }
}

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
    public partial class Relatorio01ListaClientes : RelatorioBase
    {
        public Relatorio01ListaClientes(ERelatorio relatorio) : base(relatorio)
        {
            InitializeComponent();

        }


    }
}

using Relatorios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relatorios
{
    public partial class FrmRelatorio : Form, IRelatorio
    {
        public FrmRelatorio()
        {
            InitializeComponent();
        }

        public Form RelatorioView { get { return this; } }

        public ListBox ListaRelatorio { get { return this.lstRelatorios; } }

        public Button AbreRelatorio { get { return this.btnAbrir; } }

        public Button FechaTela { get { return this.btnFechar; } }
    }
}

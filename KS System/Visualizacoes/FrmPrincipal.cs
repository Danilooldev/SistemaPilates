using KS_System.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KS_System
{
    public partial class FrmPrincipal : Form, IPrincipal
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public Form PrincipalView => this;

        public ToolStripMenuItem MenuCadastro => clientesToolStripMenuCadastro;

        public ToolStripMenuItem MenuMercadoria => mercadoriasToolStripMenuItem;
    }
}

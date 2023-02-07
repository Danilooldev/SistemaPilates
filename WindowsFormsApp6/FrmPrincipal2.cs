using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class FrmPrincipal2 : Form//, IPrincipalView
    {
        public FrmPrincipal2()
        {
            InitializeComponent();
        }

        public Form PrincipalView => this;

        public ToolStripMenuItem MenuClientes => clientesToolStripMenuItem;
        
    }
}

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
    public partial class FormPrincipal : Form, IPrincipalView
    {
        public FormPrincipal() { InitializeComponent(); }

        public Form PrincipalView => this;

        public ToolStripMenuItem MenuClientes => clientesToolStripMenuItem;

        public ToolStripMenuItem MenuMercadorias => mercadoriasToolStripMenuItem;

        public ToolStripMenuItem MenuEntradas => entradaToolStripMenuItem;

        public ToolStripMenuItem MenuSaidas => saidaToolStripMenuItem;

        public ToolStripMenuItem MenuCancelamentoSaida => cancelamentoSaidaToolStripMenuItem;

        public ToolStripMenuItem MenuConfiguracoes => configuracoesToolStripMenuItem;

        public ToolStripMenuItem MenuRelatorios => relatoriosToolStripMenuItem;

        public ToolStripMenuItem MenuImportar => importarToolStripMenuItem;




    }
}

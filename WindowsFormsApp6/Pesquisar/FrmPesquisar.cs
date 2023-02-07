using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Interface;

namespace WindowsFormsApp6.Pesquisar
{
    public partial class FrmPesquisar : Form, IPesquisar
    {
        public FrmPesquisar() { InitializeComponent(); }

        public TextBox TxtPesquisar { get { return this.textBox1; } }

        public DataGridView GrdPesquisar { get { return this.dataGridView1; } }

        public Form TelaPesquisa { get { return this; } }
    }
}

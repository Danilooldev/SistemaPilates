using KS_System.Interfaces.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KS_System.Visualizacoes.Cadastros
{
    public partial class FrmCliente : Form, ICliente
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        public Form ClienteView => this;
    }
}

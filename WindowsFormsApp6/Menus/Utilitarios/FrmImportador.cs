using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Interface.Utilitarios;

namespace WindowsFormsApp6.Menus.Utilitarios
{
    public partial class FrmImportador : Form, IImportador
    {
        public FrmImportador() { InitializeComponent(); }

        public Form ImportadorView => this;

        public TextBox TxtCaminho => textBox1;

        public Button BtnImportar => button1;
    }
}

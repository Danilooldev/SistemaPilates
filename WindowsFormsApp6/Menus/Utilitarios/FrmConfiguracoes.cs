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
    public partial class FrmConfiguracoes : Form, IConfiguracao
    {
        public FrmConfiguracoes() { InitializeComponent(); }

        public Form ConfiguracaoView => this;

        public TextBox TxtValorFrete => txtValorFrete;

        public TextBox TxtPortaImpressora => txtPortaImp;

        public Button BtnTesteImpressao => btnTestar;

        public Button BtnSalvar => btnSalvar;

        public Button BtnCancelar => btnCancelar;

        public CheckBox ChkMostrarExc => chkMostrar;

        public DataGridView DgvImpressora => dataGridView1;
    }
}

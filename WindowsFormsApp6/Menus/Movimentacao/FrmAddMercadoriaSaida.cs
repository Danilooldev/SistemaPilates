using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Interface.Movimentacao;

namespace WindowsFormsApp6.Menus.Movimentacao
{
    public partial class FrmAddMercadoriaSaida : Form, IAddVendaMercadoria
    {
        public FrmAddMercadoriaSaida() { InitializeComponent(); }

        public Button BtnAdd => btnAdd;

        public Label LblTotal => lblTotal;

        public Form SaidaMercadoriaView => this;

        public ComboBox CbmMercadoria => cbmDesc;

        public TextBox TxtQtd => txtQtd;

        public TextBox TxtPreco => txtPreco;

        public Button BtnCancelar => btnExc;
    }
}

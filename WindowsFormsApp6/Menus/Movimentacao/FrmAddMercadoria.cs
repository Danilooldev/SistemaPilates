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
    public partial class FrmAddMercadoria : Form, IAddEntradaMercadoria
    {
        public FrmAddMercadoria() { InitializeComponent(); }

        public Form AddMercadoriaView => this;

        public TextBox TxtQuantidade => txtQtd;

        public TextBox TxtPrecoVenda => txtVenda;

        public TextBox TxtPrecoCusto => txtCusto;

        public ComboBox CbmUnidade => cbmUnid;

        public ComboBox CbmDescricao => cbmDesc;

        public Button BtnAdd => btnAdd;

        public Button BtnExc => btnExc;

        public Label LblUnidades => lblUnidades;

        public Label LblTotal => lblTotal;
    }
}

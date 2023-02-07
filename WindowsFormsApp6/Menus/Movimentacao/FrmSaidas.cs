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
    public partial class FrmSaidas : Form, IMovimentacaoSaidaView
    {
        public FrmSaidas()
        {
            InitializeComponent();
        }

        public Form SaidaView => this;

        public TextBox TxtCliente => txtCliente;

        public Label LblEndereco => lblEnd;

        public Label LblTelefone => lblTel;

        public Label LblCidade => lblCidade;

        public TextBox TxtDescAcres => txtDescAcre;

        public TextBox TxtValorBruto => txtValorTotal;

        public DateTimePicker DteVenda => dateTimePicker1;

        public Label LblValorLiquido => lblValorLiquidoTotal;

        public Button BtnPesquisar => btnPesquisar;

        public Button BtnAdd => btnAdd;

        public Button BtnExc => btnRem;

        public Button BtnFinalizar => btnProcessar;

        public DataGridView DgvMercadorias => dgvMercadorias;

        public CheckBox SemFrete => checkBox1;

        public CheckBox NaoImprimir => chkNaoImprimir;
    }
}

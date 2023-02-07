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

namespace WindowsFormsApp6.Movimentacao
{
    public partial class FrmEntradas : Form, IMovimentacaoEntradaView
    {
        public FrmEntradas() { InitializeComponent(); }

        public Form MovimentacaoEntradaView => this;

        public TextBox TxtId => txtId;

        public TextBox TxtDescricao => txtDesc;

        public TextBox TxtNumeroNota => txtNum;

        public TextBox TxtValorTotal => txtValorTotal;

        public Button BtnPesquisar => btnPesquisar;

        public Button BtnLimpar => btnLimpar;

        public Button BtnSalvar => btnSalvar;

        public Button BtnEstornar => btnEstornar;

        public Button BtnProcessar => btnProcessar;

        public Button BtnAdd => btnAdd;

        public Button BtnRemove => btnRem;

        public Label Status => lblStatus;

        public Label ValorTotal => lblValorLiquidoTotal;

        public TextBox TxtDescAcres => txtDescAcre;

        public DateTimePicker DteData => dateTimePicker1;

        public DataGridView DgvMercadorias => dgvMercadorias;

        public ComboBox CbmFornecedor => cbmFornecedor;
    }
}

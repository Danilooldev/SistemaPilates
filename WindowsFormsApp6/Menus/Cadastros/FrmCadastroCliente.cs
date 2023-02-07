using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Interface.Cadastros;

namespace WindowsFormsApp6.Menus
{
    public partial class FrmCadastroCliente : Form, IClienteCadastroView
    {
        public FrmCadastroCliente() { InitializeComponent(); }
        public Form ClienteView => this;

        public TextBox TxtId => txtId;

        public TextBox TxtNome => txtNome;

        public Button BtnSalvar => btnSalvar;

        public TextBox TxtCPF => txtCpf;

        public TextBox TxtEnd => txtEnd;

        public TextBox TxtNumero => txtNumero;

        public TextBox TxtBairro => txtBairro;

        public TextBox TxtComp => txtCompl;

        public TextBox TxtTelefone => txtTel;

        public ComboBox CbmCidade => cbmCidade;

        public Button BtnPesquisar => btnPesquisar;

        public Button BtnExcluir => btnExcluir;

        public Button BtnCancelar => btnLimpar;

        public DataGridView DgvHistorico => dgvHistorico;

        public RichTextBox RchObs => rchObs;

        public CheckBox ChkFornecedor => checkBox1;

        public Label LblAtivo => lblAtivo;
    }
}

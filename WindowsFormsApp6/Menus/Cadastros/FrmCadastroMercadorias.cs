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
    public partial class FrmCadastroMercadorias : Form, IMercadoriaCadastroView
    {
        public FrmCadastroMercadorias() { InitializeComponent(); }

        public Form MercadoriaView => this;

        public TextBox TxtId => txtId;

        public TextBox TxtDescricao => txtDescricao;

        public TextBox TxtPrecoVenda => txtVenda;

        public TextBox TxtPrecoCusto => txtCusto;

        public TextBox TxtQtd => txtQuantidade;

        public Button BtnPesquisar => btnPesquisar;

        public Button BtnLimpar => btnLimpar;

        public Button BtnExcluir => btnExcluir;

        public Button BtnSalvar => btnSalvar;

        public DataGridView DgvHistorico => dgvHistorico;

        public Label LblAtivo => lblAtivo;
    }
}

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
    public partial class FrmCadastroMercadoria : Form, IMercadoria
    {
        public FrmCadastroMercadoria()
        {
            InitializeComponent();
        }

        public Form MercadoriaView => this;

        public TextBox TxtId => txtId;

        public TextBox TxtDescricao => txtDescricao;

        public TextBox TxtVenda => txtVenda;

        public TextBox TxtQuantidade => txtQuantidade;

        public TextBox TxtCusto => txtCusto;

        public Button BtnPesquisar => btnPesquisar;

        public Button BtnLimpar => btnLimpar;

        public Button BtnSalvar => btnSalvar;

        public Button BtnExcluir => btnExcluir;

       
    }
}

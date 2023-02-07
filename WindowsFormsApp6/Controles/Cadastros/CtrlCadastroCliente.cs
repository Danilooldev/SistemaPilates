using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp6.Interface.Cadastros;
using WindowsFormsApp6.Menus;
using WindowsFormsApp6.Modelos;
using WindowsFormsApp6.Repositorios.Cliente;
using WindowsFormsApp6.Utilitarios;

namespace WindowsFormsApp6.Controles.Cadastros
{
    public class CtrlCadastroCliente
    {
        IPrincipalView Pai;

        private RegraCliente regraCliente = new RegraCliente();

        public IClienteCadastroView ClienteCadastroView { get; set; }


        public CtrlCadastroCliente(IPrincipalView pai)
        {
            Pai = pai;

            ClienteCadastroView = new FrmCadastroCliente();

            ClienteCadastroView.ClienteView.StartPosition = FormStartPosition.CenterScreen;

            ClienteCadastroView.ClienteView.MdiParent = pai.PrincipalView;

            ClienteCadastroView.ClienteView.Show();

            Eventos();

        }

        #region Eventos

        public void Eventos()
        {
            ClienteCadastroView.BtnSalvar.Click += BtnSalvar_Click;

            ClienteCadastroView.BtnCancelar.Click += BtnCancelar_Click;

            ClienteCadastroView.BtnExcluir.Click += BtnExcluir_Click;

            ClienteCadastroView.BtnPesquisar.Click += BtnPesquisar_Click;

            ClienteCadastroView.CbmCidade.DataSource = regraCliente.ListarCidades();
            ClienteCadastroView.CbmCidade.ValueMember = "Id";
            ClienteCadastroView.CbmCidade.DisplayMember = "Nome";

            ClienteCadastroView.TxtCPF.KeyPress += Validadores.ApenasNumeros;
            ClienteCadastroView.TxtCPF.LostFocus += TxtCPF_LostFocus;
            ClienteCadastroView.TxtTelefone.LostFocus += TxtTelefone_LostFocus;

            ClienteCadastroView.ClienteView.FormClosing += FormClosing;

        }

        private void TxtTelefone_LostFocus(object sender, EventArgs e)
        {
            string texto = ClienteCadastroView.TxtTelefone.Text.TelefoneMascara();

            ClienteCadastroView.TxtTelefone.Text = texto;
        }

        private void TxtCPF_LostFocus(object sender, EventArgs e)
        {
            string texto = ClienteCadastroView.TxtCPF.Text.CpfCnpj();

            ClienteCadastroView.TxtCPF.Text = texto;


        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            var lista = regraCliente.ListaClientes().Cast<Object>().ToList();

            CtrlPesquisar Pesquisa = new CtrlPesquisar(Pai, lista, 690, "Pesquisa de Clientes");

            ObjetoParaTela(Pesquisa.RetornaObjetoSelecionado() as ModelCliente);

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            SalvarExcluir(false);
        }

        private void SalvarExcluir(bool ativo)
        {
            ModelCliente cliente = TelaParaObjeto();

            cliente.Ativo = ativo;

            bool camposObrig = CamposObrigatorios(cliente);

            if (!camposObrig)
            {
                bool salvou = regraCliente.Salvar(cliente);

                if (salvou)
                    ObjetoParaTela();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            ObjetoParaTela();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            SalvarExcluir(true);
        }

        public bool CamposObrigatorios(ModelCliente cliente)
        {
            bool bairro = string.IsNullOrEmpty(cliente.Bairro);
            bool cidade = cliente.Cidade == 0;
            bool cpf = string.IsNullOrEmpty(cliente.Cpf);
            bool endereco = string.IsNullOrEmpty(cliente.Endereco);
            bool nome = string.IsNullOrEmpty(cliente.Nome);
            bool numero = string.IsNullOrEmpty(cliente.Numero);

            bool retorno = bairro || cidade || cpf || endereco || nome || numero;

            if (retorno)
                MessageBox.Show("Preencha os campos obrigatórios");

            this.ClienteCadastroView.TxtBairro.BackColor = bairro ? Color.Yellow : Color.White;
            this.ClienteCadastroView.CbmCidade.BackColor = cidade ? Color.Yellow : Color.White;
            this.ClienteCadastroView.TxtCPF.BackColor = cpf ? Color.Yellow : Color.White;
            this.ClienteCadastroView.TxtEnd.BackColor = endereco ? Color.Yellow : Color.White;
            this.ClienteCadastroView.TxtNome.BackColor = nome ? Color.Yellow : Color.White;
            this.ClienteCadastroView.TxtNumero.BackColor = numero ? Color.Yellow : Color.White;

            return retorno;
        }

        #endregion

        private ModelCliente TelaParaObjeto()
        {
            ModelCliente cliente = new ModelCliente();

            long idCidade = (long)ClienteCadastroView.CbmCidade.SelectedValue;

            Int64.TryParse(ClienteCadastroView.TxtId.Text, out long id);

            cliente.Id = id;
            cliente.Nome = ClienteCadastroView.TxtNome.Text;
            cliente.Cpf = ClienteCadastroView.TxtCPF.Text.RemoveMascara();
            cliente.Bairro = ClienteCadastroView.TxtBairro.Text;

            cliente.Cidade = idCidade;
            cliente.Complemento = ClienteCadastroView.TxtComp.Text;
            cliente.Endereco = ClienteCadastroView.TxtEnd.Text;
            cliente.Fornecedor = ClienteCadastroView.ChkFornecedor.Checked;

            cliente.Obs = ClienteCadastroView.RchObs.Text;
            cliente.Telefone = ClienteCadastroView.TxtTelefone.Text.RemoveMascara();
            cliente.Numero = ClienteCadastroView.TxtNumero.Text;

            return cliente;
        }

        private void ObjetoParaTela(ModelCliente cliente = null)
        {
            var cidade = (ClienteCadastroView.CbmCidade.DataSource as List<ModeloCidade>);

            if (cliente is null)
            {
                ClienteCadastroView.TxtId.Text = null;
                ClienteCadastroView.TxtNome.Text = null;
                ClienteCadastroView.TxtBairro.Text = null;
                ClienteCadastroView.TxtCPF.Text = null;


                ClienteCadastroView.TxtComp.Text = null;
                ClienteCadastroView.CbmCidade.SelectedItem = cidade.FirstOrDefault();
                ClienteCadastroView.TxtEnd.Text = null;
                ClienteCadastroView.ChkFornecedor.Checked = false;


                ClienteCadastroView.RchObs.Text = null;
                ClienteCadastroView.TxtTelefone.Text = null;
                ClienteCadastroView.TxtNumero.Text = null;

                ClienteCadastroView.LblAtivo.Text = null;

                this.ClienteCadastroView.TxtBairro.BackColor = Color.White;
                this.ClienteCadastroView.CbmCidade.BackColor = Color.White;
                this.ClienteCadastroView.TxtCPF.BackColor = Color.White;
                this.ClienteCadastroView.TxtEnd.BackColor = Color.White;
                this.ClienteCadastroView.TxtNome.BackColor = Color.White;
                this.ClienteCadastroView.TxtNumero.BackColor = Color.White;

                this.ClienteCadastroView.DgvHistorico.DataSource = null;

            }
            else
            {
                ClienteCadastroView.TxtId.Text = cliente.Id.ToString();
                ClienteCadastroView.TxtNome.Text = cliente.Nome;
                ClienteCadastroView.TxtBairro.Text = cliente.Bairro;

                ClienteCadastroView.TxtNumero.Text = cliente.Numero;
                ClienteCadastroView.TxtComp.Text = cliente.Complemento;
                ClienteCadastroView.CbmCidade.SelectedItem = cidade.SingleOrDefault(x => x.Id == cliente.Cidade);
                ClienteCadastroView.TxtEnd.Text = cliente.Endereco;

                ClienteCadastroView.ChkFornecedor.Checked = cliente.Fornecedor;
                ClienteCadastroView.RchObs.Text = cliente.Obs;
                ClienteCadastroView.TxtCPF.Text = cliente.Cpf.CpfCnpjMascara();
                ClienteCadastroView.TxtTelefone.Text = cliente.Telefone.TelefoneMascara();

                this.ClienteCadastroView.DgvHistorico.DataSource = regraCliente.ListaNotasHistoricas(cliente.Id);


                this.ClienteCadastroView.DgvHistorico.Columns["Id"].Width = 30;
                this.ClienteCadastroView.DgvHistorico.Columns["Nota"].Width = 160;
                this.ClienteCadastroView.DgvHistorico.Columns["Data"].Width = 70;
                this.ClienteCadastroView.DgvHistorico.Columns["EOperacao"].Width = 70;

                ClienteCadastroView.LblAtivo.Text = cliente.Ativo ? "Ativo" : "Inativo";

                ClienteCadastroView.LblAtivo.ForeColor = cliente.Ativo ? Color.DarkGreen : Color.Red;

            }
        }

        public virtual void FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show(this.Pai.PrincipalView, "Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}





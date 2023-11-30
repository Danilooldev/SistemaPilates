using FichasPilates.Enumerador;
using FichasPilates.Janelas;
using FichasPilates.Modelos;
using FichasPilates.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichasPilates.Controller
{
    public class CtrlNovaFicha
    {
        public FormNovaFicha frm = new FormNovaFicha();

        private FichaRepository repositorio = new FichaRepository();

        private long? id = null;

        public CtrlNovaFicha()
        {
            DelegarEventos();

            InicializarCampos();


            frm.ShowDialog();

        }

        private void InicializarCampos()
        {
            //chlEquilibrio.SetCheckedListBoxItemsGeneric<EEquilibrio>(0);
            //chlSolo.SetCheckedListBoxItemsGeneric<ESolo>(0);


        }

        private void RecuperandoDados()
        {
            //chlEquilibrio.SetCheckedListBoxItemsGeneric<EEquilibrio>(5000);
            //chlSolo.SetCheckedListBoxItemsGeneric<ESolo>(522);
        }

        private void DelegarEventos()
        {
            frm.btnSalvar.Click += BtnSalvar_Click;
           
            frm.btnPesquisar.Click += BtnPesquisar_Click;

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            CtrlPesquisaPaciente ctrlPesquisaPaciente = new CtrlPesquisaPaciente();

            ctrlPesquisaPaciente.frm.ShowDialog();

            var retorno = ctrlPesquisaPaciente.RetornaObjetoSelecionado();

            ObjetoParaTela(retorno);

            "".ToString();



        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void ObjetoParaTela(ModelNovaFicha modelo = null)
        {
            if (modelo != null)
            {
                this.id = modelo.Id;

                frm.txtNome.Text = modelo.Nome;
                frm.txtEnd.Text = modelo.Endereco;
                frm.txtAnamnese.Text = modelo.Anamnese;
                frm.txtCel.Text = modelo.Celular;
                frm.txtCirurgias.Text = modelo.Cirurgias;
                frm.dteNascimento.Value = modelo.DataNasc;
                frm.txtExames.Text = modelo.Exames;
                frm.rchObjetivo.Text = modelo.Objetivo;
                frm.txtPatologia.Text = modelo.Patologia;
                frm.txtProfissao.Text = modelo.Profissao;
                frm.txtQueixaPrincipal.Text = modelo.QueixaPrincipal;
                frm.rbtFeminino.Checked = !modelo.Sexo;
                frm.rbtMasculino.Checked = modelo.Sexo;
                frm.txtTel.Text = modelo.Telefone;
                
            }
            else
            {
                this.id = null;

                frm.txtNome.Text = null;
                frm.txtEnd.Text = null;
                frm.txtAnamnese.Text = null;
                frm.txtCel.Text = null;
                frm.txtCirurgias.Text = null;
                frm.dteNascimento.Value = DateTime.Now;
                frm.txtExames.Text = null;
                frm.rchObjetivo.Text = null;
                frm.txtPatologia.Text = null;
                frm.txtProfissao.Text = null;
                frm.txtQueixaPrincipal.Text = null;
                frm.txtTel.Text = null;
                frm.rbtFeminino.Checked = false;
                frm.rbtMasculino.Checked = false;
            }
        }


        private ModelNovaFicha TelaParaObjeto()
        {
            ModelNovaFicha modelo = new ModelNovaFicha
            {
                Nome = frm.txtNome.Text,
                Endereco = frm.txtEnd.Text,
                Anamnese = frm.txtAnamnese.Text,
                Celular = frm.txtCel.Text,
                Cirurgias = frm.txtCirurgias.Text,
                DataNasc = frm.dteNascimento.Value,
                Exames = frm.txtExames.Text,
                Objetivo = frm.rchObjetivo.Text,
                Patologia = frm.txtPatologia.Text,
                Profissao = frm.txtProfissao.Text,
                QueixaPrincipal = frm.txtQueixaPrincipal.Text,
                Sexo = !frm.rbtFeminino.Checked,
                Telefone = frm.txtTel.Text,
                Id = this.id.GetValueOrDefault()

            };

            return modelo;

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            ModelNovaFicha modelo = TelaParaObjeto();

            repositorio.Salvar(modelo);

            MessageBox.Show("Salvo com sucesso!");

            ObjetoParaTela();

            frm.Close();

        }



    }





}

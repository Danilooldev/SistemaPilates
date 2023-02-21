using FichasPilates.Enumerador;
using FichasPilates.Janelas;
using FichasPilates.Modelos;
using FichasPilates.Repositorio;
using System;
using System.Collections.Generic;
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


        }


        private ModelNovaFicha TelaParaObjeto()
        {
            int sex = frm.rbtFeminino.Checked ? 0 : 1;

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
                Sexo = sex,
                Telefone = frm.txtTel.Text

            };

            return modelo;

        }

        private void LimparTela()
        {
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
            frm.rbtFeminino.Checked = true;

        }


        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            ModelNovaFicha modelo = TelaParaObjeto();

            repositorio.Salvar(modelo);

            MessageBox.Show("Salvo com sucesso!");

            LimparTela();
        }
    }


    public class ModeloFicha
    {
        public string Nome { get; set; }

        public string End { get; set; }
    }


}

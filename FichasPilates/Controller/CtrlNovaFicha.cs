using FichasPilates.Enumerador;
using FichasPilates.Janelas;
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

        private RepositorioNovaFicha repositorio = new RepositorioNovaFicha();

        public CtrlNovaFicha()
        {
            DelegarEventos();

            InicializarCampos();

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


        private ModeloFicha TelaParaObjeto()
        {
            ModeloFicha modelo = new ModeloFicha
            {
                Nome = frm.txtNome.Text,
                End = frm.txtEnd.Text
            };

            return modelo;

        }

        private void LimparTela()
        {
            frm.txtNome.Text = null;
            frm.txtEnd.Text = null;
        }


        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            ModeloFicha modelo = TelaParaObjeto();

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

    public class RepositorioNovaFicha
    {
        public void Salvar(ModeloFicha modelo)
        {
            MessageBox.Show("SALVE NO BANCO\n\n\n" + modelo.Nome + "\n" + modelo.End);

            // conectar com o banco e mandar salvar....
        }
    }

}

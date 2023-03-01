using FichasPilates.Enumerador;
using FichasPilates.Janelas;
using FichasPilates.Modelos;
using FichasPilates.Repositorio;
using FichasPilates.Utilitarios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichasPilates.Controller
{
   public class CtrlEvolucao
      
    {
        public FormEvolucao frm = new FormEvolucao();
        private EvolucaoRepository repositorio = new EvolucaoRepository();

        private Int64 idUsuario;
        
        public CtrlEvolucao(Int64 idUsuario) 
        {
            this.idUsuario = idUsuario;


            InicializarCamp();

            DelegarEventos();

            frm.ShowDialog();
            

        
        }

        private void DelegarEventos()
        {

            ModelEvolucao model = new ModelEvolucao();


            frm.btnSalvar.Click += BtnSalvar_Click;
            
         

            
        }
        


        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var dadosDaTela = PegarDadosTela();

            repositorio.Salvar(dadosDaTela);

            //var objetoParaBanco = new ModelEvolucaoBancoDeDados(dadosDaTela);

            MessageBox.Show("Adicionado Com Sucesso!");

            frm.DialogResult = DialogResult.OK;
            


        }
        

        private ModelEvolucao PegarDadosTela()
        {
            ModelEvolucao modelo = new ModelEvolucao();

            modelo.IdUsuario = this.idUsuario;
            modelo.Slack = frm.chlSlack.RetornaSomatorioFlags<ESlack>();
            modelo.Equilibrio = frm.chlEquilibrio.RetornaSomatorioFlags<EEquilibrio>();
            modelo.Solo = frm.chlSolo.RetornaSomatorioFlags<ESolo>();
            modelo.Reformer = frm.chlReformer.RetornaSomatorioFlags<EReformer>();
            modelo.Cadilac = frm.chlCadilac.RetornaSomatorioFlags<ECadilac>();
            modelo.Chair = frm.chlChair.RetornaSomatorioFlags<EChair>();
            modelo.Barrel = frm.chlBarrel.RetornaSomatorioFlags<EBarrel>();
            modelo.Skate = frm.chlSkate.RetornaSomatorioFlags<ESkate>();
            modelo.Skier = frm.chlSkier.RetornaSomatorioFlags<ESkier>();
            modelo.Lira = frm.chlLira.RetornaSomatorioFlags<ELira>();
            modelo.Fixball = frm.chlFixball.RetornaSomatorioFlags<EFixball>();
            modelo.Data = frm.dateTimePicker1.Value;

            return modelo;
        }
        


        private void InicializarCamp()
        {
            frm.chlEquilibrio.SetCheckedListBoxItemsGeneric<EEquilibrio>(0);
            frm.chlSolo.SetCheckedListBoxItemsGeneric<ESolo>(0);
            frm.chlReformer.SetCheckedListBoxItemsGeneric<EReformer>(0);
            frm.chlCadilac.SetCheckedListBoxItemsGeneric<ECadilac>(0);
            frm.chlChair.SetCheckedListBoxItemsGeneric<EChair>(0);

            frm.chlBarrel.SetCheckedListBoxItemsGeneric<EBarrel>(0);
            frm.chlSkate.SetCheckedListBoxItemsGeneric<ESkate>(0);
            frm.chlSlack.SetCheckedListBoxItemsGeneric<ESlack>(0);
            frm.chlSkier.SetCheckedListBoxItemsGeneric<ESkier>(0);
            frm.chlLira.SetCheckedListBoxItemsGeneric<ELira>(0);

            frm.chlFixball.SetCheckedListBoxItemsGeneric<EFixball>(0);

        }

        
        
            
            
           





    }
}

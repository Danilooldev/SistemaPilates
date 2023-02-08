using FichasPilates.Enumerador;
using FichasPilates.Janelas;
using FichasPilates.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichasPilates.Controller
{
   public class CtrlEvolucao
      
    {
        public FormEvolucao frm = new FormEvolucao();
        public CtrlEvolucao() 
        { 
            
            InicializarCamp(); 
        
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

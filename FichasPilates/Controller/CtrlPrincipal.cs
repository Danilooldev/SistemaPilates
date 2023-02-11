using FichasPilates.Janelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasPilates.Controller
{
    public class CtrlPrincipal
    {

        public FormPrincipal frmPrincipal = new FormPrincipal();


        public CtrlPrincipal()
        {
             DelegarEventos();
        }

        private void DelegarEventos()
        {
            frmPrincipal.btnBuscarFicha.Click += btnBuscarFicha_Click;
            frmPrincipal.btnNovaFicha.Click += btnNovaFicha_Click;
        }

      

        private void btnNovaFicha_Click(object sender, EventArgs e)
        {

            CtrlNovaFicha ctrlNovaFicha = new CtrlNovaFicha();

            

            //FormNovaFicha formNovaFicha = new FormNovaFicha();
            //formNovaFicha.ShowDialog();
        }

        private void btnBuscarFicha_Click(object sender, EventArgs e)
        {
            CtrlFicha ctrlFicha = new CtrlFicha();
            
        }

    }
}

using FichasPilates.Janelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasPilates.Controller
{
    public class CtrlFicha
    {
        public FarmFicha frm = new FarmFicha();

        public CtrlFicha()
        {
            DelegarEvento();

            frm.ShowDialog();

        }
        private void DelegarEvento()
        {
            frm.btnAdicionar.Click += BtnAdicionar_Click;
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            CtrlEvolucao ctrl = new CtrlEvolucao();

        }
    }
}

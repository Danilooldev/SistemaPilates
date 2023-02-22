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
        public FormPesquisaPaciente frmPesquisar = new FormPesquisaPaciente();

        public CtrlFicha()
        {
            DelegarEvento();

            frm.Show();
            frmPesquisar.ShowDialog();

        }
        private void BtnPesquiar(object sender, EventArgs e)
        {
            frmPesquisar.ShowDialog();
        }

        private void DelegarEvento()
        {
            frmPesquisar.Click += BtnPesquiar;
            frm.btnAdicionar.Click += BtnAdicionar_Click;
            
            
        }
        

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            CtrlEvolucao ctrl = new CtrlEvolucao();

        }
    }
}

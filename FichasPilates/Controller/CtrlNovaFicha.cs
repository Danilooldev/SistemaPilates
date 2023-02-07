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

        public CtrlNovaFicha()
        {
            DelegarEventos();
        }

        private void DelegarEventos()
        {
            frm.btnSalvar.Click += BtnSalvar_Click;

           
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Colocar pra chamar o repositorio");
        }
    }
}

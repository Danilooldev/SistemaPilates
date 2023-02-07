using KS_System.Controles.Cadastros;
using KS_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KS_System.Controles
{
    public class CtrlPrincipal
    {

        public IPrincipal Principal { get; set; }

        public CtrlPrincipal()
        {
            Principal = new FrmPrincipal();

            DelegarEventos();
        }

        private void DelegarEventos()
        {
            Principal.MenuCadastro.Click += MenuCadastro_Click;

            Principal.PrincipalView.FormClosing += FormClosing;

            Principal.MenuMercadoria.Click += MenuMercadoria_Click;



        }

        private void MenuMercadoria_Click(object sender, EventArgs e)
        {
            new CtrlMercadoria(Principal);
        }

        private void MenuCadastro_Click(object sender, EventArgs e)
        {
            new CtrlCliente(Principal);
        }




        public virtual void FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show(this.Principal.PrincipalView, "Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}

using KS_System.Interfaces;
using KS_System.Interfaces.Cadastros;
using KS_System.Visualizacoes.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KS_System.Controles.Cadastros
{
    public class CtrlCliente
    {

        public ICliente Cliente { get; set; } 

        public CtrlCliente(IPrincipal principal)
        {
            Cliente = new FrmCliente();

            Cliente.ClienteView.MdiParent = principal.PrincipalView;

            Cliente.ClienteView.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;


            Cliente.ClienteView.Show();


            DelegarEventos();
        }

        private void DelegarEventos()
        {
           
        }



        public virtual void FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show(this.Cliente.ClienteView, "Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}

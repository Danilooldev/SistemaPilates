using Relatorios.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Controles.Cadastros;
using WindowsFormsApp6.Controles.Movimentacao;
using WindowsFormsApp6.Controles.Utilitarios;

namespace WindowsFormsApp6
{
    public class CtrlPrincipal
    {
        bool usarTelaClassica = true;
        public IPrincipalView Principal { get; set; }

        public CtrlPrincipal()
        {
            // if (usarTelaClassica)
            Principal = new FormPrincipal();
            //else
            //    Principal = new FrmPrincipal2();

            DelegarEventos();
        }

        private void DelegarEventos()
        {
            Principal.MenuClientes.Click += MenuClientes_Click;

            Principal.MenuEntradas.Click += MenuEntradas_Click;

            Principal.MenuMercadorias.Click += MenuMercadorias_Click;

            Principal.MenuSaidas.Click += MenuSaidas_Click;

            Principal.MenuCancelamentoSaida.Click += MenuCancelamentoSaida_Click;

            Principal.MenuConfiguracoes.Click += MenuConfiguracoes_Click;

            Principal.MenuRelatorios.Click += MenuRelatorios_Click;

            Principal.MenuImportar.Click += MenuImportar_Click;

            Principal.PrincipalView.FormClosing += FormClosing;

        }

        private void MenuImportar_Click(object sender, EventArgs e)
        {
            new CtrlImportacao(Principal);
        }

        private void MenuRelatorios_Click(object sender, EventArgs e)
        {
            new CtrlRelatorios(Principal, null);
        }

        private void MenuCancelamentoSaida_Click(object sender, EventArgs e)
        {
            new CtrlCancelamentoSaida(Principal);
        }

        private void MenuConfiguracoes_Click(object sender, EventArgs e)
        {
            new CtrlConfiguracao(Principal);
        }

        private void MenuSaidas_Click(object sender, EventArgs e)
        {
            new CtrlSaida(Principal);
        }

        private void MenuMercadorias_Click(object sender, EventArgs e)
        {
            new CtrlCadastroMercadoria(Principal);
        }

        private void MenuEntradas_Click(object sender, EventArgs e)
        {
            new CtrlEntrada(Principal);
        }

        private void MenuClientes_Click(object sender, EventArgs e)
        {
            new CtrlCadastroCliente(Principal);
        }

        public string Fatorial(int valor)
        {
            int resultado = valor;

            for (int i = (int)valor - 1; i > 0; i--)
                resultado *= i;

            return resultado.ToString();
        }

        public void Teste()
        {



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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Enumeradores;
using WindowsFormsApp6.Interface.Movimentacao;
using WindowsFormsApp6.Menus.Movimentacao;
using WindowsFormsApp6.Modelos.Movimentacao;
using WindowsFormsApp6.Repositorios.Movimentacao;

namespace WindowsFormsApp6.Controles.Movimentacao
{
    public class CtrlCancelamentoSaida
    {
        ICancelamentoSaida CancelamentoSaidaView { get; set; }

        RepositorioMovimentacao repositorio = new RepositorioMovimentacao();

        public CtrlCancelamentoSaida(IPrincipalView pai)
        {
            CancelamentoSaidaView = new FrmCancelamentoSaida();

            CancelamentoSaidaView.CancelamentoView.MdiParent = pai.PrincipalView;

            CancelamentoSaidaView.CancelamentoView.StartPosition = FormStartPosition.CenterScreen;

            CancelamentoSaidaView.CancelamentoView.Show();

            DelegarEventos();

        }

        private void DelegarEventos()
        {
            this.CancelamentoSaidaView.BtnBuscar.Click += BtnBuscar_Click;
            this.CancelamentoSaidaView.BtnExecutar.Click += BtnExecutar_Click;

        }

        private void BtnExecutar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.CancelamentoSaidaView.DgvLista.RowCount < 1)
                    return;

                if (this.CancelamentoSaidaView.DgvLista.CurrentRow is null)
                    this.CancelamentoSaidaView.DgvLista.Focus();

                ModelMovimentacaoPeriodo nota = this.CancelamentoSaidaView.DgvLista.CurrentRow.DataBoundItem as ModelMovimentacaoPeriodo;
                repositorio.CancelarNotaDeSaida(nota.Id);

                MessageBox.Show("Cancelamento da venda realizado com sucesso");

                RealizarBusca();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar realizar cancelamento\n\n" + ex.Message);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            RealizarBusca();
        }

        private void RealizarBusca()
        {
            DateTime inicio = this.CancelamentoSaidaView.DteInicio.Value;
            DateTime fim = this.CancelamentoSaidaView.DteFim.Value;

            CarregarNotas(inicio, fim);

        }

        private void CarregarNotas(DateTime inicio, DateTime final)
        {
            string ini = inicio.ToString("yyyy-MM-ddT00:00:00");
            string fim = final.ToString("yyyy-MM-ddT23:59:59");

            var notas = repositorio.ListarNotasPorPeriodo(EOperacaoMovimento.Saida, EStatusMovimento.P, ini, fim);

            CancelamentoSaidaView.DgvLista.DataSource = notas.ToList();

            this.CancelamentoSaidaView.DgvLista.Columns["Id"].Width = 70;
            this.CancelamentoSaidaView.DgvLista.Columns["Nome"].Width = 150;
            this.CancelamentoSaidaView.DgvLista.Columns["ValorLiquidoTotal"].Width = 80;
        }
    }
}

using Relatorios.Enumeradores;
using Relatorios.Filtros;
using Relatorios.Filtros.Abstrato;
using Relatorios.Interfaces;
using System;
using System.Windows.Forms;

namespace Relatorios.ControllerFiltros
{
    public abstract class ACtrlFiltroRelatorio
    {
        IFiltroRelatorio FiltroView { get; set; }

        public abstract UserControl Controle { get; }

        public virtual object[] dadosFiltro { get; }

        public virtual void ConfiguraUserControl() { }

        public abstract object ControlRelatorio();

        private string nomeRelatorio;

        public IBotoesRelatorio BotoesRelatorio { get; set; }

        public ACtrlFiltroRelatorio(ERelatorio relatorio)
        {
            this.FiltroView = new FrmFiltro();
            this.BotoesRelatorio = new UCBotoesFiltro();

            this.nomeRelatorio = "Relatório " + (int)relatorio;

            this.ConfiguraUserControl();
            this.AdicionaUserControls();
            this.AjustaTelaConformeUserControls();

            this.DelegarEventos();

            this.FiltroView.FiltroView.ShowDialog();
        }

        private void AjustaTelaConformeUserControls()
        {
            int largura = Controle.Width > BotoesRelatorio.BotoesFiltroView.Width + 10 ? Controle.Width : BotoesRelatorio.BotoesFiltroView.Width + 10;
            int altura = Controle.Height + BotoesRelatorio.BotoesFiltroView.Height + 30;

            this.FiltroView.Painel.Width = largura;
            this.FiltroView.Painel.Height = altura - 25;

            this.FiltroView.Grupo.Width = largura + 10;
            this.FiltroView.Grupo.Height = altura + 22;

            this.FiltroView.FiltroView.Width = largura + 50;
            this.FiltroView.FiltroView.Height = altura + 110;

            this.Controle.Width = largura + 10;
            this.BotoesRelatorio.BotoesFiltroView.Width = largura;

        }

        private void AdicionaUserControls()
        {
            this.FiltroView.Painel.Controls.Add(this.Controle);
            this.FiltroView.Painel.Controls.Add(this.BotoesRelatorio.BotoesFiltroView);

            if (this.nomeRelatorio.Length > 20)
                "".ToString();

            this.FiltroView.NomeRelatorio.Text = this.nomeRelatorio;
            //this.FiltroView.NomeRelatorio.Controls.Wr
        }

        private void DelegarEventos()
        {
            this.BotoesRelatorio.BtnOk.Click += BtnOk_Click;
            this.BotoesRelatorio.BtnCancelar.Click += BtnCancelar_Click;

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.FiltroView.FiltroView.DialogResult = DialogResult.Cancel;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.ControlRelatorio();
        }
    }
}
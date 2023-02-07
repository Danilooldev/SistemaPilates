using Relatorios.Controller.Cadastros;
using Relatorios.ControllerFiltros;
using Relatorios.Enumeradores;
using Relatorios.Filtros.Venda;
using System.Windows.Forms;
using static WindowsFormsApp6.Utilitarios.Util;

namespace Relatorios.CtrlFiltros.Cadastro
{
    public class BehaviorFiltro002 : ACtrlFiltroRelatorio
    {
        private UCFiltro002 filtroRelatorio = new UCFiltro002();

        public BehaviorFiltro002(ERelatorio relatorio) : base(relatorio)
        {


        }
        public override void ConfiguraUserControl()
        {
            var carregar = SetDataSource.Carregar(typeof(EAtivo));

            this.filtroRelatorio.Situacao.DataSource = carregar;
            this.filtroRelatorio.Situacao.DisplayMember = SetDataSource.Mostrador;
            this.filtroRelatorio.Situacao.ValueMember = SetDataSource.Valor;

            this.filtroRelatorio.Situacao.SelectedIndex = 2;
        }

        public override object[] dadosFiltro => new object[1] { this.filtroRelatorio.Situacao.SelectedValue };

        public override UserControl Controle => filtroRelatorio;

        public override object ControlRelatorio() => new CtrlRelatorio02ListaMercadorias(dadosFiltro);


    }
}

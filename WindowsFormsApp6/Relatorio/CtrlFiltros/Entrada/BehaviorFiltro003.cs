using Relatorios.Controller.Cadastros;

using Relatorios.ControllerFiltros;
using Relatorios.Enumeradores;
using Relatorios.Filtros.Venda;
using System.Windows.Forms;

namespace Relatorios.CtrlFiltros.Entrada
{
    public class BehaviorFiltro003 : ACtrlFiltroRelatorio
    {
        private UCFiltro003 filtroRelatorio = new UCFiltro003();

        public BehaviorFiltro003(ERelatorio relatorio) : base(relatorio) { }

        public override object[] dadosFiltro => new object[] { this.filtroRelatorio.DateInicio.Value, this.filtroRelatorio.DateFim.Value };

        public override UserControl Controle => filtroRelatorio;

        public override object ControlRelatorio() => new CtrlRelatorio03EntradaNotas(dadosFiltro);


    }
}

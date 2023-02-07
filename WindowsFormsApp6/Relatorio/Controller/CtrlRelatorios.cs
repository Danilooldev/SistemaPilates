using Relatorios.CtrlFiltros.Cadastro;
using Relatorios.CtrlFiltros.Entrada;
using Relatorios.Enumeradores;
using WindowsFormsApp6;

namespace Relatorios.Controller
{
    /// <summary>
    /// Nesta classe fica as chamadas para os relatorios
    /// separa a regra de geração com a inserção de relatórios
    /// </summary>

    public class CtrlRelatorios : ARelatorios
    {
        public CtrlRelatorios(IPrincipalView Pai, string categoria) : base(Pai, categoria) { }

        public override void AbrirRelatorioDesejado()
        {
            ERelatorio relatorio = (ERelatorio)this.RelatorioView.ListaRelatorio.SelectedValue;

            switch (relatorio)
            {
                case ERelatorio.ListaClientes01:
                    new BehaviorFiltro001(ERelatorio.ListaClientes01);
                    break;

                case ERelatorio.ListaMercadorias02:
                    new BehaviorFiltro002(ERelatorio.ListaMercadorias02);
                    break;

                case ERelatorio.NotaEntadaPeriodo03:
                    new BehaviorFiltro003(ERelatorio.NotaEntadaPeriodo03);
                    break;

                case ERelatorio.VendaDeMercadoriaPorPeriodo04:
                    new BehaviorFiltro004(ERelatorio.VendaDeMercadoriaPorPeriodo04);
                    break;

                default:
                    //Alerta("Relatório", "Relatório ainda não foi implementado");
                    break;
            }
        }


    }
}

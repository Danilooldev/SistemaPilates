using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorios.Enumeradores
{
    /// <summary>
    /// Atenção 
    /// O numero do enumerador DEVE ser o mesmo número do relatório
    /// </summary>
    public enum ERelatorio
    {
        [Description("Relatório 01 - Lista de Parceiros (Clientes e Fornecedores)"), Category("Cadastro")]
        ListaClientes01 = 1,

        [Description("Relatório 02 - Lista de Mercadorias e estoque"), Category("Cadastro")]
        ListaMercadorias02 = 2,

        [Description("Relatório 03 - Notas de Entrada por período"), Category("Entrada")]
        NotaEntadaPeriodo03 = 3,

        [Description("Relatório 04 - Venda de Mercadorias por período"), Category("Saida")]
        VendaDeMercadoriaPorPeriodo04 = 4


    }
}

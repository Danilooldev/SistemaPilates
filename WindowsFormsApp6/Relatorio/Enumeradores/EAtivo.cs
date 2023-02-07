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
    public enum EAtivo
    {
        [Description("Ativo")]
        Ativo = 1,

        [Description("Inativo")]
        Inativo = 0,

        [Description("Todos")]
        Todos = 4

    }
}

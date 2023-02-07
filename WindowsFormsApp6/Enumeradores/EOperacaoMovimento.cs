using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.Enumeradores
{
    public enum EOperacaoMovimento
    {
        [Description("Entrada")]
        Entrada = 1,

        [Description("Saída")]
        Saida = 2
    }
}

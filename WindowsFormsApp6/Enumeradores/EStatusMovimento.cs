using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.Enumeradores
{
    [Flags]
    public enum EStatusMovimento
    {
        [Description("Memória")]
        M = 1,

        [Description("Processada")]
        P = 2,

        [Description("Estornada")]
        E = 4


    }
}

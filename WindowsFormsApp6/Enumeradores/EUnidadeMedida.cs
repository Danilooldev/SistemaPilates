using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.Enumeradores
{
    public enum EUnidadeMedida
    {
        [Description("Unidade")]
        Un = 1,

        [Description("Dúzia")]
        Dz = 12,

        [Description("Meia Dúzia")]
        Mdz = 6

    }
}

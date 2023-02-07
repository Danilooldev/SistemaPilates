using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasPilates.Enumerador
{
    [Flags]
    public enum EEquilibrio
    {

        Livre = 1,

        [Description("Meia Lua")]
        MeiaLua = 2,

        Bozu = 4,

        Disco = 8,




    }
}

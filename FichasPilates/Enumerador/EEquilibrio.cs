using FichasPilates.Controller;
using FichasPilates.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FichasPilates.Enumerador
{
    [Flags]

    [TypeConverter(typeof(EnumDescricaoListagem))]
    public enum EEquilibrio
    {

        Livre = 1,

        [Description("Meia Lua")]
        MeiaLua = 2,

        Bozu = 4,

        Disco = 8,




    }
}

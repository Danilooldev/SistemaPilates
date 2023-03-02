using FichasPilates.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasPilates.Enumerador
{
    [Flags]
    [TypeConverter(typeof(EnumDescricaoListagem))]
    public enum ESolo
    {

        Livre = 1,

        Bolinha = 2,

        Rolo = 4,

        Theraband = 8,

        [Description("Magic Circule")]
        MagicCircule = 16,

        Halter= 32,
        
        MiniBand= 64,





    }
}

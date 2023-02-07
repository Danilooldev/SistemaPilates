using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relatorios.Interfaces
{
    public interface IBotoesRelatorio
    {

        UserControl BotoesFiltroView { get; }

        Button BtnOk { get; }

        Button BtnCancelar { get; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relatorios.Interfaces
{
    public interface IRelatorio
    {

        Form RelatorioView { get; }

        ListBox ListaRelatorio { get; }

        Button AbreRelatorio { get; }

        Button FechaTela { get; }
    }
}

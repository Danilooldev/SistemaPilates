using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6.Interface
{
    public interface IPesquisar
    {
        TextBox TxtPesquisar { get; }

        DataGridView GrdPesquisar { get; }

        Form TelaPesquisa { get; }

    }
}

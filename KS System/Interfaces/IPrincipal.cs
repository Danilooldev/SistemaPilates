using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KS_System.Interfaces
{
    public interface IPrincipal
    {

        Form PrincipalView { get; }

        ToolStripMenuItem MenuCadastro { get; }
        ToolStripMenuItem MenuMercadoria { get; }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6.Interface.Utilitarios
{
    public interface IImportador
    {

        Form ImportadorView { get; }

        TextBox TxtCaminho { get; }

        Button BtnImportar { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace FichasPilates.Utilitarios
{
    public static class ExtensionRadioButton
    {

        public static void SelecionarRadio(this IList<RadioButton> listaButton, int valor)
        {
            listaButton[valor - 1].Checked = true;
        }

        public static int RadioSelecionado(this IList<RadioButton> listaButton)
        {
            for (int i = 0; i < listaButton.Count(); i++)
                if (listaButton[i].Checked)
                    return i + 1;

            return 0;
        }
    }
}
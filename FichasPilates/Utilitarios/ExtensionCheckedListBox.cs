using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichasPilates.Utilitarios
{
    public static class ExtensionCheckedListBox
    {
        public static void SetCheckedListBoxItemsGeneric<T>(this CheckedListBox chl, int value)
        {
            chl.Items.Clear();

            foreach (int enumValue in Enum.GetValues(typeof(T)))
            {
                CheckState state = CheckState.Unchecked;

                if ((value & enumValue) == enumValue)
                {
                    value ^= enumValue;
                    state = CheckState.Checked;

                }

                Type enumType = typeof(T);

                Enum valor = (Enum)Enum.ToObject(enumType, enumValue);

                chl.Items.Add(EnumPelaDescricao.Descricao(valor), state);

            }

        }



    }
}

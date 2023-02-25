using FichasPilates.Enumerador;
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

        public static T RetornaSomatorioFlags<T>(this CheckedListBox chl) where T : Enum
        {
            var lista = chl.CheckedItems;

            int valor = 0;

            foreach (var obj in lista)
                valor += (int)Enum.Parse(typeof(T), obj.ToString().Replace(" ", String.Empty));

            Type enumType = typeof(T);

            return (T)Enum.ToObject(enumType, valor);
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6.Utilitarios
{
    public static class Util
    {

        public static String CpfCnpjMascara(this String texto)
        {
            if (!string.IsNullOrEmpty(texto))
                if (texto.Length == 11)
                    return Convert.ToUInt64(texto).ToString(@"000\.000\.000\-00");
                else if (texto.Length == 14)
                    return Convert.ToUInt64(texto).ToString(@"00\.000\.000\/0000\-00");
                else
                    return texto;
            return null;
        }

        public static string RetornaTextoParaBusca(this object sender, KeyPressEventArgs e)
        {
            string stringDigitada = "";

            if (e.KeyChar == '\b')
                (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;

            else
                stringDigitada = e.KeyChar.ToString();

            string texto = (sender as TextBox).Text + stringDigitada;

            if (e.KeyChar == '\b')
            {
                if (texto.Length > 0)
                    texto = texto.Substring(0, texto.Length - 1);
            }

            return texto;
        }

        public static class SetDataSource
        {
            public static string Mostrador = "Value";

            public static string Valor = "Key";

            public static IList Carregar(Type tipo) { return EnumPelaDescricao.Listar(tipo); }


        }

    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace WindowsFormsApp6.Utilitarios
{
    public static class Mascara
    {
        public static string CpfCnpj(this string formatoMascara)
        {
            string temp = formatoMascara;

            formatoMascara = temp.RemoveMascara();

            if (formatoMascara.Length == 14) return formatoMascara.Substring(0, 2) + "." + formatoMascara.Substring(2, 3) + "."
                    + formatoMascara.Substring(5, 3) + "." + formatoMascara.Substring(8, 4) + "/" + formatoMascara.Substring(12, 2);

            else if (formatoMascara.Length == 11) return formatoMascara.Substring(0, 3) + "." + formatoMascara.Substring(3, 3) + "."
                    + formatoMascara.Substring(6, 3) + "-" + formatoMascara.Substring(9, 2);

            else return formatoMascara;
        }

        public static string RemoveMascara(this string texto)
        {
            return texto.Trim()
               .Replace(".", "")
               .Replace(",", "")
               .Replace("-", "")
               .Replace("/", "")
               .Replace("(", "")
               .Replace(")", "")
               .Replace(@"\", "")
               .Replace(@" ", "")
               .Replace(@"'", "");

        }

        public static string RemoveCaracter(this string texto)
        {
            return texto.Trim().Replace(@"'", "");
        }

        public static string CEP(this string texto)
        {
            if (texto.Length >= 8) return texto.Substring(0, 5) + "-" + texto.Substring(5, 3);
            return texto;

        }

        public static TextBox TelefoneMascara(this TextBox texto)
        {
            string t = texto.Text.RemoverPontoTraco();

            if (!string.IsNullOrEmpty(t))
                if (t.Length == 8)
                    t = Convert.ToUInt64(t).ToString(@"0000\-0000");
                else if (t.Length == 9)
                    t = Convert.ToUInt64(t).ToString(@"0\ 0000\-0000");
                else if (t.Length == 10)
                    t = Convert.ToUInt64(t).ToString(@"\(00\)0000\-0000");
                else if (t.Length == 11)
                    t = Convert.ToUInt64(t).ToString(@"\(00\)0\ 0000\-0000");

            texto.Text = t;

            return texto;

        }
        public static string TelefoneMascara(this string t)
        {
            //999619015
            //43999619015
            //4399619015
            //12345678901
            //99961-9015
            t = t.RemoveMascara();

            if (!string.IsNullOrEmpty(t))
                if (t.Length == 8)
                    t = Convert.ToUInt64(t).ToString(@"0000\-0000");
                else if (t.Length == 9)
                    t = Convert.ToUInt64(t).ToString(@"0\ 0000\-0000");
                else if (t.Length == 10)
                    t = Convert.ToUInt64(t).ToString(@"\(00\)0000\-0000");
                else if (t.Length == 11)
                    t = Convert.ToUInt64(t).ToString(@"\(00\)0\ 0000\-0000");

            return t;

        }
        public static String RemoverPontoTraco(this String texto)
        {
            string s = texto.Normalize(NormalizationForm.FormD);

            StringBuilder sb = new StringBuilder();

            char[] acentos = new char[] { '.', '-', '/', '(', ')', ' ' };

            foreach (var caractere in s)
            {
                if (!acentos.Contains(caractere))
                {
                    UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(caractere);
                    if (uc != UnicodeCategory.NonSpacingMark)
                        sb.Append(caractere);
                }
            }

            return sb.ToString();
        }

    }
}

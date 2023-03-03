using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichasPilates.Utilitarios
{
    public static class ExtensionKeyPress
    {

        public static string RetornaTextoParaBusca(this object sender, KeyPressEventArgs e)
        {
            string stringDigitada = "";

            stringDigitada = e.KeyChar.ToString();

            string texto = (sender as TextBox).Text + stringDigitada;

            if (e.KeyChar == '\b')
            {
                if (texto.Length > 0)
                    texto = texto.Substring(0, texto.Length - 1);
            }

            return texto;
        }

        public static string RetornaTextoParaBusca(this object sender, KeyEventArgs e)
        {
            string texto = (sender as TextBox).Text;

            if (e.KeyValue == 46)
            {
                int start = (sender as TextBox).SelectionStart;

                if (texto.Length > 0)
                {
                    int quantidadeSelecionada = (sender as TextBox).SelectedText.Count();

                    var resto = texto.Substring(start + 1 + quantidadeSelecionada);

                    texto = texto.Remove(start, quantidadeSelecionada);

                    texto += resto;
                }
            }
            return texto;
        }
    }
}
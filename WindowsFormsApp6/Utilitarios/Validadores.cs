using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6.Utilitarios
{
    public static class Validadores
    {
        public static void CampoNumericoDecimal(object sender, KeyPressEventArgs e)
        {
            TextBox txtTemp = (TextBox)sender;

            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtTemp.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        public static void CampoNumericoDecimalNegPos(object sender, KeyPressEventArgs e)
        {
            TextBox txtTemp = (TextBox)sender;

            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtTemp.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        public static void CampoNumericoDecimalPonto(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar))
                && (e.KeyChar != '.') && (e.KeyChar != '-'))
                e.Handled = true;

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;

            // only allow minus sign at the beginning
            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
                e.Handled = true;
        }

        public static void DecimalAposFoco(object sender, EventArgs e)
        {
            TextBox txtTemp = (TextBox)sender;

            decimal valor = 0;

            txtTemp.Text = !txtTemp.Text.Equals(String.Empty) ? Decimal.Parse(txtTemp.Text).ToString("N2") : "0,00";
        }

        public static String RetornaValorDecimal(Decimal? valor)
        {
            string valorConvertido = Convert.ToString(valor);

            return !valorConvertido.Equals(String.Empty) ? Decimal.Parse(valorConvertido).ToString("N2") : "0,00"; ;
        }

        //public static TextBox EnderecoDeIp(this TextBox texto)
        //{
        //    IPAddress ipAddress;
        //    if (IPAddress.TryParse(texto.Text, out ipAddress))
        //    {
        //        texto.Text = ipAddress.ToString();
        //    }
        //    else
        //    {
        //        texto.Text = "INVÁLIDO";
        //    }
        //    return texto;
        //}

        public static String ApenasNumerosEVirgula(this string textoValor)
        {
            Regex rg = new Regex(@"^[0-9,]+$");
            String valor = String.Empty;

            for (int i = 0; i < textoValor.Length; i++)
                if (rg.IsMatch(textoValor[i].ToString()))
                    valor += textoValor[i];

            return valor;
        }

        public static TextBox SomenteNumeros(this TextBox textoValor)
        {
            Regex rg = new Regex(@"^[0-9]+$");
            String valor = String.Empty;

            for (int i = 0; i < textoValor.Text.Length; i++)
            {
                if (rg.IsMatch(textoValor.Text[i].ToString()))
                    valor += textoValor.Text[i];
            }
            textoValor.Text = valor;

            return textoValor;
        }

        public static void ApenasNumeros(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        public static bool CnpjValido(this string cnpj)
        {
            int[] num = new int[14];

            int temp = 0;

            int temp2 = 0;

            cnpj = Mascara.RemoveMascara(cnpj);

            for (int i = 0; i < num.Length; i++)
                num[i] = Convert.ToInt32(cnpj[i].ToString());

            // 1º Cálculo
            temp = (num[0] * 5) + (num[1] * 4) + (num[2] * 3) + (num[3] * 2) + (num[4] * 9) + (num[5] * 8) + (num[6] * 7) +
                (num[7] * 6) + (num[8] * 5) + (num[9] * 4) + (num[10] * 3) + (num[11] * 2);

            temp = (temp % 11 < 2 ? 0 : (11 - temp % 11));


            // 2º Cálculo
            temp2 = (num[0] * 6) + (num[1] * 5) + (num[2] * 4) + (num[3] * 3) + (num[4] * 2) + (num[5] * 9) + (num[6] * 8) +
                (num[7] * 7) + (num[8] * 6) + (num[9] * 5) + (num[10] * 4) + (num[11] * 3) + (temp * 2);

            temp2 = (temp2 % 11 < 2 ? 0 : (11 - temp2 % 11));

            if (temp == num[12] && temp2 == num[13]) return true;

            else return false;
        }

        public static bool CpfValido(this string cpf)
        {
            int[] num = new int[11];

            int temp = 0;

            int temp2 = 0;

            int cont = 2;

            cpf.RemoveMascara();

            num[9] = Convert.ToInt32(cpf[9].ToString());

            num[10] = Convert.ToInt32(cpf[10].ToString());

            for (int i = num.Length - 3; i >= 0; i--)
            {
                num[i] = Convert.ToInt32(cpf[i].ToString());

                temp += (num[i] * (cont++));
            }

            cont = 2;

            temp = (temp % 11 < 2 ? 0 : (11 - temp % 11));

            for (int i = num.Length - 2; i >= 0; i--)
                temp2 += num[i] * (cont++);

            temp2 = (temp2 % 11 < 2 ? 0 : (11 - temp2 % 11));

            if (temp == num[9] && temp2 == num[10]) return true;

            else return false;
        }

        //Função para verificação de erro de digitação do barcode.
        private static bool verificaErro(string codigoBarra)
        {   //Verifica se o número digitado não está vazio ou é nulo e se está entre 2 e 13.
            if (string.IsNullOrEmpty(codigoBarra) || !(codigoBarra.Length >= 2 && codigoBarra.Length <= 13))
                return false;
            else
            {      //Verifica se o número digitado é realmente um número.
                foreach (char caracter in codigoBarra)   //Com o foreach passamos caracter por caracter para dentro de uma 
                    if (!(char.IsNumber(caracter)))  //variável "caracter" e verificamos se ela é um número.
                        return false;            //Caso ache algo diferente de número retorna falso.      
                return true;//Sem erros, retorna verdadeiro.
            }
        }
        //Função do algoritmo em si, onde verifica o código verificador do barcode.
        private static bool verificaDigito(string codigoBarra)
        {                 //Declaração de variáveis
            int i, somaTotal, somaPar = 0, somaImpar = 0, multiplo, digito;
            for (i = 0; i < (codigoBarra.Length - 1); i++) //Laço para percorrer a String flexível ao seu tamanho.
            {
                if ((i + 1) % 2 == 0) //Verificação da posíção do número, se é par ou ímpar.
                    somaPar += (((int)(codigoBarra[i]) - 48) * 3); //Caso Par, multiplica-se por 3.
                else somaImpar += (((int)(codigoBarra[i]) - 48) * 1); //Caso Impar, multiplica-se por 1.
            }
            somaTotal = somaPar + somaImpar; // Soma de todos resultados.
            if (somaTotal % 10 != 0 && somaTotal > 10) //Algoritmo para encontrar o múltiplo de 10 mais perto, igual ou maior.
                multiplo = ((somaTotal / 10) + 1);
            else
                if (somaTotal < 10)
                multiplo = 1;
            else multiplo = somaTotal / 10;  //fim
            digito = (multiplo * 10) - somaTotal;//Diminui-se do múltiplo o valor da soma total.
            if (digito != ((int)(codigoBarra[codigoBarra.Length - 1]) - 48)) //Verifica-se o dígito é igual ao 13º número do barcode.
                return false; //Caso não, retorna falso.
            return true;  //Caso igual, retorna verdadeiro.

        }                //Observação importante: Ao tentar utilizar diversos tipos de conversão e não obter sucesso, me basiei na tabela
        //ascii para ter o valor (-48), ao usar os valores de char, nos momentos que precisei comparar int com string.

        public static bool VerificaSeCodigoBarraValido(string codigoBarra)
        {
            return verificaDigito(codigoBarra);

            ////while (!(verificaErro(codigoBarra)))
            ////{
            ////    Console.Write("ERRO! DIGITE O CÓDIGO DE BARRAS: ");
            ////    codigoBarra = Console.ReadLine();
            ////}

            //if (verificaDigito(codigoBarra))
            //{
            //    Console.WriteLine("CODIGO: {0}", codigoBarra);
            //    Console.WriteLine("CORRETO!");
            //    return true;
            //}

            //else
            //{
            //    //  Console.Clear();
            //    Console.WriteLine("CODIGO: {0}", codigoBarra);
            //    Console.WriteLine("INCORRETO!");
            //    return false;
            //}
        }

    }
}

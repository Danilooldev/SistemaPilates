using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Modelos;

namespace WindowsFormsApp6.Controles.Impressao
{
    public class ImpressaoLPT
    {
        public const short FILE_ATTRIBUTE_NORMAL = 0x80;
        public const short INVALID_HANDLE_VALUE = -1;
        public const uint GENERIC_READ = 0x80000000;
        public const uint GENERIC_WRITE = 0x40000000;
        public const uint CREATE_NEW = 1;
        public const uint CREATE_ALWAYS = 2;
        public const uint OPEN_EXISTING = 3;

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess,
          uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition,
          uint dwFlagsAndAttributes, IntPtr hTemplateFile);


        public void sendTextToLPT1(String receiptText, string porta)
        {
            IntPtr ptr = CreateFile(porta, GENERIC_WRITE, 0,
                     IntPtr.Zero, OPEN_EXISTING, 0, IntPtr.Zero);

            /* Is bad handle? INVALID_HANDLE_VALUE */
            if (ptr.ToInt32() == -1)
            {
                /* ask the framework to marshall the win32 error code to an exception */
                //   Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
                MessageBox.Show("Não encontrado");
            }
            else
            {
                FileStream lpt = new FileStream(ptr, FileAccess.ReadWrite);
                Byte[] buffer = new Byte[2048];
                //Check to see if your printer support ASCII encoding or Unicode.
                //If unicode is supported, use the following:
                //buffer = System.Text.Encoding.Unicode.GetBytes(Temp);


                buffer = System.Text.Encoding.ASCII.GetBytes(receiptText);
                lpt.Write(buffer, 0, buffer.Length);
                lpt.Close();
            }
        }

        public void AppendFormattedText(RichTextBox rtb, string text, Color textColour, Boolean isBold, HorizontalAlignment alignment)
        {
            int start = rtb.TextLength;
            rtb.AppendText(text);
            int end = rtb.TextLength; // now longer by length of appended text

            // Select text that was appended
            rtb.Select(start, end - start);

            #region Apply Formatting
            rtb.SelectionColor = textColour;
            rtb.SelectionAlignment = alignment;
            rtb.SelectionFont = new Font(
                 rtb.SelectionFont.FontFamily,
                 rtb.SelectionFont.Size,
                 (isBold ? FontStyle.Bold : FontStyle.Regular));
            #endregion

            // Unselect text
            rtb.SelectionLength = 0;
        }

        public void Outro()
        {

            ImprimeTexto imp = new ImprimeTexto();

            imp.Inicio("LPT1");



            imp.ImpLF(imp.Fonte24 + "TESTE PRIMEIRA FONTE" + imp.Normal);
            imp.ImpLF(imp.Fonte16 + "TESTE SEGUNDA FONTE" + imp.Normal);

            imp.ImpLF(string.Format(CultureInfo.InvariantCulture, "A26,96,0,4,1,1,N,\"{0}\"", "TESTE"));


            //imp.ImpLF(imp.Expandido + imp.Expandido + imp.NegritoOn + "Expandido" + imp.NegritoOff + imp.Normal);

            imp.ImpLF("Teste de impressoo");


            //imp.ImpLF("Tentando imprimir");
            //imp.ImpLF("-------------------------------------");
            //imp.ImpLF("Componente de impressao em modo texto");
            //for (int i = 0; i < 5; i++)
            //{
            //    imp.ImpLF("Linha impressa " + i.ToString());
            //}
            //imp.ImpLF(imp.NegritoOn + "Negrito ligado" + imp.NegritoOff);
            //imp.ImpLF(imp.Expandido + "Expandido" + imp.Normal);
            //imp.ImpLF(imp.Comprimido + "Comprimido" + imp.Normal);
            //imp.Pula(2);
            //imp.ImpCol(10, "Coluna 10");
            //imp.ImpCol(40, "Coluna 40");
            //imp.Pula(2);
            //imp.Imp((char)27 + "0");
            //imp.ImpLF("8 linha ppp");
            //imp.ImpLF("8 linha ppp");
            //imp.ImpLF("8 linha ppp");
            //imp.Imp((char)27 + "2");
            //imp.ImpLF("6 linha ppp");
            //imp.ImpLF("6 linha ppp");
            //imp.ImpLF("6 linha ppp");
            //imp.Pula(2);
            imp.Fim();
        }

        public void Imprimir(ModelImpressao impressao, string porta)
        {

            ImprimeTexto imp = new ImprimeTexto();

            int colunaTelefone = impressao.EmpresaNome.Length + 13;
            int segundaVia = 42;

            string separador2 = "- - - - - - - - - - - - - - - - - - --";
            string separador = "--------------------------------------";
            string contador = "12345678901234567890123456789012345678901234567890123456789012345678901234567890";
            string campoAssinatura = "______________________________";


            imp.Inicio(porta);


            imp.Imp(imp.Fonte56 + imp.NegritoOn + imp.Expandido + impressao.EmpresaNome + imp.Normal);
            imp.ImpCol(colunaTelefone, impressao.EmpresaTelefone);

            imp.ImpCol(segundaVia, imp.Fonte56 + imp.NegritoOn + imp.Expandido + impressao.EmpresaNome + imp.Normal);
            imp.ImpColLF(segundaVia + colunaTelefone, impressao.EmpresaTelefone);

            imp.Pula(1);

            imp.Imp(impressao.EmpresaEndereco);
            imp.ImpColLF(segundaVia, impressao.EmpresaEndereco);

            imp.Imp(impressao.EmpresaCidade);
            imp.ImpColLF(segundaVia, impressao.EmpresaCidade);

            imp.Imp(separador);
            imp.ImpColLF(segundaVia, separador);

            imp.ImpCol(3, "Hora:" + impressao.Hora);
            imp.ImpCol(18, "Numero:" + impressao.NumeroPedido);

            imp.ImpCol(segundaVia + 3, "Hora:" + impressao.Hora);
            imp.ImpColLF(segundaVia + 18, "Numero:" + impressao.NumeroPedido);

            imp.Imp(separador);
            imp.ImpColLF(segundaVia, separador);

            imp.ImpCol(1, "Cliente  : " + impressao.ClienteNome);
            imp.ImpColLF(segundaVia + 1, "Cliente  : " + impressao.ClienteNome);

            imp.ImpCol(1, "Bairro   : " + impressao.ClienteBairro);
            imp.ImpColLF(segundaVia + 1, "Bairro   : " + impressao.ClienteBairro);

            imp.ImpCol(1, "Endereco : " + impressao.ClienteEndereco);
            imp.ImpColLF(segundaVia + 1, "Endereco : " + impressao.ClienteEndereco);

            imp.ImpCol(1, "Complem. : " + impressao.ClienteComplemento);
            imp.ImpColLF(segundaVia + 1, "Complem. : " + impressao.ClienteComplemento);

            imp.ImpCol(1, "Cidade   : " + impressao.ClienteCidade);
            imp.ImpColLF(segundaVia + 1, "Cidade   : " + impressao.ClienteCidade);

            imp.ImpCol(1, "Telefone : " + impressao.ClienteTelefone);
            imp.ImpColLF(segundaVia + 1, "Telefone : " + impressao.ClienteTelefone);

            imp.ImpCol(1, "Cond. PG.: " + impressao.ClienteCondicaoPagamento);
            imp.ImpCol(segundaVia + 1, "Cond. PG.: " + impressao.ClienteCondicaoPagamento);

            imp.ImpCol(20, "Vcto.: " + impressao.ClienteVencimento);
            imp.ImpColLF(segundaVia + 20, "Vcto.: " + impressao.ClienteVencimento);

            imp.Imp(separador);
            imp.ImpColLF(segundaVia, separador);

            imp.Imp("QTDE  DESCRICAO         VALOR   TOTAL");
            imp.ImpColLF(segundaVia, "QTDE  DESCRICAO         VALOR   TOTAL");

            foreach (var item in impressao.Mercadorias)
            {
                imp.ImpCol(1, item.Quantidade.ToString());
                imp.ImpCol(7, item.Descricao);
                imp.ImpCol(24, item.PrecoVenda.ToString());
                imp.ImpCol(32, (item.Quantidade * item.PrecoVenda).ToString());

                imp.ImpCol(segundaVia + 1, item.Quantidade.ToString());
                imp.ImpCol(segundaVia + 7, item.Descricao);
                imp.ImpCol(segundaVia + 24, item.PrecoVenda.ToString());
                imp.ImpColLF(segundaVia + 32, (item.Quantidade * item.PrecoVenda).ToString());
                
            }

            imp.Imp(separador);
            imp.ImpColLF(segundaVia, separador);

            imp.ImpCol(8, "Total do Pedido:");
            imp.ImpCol(25, imp.NegritoOn + impressao.TotalPedido);

            imp.ImpCol(segundaVia + 8, "Total do Pedido:");
            imp.ImpColLF(segundaVia + 25, imp.NegritoOn + impressao.TotalPedido);



            imp.ImpCol(2, impressao.Data);
            imp.ImpColLF(segundaVia + 2, impressao.Data);

            imp.Pula(2);

            imp.ImpCol(5, campoAssinatura);
            imp.ImpColLF(segundaVia + 5, campoAssinatura);

            imp.ImpCol(17, "Assinatura");
            imp.ImpColLF(segundaVia + 17, "Assinatura");



            imp.Fim();
        }

        public void Imprimir2(ModelImpressao impressao, string porta)
        {

            ImprimeTexto imp = new ImprimeTexto();

            int colunaTelefone = impressao.EmpresaNome.Length + 14;

            string separador = "- - - - - - - - - - - - - - - - - ";
            string contador = "12345678901234567890123456789012345678901234567890123456789012345678901234567890";
            string campoAssinatura = "______________________________";


            imp.Inicio(porta);


            imp.Imp(imp.Fonte56 + imp.NegritoOn + imp.Expandido + impressao.EmpresaNome + imp.Normal);
            imp.ImpColLF(colunaTelefone, impressao.EmpresaTelefone);
            imp.ImpLF(impressao.EmpresaEndereco);
            imp.ImpLF("Vendedor:"); //Talvez não precise
            imp.ImpLF(impressao.EmpresaCidade);
            imp.ImpLF(separador);
            imp.ImpCol(3, "Hora:" + impressao.Hora);
            imp.ImpColLF(15, "Numero:" + impressao.NumeroPedido);
            imp.ImpLF(separador);

            imp.ImpColLF(1, "Cliente  : " + impressao.ClienteNome);
            imp.ImpColLF(1, "Bairro   : " + impressao.ClienteBairro);
            imp.ImpColLF(1, "Endereco : " + impressao.ClienteEndereco);
            imp.ImpColLF(1, "Complem. : " + impressao.ClienteComplemento);
            imp.ImpColLF(1, "Cidade   : " + impressao.ClienteCidade);
            imp.ImpColLF(1, "Telefone : " + impressao.ClienteTelefone);
            imp.ImpCol(1, "Cond. PG.: " + impressao.ClienteCondicaoPagamento);
            imp.ImpColLF(20, "Vcto.: " + impressao.ClienteVencimento);

            imp.ImpLF(separador);
            imp.ImpLF("QTDE  DESCRICAO          VALOR   TOTAL");
            imp.ImpLF(separador);
            imp.ImpLF(contador);
            imp.ImpCol(8, "Total do Pedido:");
            imp.ImpColLF(25, imp.NegritoOn + impressao.TotalPedido);

            imp.ImpColLF(2, impressao.Data);
            imp.ImpColLF(5, campoAssinatura);
            imp.Pula(2);
            imp.ImpColLF(17, "Assinatura");



            imp.Fim();
        }


        public void Impressao()
        {
            //https://download.dymo.com/UserManuals/labelwriter%20user%20guides/LWSE450_Tech_Ref/Content/Commands/ESC_U_Set_Font_to_10_cpi.htm

            ImprimeTexto imp = new ImprimeTexto();

            imp.Inicio("LPT2");

            imp.ImpLF("Teste de impressão");
            imp.ImpLF("Tentando imprimir");
            imp.ImpLF("-------------------------------------");
            imp.ImpLF("Componente de impressao em modo texto");
            for (int i = 0; i < 5; i++)
            {
                imp.ImpLF("Linha impressa " + i.ToString());
            }
            imp.ImpLF(imp.NegritoOn + "Negrito ligado" + imp.NegritoOff);
            imp.ImpLF(imp.Expandido + "Expandido" + imp.Normal);
            imp.ImpLF(imp.Comprimido + "Comprimido" + imp.Normal);
            imp.Pula(2);
            imp.ImpCol(10, "Coluna 10");
            imp.ImpCol(40, "Coluna 40");
            imp.Pula(2);
            imp.Imp((char)27 + "0");
            imp.ImpLF("8 linha ppp");
            imp.ImpLF("8 linha ppp");
            imp.ImpLF("8 linha ppp");
            imp.Imp((char)27 + "2");
            imp.ImpLF("6 linha ppp");
            imp.ImpLF("6 linha ppp");
            imp.ImpLF("6 linha ppp");
            imp.Pula(2);
            imp.Fim();
        }
    }
}

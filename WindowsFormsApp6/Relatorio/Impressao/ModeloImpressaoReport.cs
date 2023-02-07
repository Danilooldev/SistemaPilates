using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.Modelos.Movimentacao;

namespace WindowsFormsApp6.Relatorio.Impressao
{
    public class ModeloImpressaoReport
    {
        public string EmpresaNome { get; set; }
        public string EmpresaTelefone { get; set; }
        public string EmpresaEndereco { get; set; }
        public string EmpresaCidade { get; set; }

        public string Hora { get; set; }
        public string NumeroPedido { get; set; }

        public string ClienteNome { get; set; }
        public string ClienteBairro { get; set; }
        public string ClienteTelefone { get; set; }
        public string ClienteEndereco { get; set; }
        public string ClienteComplemento { get; set; }
        public string ClienteCidade { get; set; }
        public string ClienteCondicaoPagamento { get; set; }
        public string ClienteVencimento { get; set; }

        public IList<ModelItemImpressao> Lista { get; set; }

        public string TotalPedido { get; set; }

        public string Data => DataPorExtenso();

        private string DataPorExtenso()
        {
            DateTime a = DateTime.Now;


            CultureInfo culture = new CultureInfo("pt-BR");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;

            int dia = a.Day;
            int ano = a.Year;
            string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(DateTime.Now.Month));
            string diasemana = culture.TextInfo.ToTitleCase(dtfi.GetDayName(DateTime.Now.DayOfWeek));
            string dataDeHoje = "" + diasemana + ", " + dia + " de " + mes + " de " + ano;

            return dataDeHoje;
        }
    }

    
}

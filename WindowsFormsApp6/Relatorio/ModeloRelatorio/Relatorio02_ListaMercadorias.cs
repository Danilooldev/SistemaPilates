using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.Relatorio.ModeloRelatorio
{
    public class Relatorio02_ListaMercadorias
    {
        public string Id { get; set; }

        public string Nome { get; set; }

        public string Quantidade { get; set; }

        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; }

        public string ProxyPrecoCusto => PrecoCusto.ToString("C2");
        public string ProxyPrecoVenda => PrecoVenda.ToString("C2");

        public string Ativo { get; set; }
    }
}
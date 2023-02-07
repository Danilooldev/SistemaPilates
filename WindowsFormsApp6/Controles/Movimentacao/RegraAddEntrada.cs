using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.Controles.Movimentacao
{
    public class RegraAddEntrada
    {

        public string AlteracaoValoresUnidade(decimal qtd, int multiplo)
        {
            decimal total = qtd * multiplo;

            return $"Total {total.ToString("N2")} unidades";
        }

        public string AlteracaoValoresPreco(decimal valor, decimal qtd, decimal multiplo)
        {
            decimal total = valor * qtd * multiplo;

            return $"Total {total.ToString("C2")}";
        }

        
    }
}

using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.Enumeradores;
using WindowsFormsApp6.Interface;

namespace WindowsFormsApp6.Modelos.Movimentacao
{
    public class ModelMovimentacaoPeriodo
    {
        [DisplayName("Número")]
        public Int64 Id { get; set; }

        [DisplayName("Cliente")]
        public string Nome { get; set; }
        public DateTime Data { get; set; }

        [DisplayName("Total")]
        public decimal ValorLiquidoTotal { get; set; }
        



    }
}

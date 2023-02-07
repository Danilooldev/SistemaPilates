using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KS_System.Modelos
{
    public class ModelMercadoria
    {
        public int Id { get; set; }

        public string Descricao {get; set; }

        public decimal Venda {get; set; }
   
        public  int Quantidade { get; set; }

        public decimal Custo {get; set; } 


    }
}

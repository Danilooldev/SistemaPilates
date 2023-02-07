using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.Interface;
using WindowsFormsApp6.Modelos.Movimentacao;

namespace WindowsFormsApp6.Modelos
{
    public class ModelMercadoria : DapperDinamico, IModeloGenerico
    {
        public long Id { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [DisplayName("Venda")]
        public decimal PrecoVenda { get; set; }

        [DisplayName("Custo")]
        public decimal PrecoCusto { get; set; }

        [DisplayName("Qtd")]
        public decimal Quantidade { get; set; }

        public bool Ativo { get; set; }

        [Browsable(false)]
        public string Consulta => Descricao;

        [Browsable(false)]
        public DynamicParameters Save => Salvar(this);

    }
}
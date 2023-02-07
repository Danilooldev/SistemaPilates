using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.Enumeradores;

namespace WindowsFormsApp6.Modelos.Movimentacao
{
    public class ModelItemMovimentacao : DapperDinamico
    {
        public Int64 Id { get; set; }
        public Int64 IdDocumento { get; set; }
        public Int64 IdMercadoria { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [DisplayName("Qtd")]
        public decimal Quantidade { get; set; }

        [DisplayName("Preço Custo")]
        public decimal PrecoCusto { get; set; }

        [DisplayName("Preço Venda")]
        public decimal PrecoVenda { get; set; }

        [DisplayName("Total")]
        public decimal ValorTotal { get; set; }

        [Browsable(false)]
        public EOperacaoMovimento Operacao { get; set; }

        [Browsable(false)]
        public EStatusMovimento Status { get; set; }

        [Browsable(false)]
        public DynamicParameters Save => Salvar(this);
    }

    public class ModelItemImpressao : ModelItemMovimentacao
    {
        public string ProxyValorTotal => ValorTotal.ToString("C2");
    }
}
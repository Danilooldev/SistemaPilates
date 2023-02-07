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
    public class ModelMovimentacao : DapperDinamico, IModeloGenerico
    {
        public Int64 Id { get; set; }
        public string Descricao { get; set; }
        public Int64 IdParceiro { get; set; }
        public DateTime Data { get; set; }
        public EStatusMovimento Status { get; set; }
        public EOperacaoMovimento Operacao { get; set; }
        public decimal DescAcres { get; set; }
        public decimal ValorTotal { get; set; }

        public decimal Frete { get; set; }
        public decimal ValorLiquidoTotal { get; set; }
        public string NumeroNota { get; set; }




        [Browsable(false)]
        public string Consulta => Descricao;

        [Browsable(false)]
        public DynamicParameters Save => Salvar(this);
    }

    public class ModelMovimentacaoDapper : DynamicParameters
    {
        ////todo desafio --> deixar dinamico 
        //public ModelMovimentacaoDapper(ModelMovimentacao cli)
        //{
        //    base.Add("@Id", cli.Id);
        //    base.Add("@Descricao", cli.Descricao);
        //    base.Add("@Data", cli.Data);
        //    base.Add("@DescAcres", cli.DescAcres);
        //    base.Add("@IdParceiro", cli.IdParceiro);
        //    base.Add("@Status", cli.Status);
        //    base.Add("@Operacao", cli.Operacao);
        //    base.Add("@ValorTotal", cli.ValorTotal);
        //    base.Add("@Return", dbType: DbType.Int64, direction: ParameterDirection.ReturnValue);
        //}
    }
}

using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using WindowsFormsApp6.Relatorio.ModeloRelatorio;
using WindowsFormsApp6.Repositorios;

namespace Relatorios.Query.Entrada
{
    public class QueryRelatorio04VendaMercadoriaPeriodo : RepositorioBase
    {
        // Banco banco;

        SqlConnection Connection;

        public QueryRelatorio04VendaMercadoriaPeriodo() : base()
        {
            //   banco = new Banco();

            Connection = base.Connection;


        }

        public IList<Relatorio04_VendaMercadoriaPeriodo> QueryRelatorio(object[] parametros)
        {
            DateTime inicio = (DateTime)parametros[0];
            DateTime final = (DateTime)parametros[1];

            string ini = inicio.ToString("yyyy-MM-ddT00:00:00");
            string fim = final.ToString("yyyy-MM-ddT23:59:59");

            string query = $"select * from [Relatorio04_VendaMercadoriaPorPeriodo]('{ini}','{fim}')";

            IList<Relatorio04_VendaMercadoriaPeriodo> retorno = Connection.Query<Relatorio04_VendaMercadoriaPeriodo>(query).ToList();

            return retorno;

        }

        //public IList<ModeloRelatorio01ListaMercadorias> QueryRelatorio01ListaTodasMercadorias()
        //{

        //    //int status = 4;

        //    //banco.AbrirConexao();

        //    //string sql = String.Format(@"Select * from FN_CAD_Mercadoria({0}, 1)", status);

        //    //DataTable table = banco.ExecuteQuery(sql);

        //    //return table.AsEnumerable().Select(row =>
        //    //        new ModeloRelatorio01ListaMercadorias
        //    //        {
        //    //            //Codigo = row["CodigoBarra"].ToString(),
        //    //            //Situacao = Convert.ToString(row["Ativo"].ToString()),
        //    //            //Un = EnumPelaDescricao.ObterDescricao((EUnidade)Convert.ToInt64(row["Unidade"].ToString())),
        //    //            //Desc = row["Descricao"].ToString(),
        //    //            //Estoque = Convert.ToDecimal(row["QtdEstoque"].ToString()),
        //    //            //Unitario = Convert.ToDecimal(row["PrecoVenda"].ToString())
        //    //            //= (EUnidade)Convert.ToInt64(row["Unidade"].ToString())
        //    //        }).ToList();
        //    return null;
        //}

    }
}

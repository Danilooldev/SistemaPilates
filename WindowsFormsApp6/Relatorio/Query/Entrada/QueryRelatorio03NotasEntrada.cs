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
    public class QueryRelatorio03NotasEntrada : RepositorioBase
    {
        // Banco banco;

        SqlConnection Connection;

        public QueryRelatorio03NotasEntrada() : base()
        {
            //   banco = new Banco();

            Connection = base.Connection;


        }

        public IList<Relatorio03_NotaDeEntrada> QueryRelatorio(object[] parametros)
        {
            DateTime inicio = (DateTime)parametros[0];
            DateTime final = (DateTime)parametros[1];

            string ini = inicio.ToString("yyyy-MM-ddT00:00:00");
            string fim = final.ToString("yyyy-MM-ddT23:59:59");

            string query = $"SELECT * FROM Relatorio03_ListaNotasDeEntradaComItens('{ini}','{fim}')";

            IList<Relatorio03_NotaDeEntrada> retorno = Connection.Query<Relatorio03_NotaDeEntrada>(query).ToList();

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

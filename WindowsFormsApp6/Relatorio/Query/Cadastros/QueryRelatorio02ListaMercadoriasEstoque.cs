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
    public class QueryRelatorio02ListaMercadoriasEstoque : RepositorioBase
    {
        SqlConnection Connection;

        public QueryRelatorio02ListaMercadoriasEstoque() : base()
        {
            Connection = base.Connection;
        }

        public IList<Relatorio02_ListaMercadorias> QueryRelatorio(object[] parametros)
        {
            int ativo = (int)parametros[0];

            string query = $"SELECT * FROM [Relatorio02_EstoqueMercadorias]({ativo})";

            IList<Relatorio02_ListaMercadorias> retorno = Connection.Query<Relatorio02_ListaMercadorias>(query).ToList();

            return retorno;

        }
    }
}
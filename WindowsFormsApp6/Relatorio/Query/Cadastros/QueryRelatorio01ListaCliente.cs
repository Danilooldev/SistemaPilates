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
    public class QueryRelatorio01ListaCliente : RepositorioBase
    {
        SqlConnection Connection;

        public QueryRelatorio01ListaCliente() : base()
        {
            Connection = base.Connection;
        }

        public IList<Relatorio01_ListaCliente> QueryRelatorio(object[] parametros)
        {
            int ativo = (int)parametros[0];
            bool forn = (bool)parametros[1];
            bool cli = (bool)parametros[2];


            int fornCli = forn ? 1 : 0;
            fornCli = cli ? 0 : 1;

            if (forn && cli)
                fornCli = 4;

            string query = $"SELECT * FROM Relatorio01_ListaClientes({ativo},{fornCli})";

            IList<Relatorio01_ListaCliente> retorno = Connection.Query<Relatorio01_ListaCliente>(query).ToList();

            return retorno;

        }
    }
}
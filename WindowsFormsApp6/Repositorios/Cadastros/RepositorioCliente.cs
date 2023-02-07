using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.Modelos;
using WindowsFormsApp6.Modelos.Historico;

namespace WindowsFormsApp6.Repositorios.Cliente
{
    public class RepositorioCliente : RepositorioBase
    {
        SqlConnection Conexao;

        public RepositorioCliente() : base()
        {
            Conexao = base.Connection;
        }

        public void Salvar(ModelCliente cli)
        {
            try
            {
                var p = cli.Save;
                Conexao.Execute("SalvarCliente", p, commandType: CommandType.StoredProcedure);
                var b = p.Get<object>("@Return");
                b.ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<ModelCliente> Listar()
        {
            var consulta = Conexao.Query<ModelCliente>("SELECT * FROM ConsultarCliente()").ToList();

            return consulta;
        }

        public IList<ModelHistoricoCliente> ListaNotasHistoricas(Int64 id)
        {
            var consulta = Conexao.Query<ModelHistoricoCliente>($"SELECT * FROM ListarNotasPorCliente({id})").ToList();

            return consulta;
        }
        public IList<ModeloCidade> ListaCidades()
        {
            var consulta = Conexao.Query<ModeloCidade>($"SELECT * FROM Cidade").ToList();

            return consulta;
        }

        //public List<TTipo> Consulta<TTipo>(string consulta)
        //{
        //    try
        //    {
        //        return Conexao.Query<TTipo>(consulta).ToList();
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}
    }
}

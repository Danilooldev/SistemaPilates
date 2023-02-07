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
    public class RepositorioMercadoria : RepositorioBase
    {
        SqlConnection Conexao;

        public RepositorioMercadoria() : base()
        {
            Conexao = base.Connection;
        }

        public void Salvar(ModelMercadoria cli)
        {
            try
            {
                var p = cli.Save;
                Conexao.Execute("SalvarMercadoria", p, commandType: CommandType.StoredProcedure);
                var b = p.Get<object>("@Return");
                b.ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<ModelMercadoria> Listar()
        {
            var consulta = Conexao.Query<ModelMercadoria>("SELECT * FROM ConsultarMercadoria()").ToList();

            return consulta;
        }

        public IList<ModelMercadoria> ListarEntrada()
        {
            var consulta = Conexao.Query<ModelMercadoria>("SELECT * FROM ConsultarMercadoria()").ToList();

            return consulta;
        }

        public IList<ModelHistoricoMercadoria> ListaNotasHistoricas(Int64 id)
        {
            var consulta = Conexao.Query<ModelHistoricoMercadoria>($"SELECT * FROM ListarNotasPorMercadoria({id})").ToList();

            return consulta;
        }
    }
}
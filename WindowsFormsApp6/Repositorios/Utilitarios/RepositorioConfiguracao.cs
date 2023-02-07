using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.Modelos;

namespace WindowsFormsApp6.Repositorios.Utilitarios
{
    public class RepositorioConfiguracao : RepositorioBase
    {
        SqlConnection Conexao;

        public RepositorioConfiguracao() : base()
        {
            Conexao = base.Connection;
        }

        public void Salvar(ModelConfiguracao cli)
        {
            try
            {
                var p = cli.Save;
                Conexao.Execute("SalvarConfiguracoes", p, commandType: CommandType.StoredProcedure);
                var b = p.Get<object>("@Return");
                b.ToString();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public ModelConfiguracao Listar()
        {
            var consulta = Conexao.QuerySingle<ModelConfiguracao>("SELECT TOP 1 * FROM ConsultarConfiguracoes()");

            return consulta;
        }

    }
}

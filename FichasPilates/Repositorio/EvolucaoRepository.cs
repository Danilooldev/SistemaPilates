using Dapper;
using FichasPilates.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasPilates.Repositorio
{
    public class EvolucaoRepository : BaseRepository
    
    {
        public IList<ModelEvolucao> Listar(Int64 idUsuario)
        {
            return base.Connection.Query<ModelEvolucao>($"SELECT * FROM Evolucao where idusuario ={idUsuario}").ToList();

        }

        public void Salvar(ModelEvolucao modelo)
        {
            try
            {
                base.Connection.Execute("SalvarEvolucao", modelo, commandType: CommandType.StoredProcedure);
            }
            catch (SqlException ex)
            {
                ex.ToString();
            }
        }


    }
}
using Dapper;
using FichasPilates.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public Retorno DeletarEvolucaoDoUsuario(long idUsuario)
        {
            try
            {
                var parametro = new DynamicParameters();

                parametro.Add("@Id", idUsuario);

                base.Connection.Execute($"DELETE FROM Evolucao WHERE IdUsuario = @Id", parametro);

                return new Retorno
                {
                    Message = "Usuário deletado com sucesso",
                    Success = true

                };
            }
            catch (Exception ex)
            {
                return new Retorno
                {
                    Message = "Erro ao deletar usuário",
                    Success = false,
                    ErrorMessage = ex.ToString()
                };
            }
        }
    }
}
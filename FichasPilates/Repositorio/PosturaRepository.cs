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
    public class PosturaRepository : BaseRepository
    {
        public ModelPostural CarregarPosturaDoUsuario(Int64 id) 
        { 
            
             return base.Connection.Query<ModelPostural>($"SELECT * FROM Postura WHERE Id = {id}").FirstOrDefault();

        }
        public void Salvar (ModelPostural modelo)
        {
            try
            {
                base.Connection.Execute("SalvarPostura", modelo, commandType: CommandType.StoredProcedure);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar salvar\n\n"+ ex.ToString());
            }
        }

        public Retorno DeletarPosturaDoUsuario(long id)
        {
            try
            {
                var parametro = new DynamicParameters();

                parametro.Add("@Id", id);

                base.Connection.Execute($"DELETE FROM Postura WHERE Id = @Id", parametro);

                return new Retorno
                {
                    Message = "Usuário deletado com sucesso",
                    Success = true

                };
            }
            catch (SqlException ex)
            {
                return new Retorno
                {
                    Message = "Erro ao deletar usuário",
                    Success = false,
                    ErrorMessage = ex.Message
                };
            }
        }
    }
}

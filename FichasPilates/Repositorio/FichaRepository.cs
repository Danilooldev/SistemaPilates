using Dapper;
using FichasPilates.Controller;
using FichasPilates.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasPilates.Repositorio
{
    public class FichaRepository : BaseRepository
    {
        public IList<ModelNovaFicha> Listar()
        {
            return base.Connection.Query<ModelNovaFicha>("SELECT * FROM Usuario").ToList();
        }

        public void Salvar(ModelNovaFicha modelo)
        {
            try
            {
                var modeloBanco = new ModelNovaFichaDB(modelo);

                base.Connection.Execute("SalvarUsuario", modeloBanco, commandType: CommandType.StoredProcedure);
            }
            catch (SqlException ex)
            {
                ex.ToString();
            }
        }

        public ModelNovaFicha CarregarFichaPeloId(int id)
        {
            try
            {
                return base.Connection.Query<ModelNovaFicha>($"SELECT * FROM Usuario where id = {id}").Single();
                //did query not unique result: 3
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Retorno ExcluirUsuario(long id)
        {
            try
            {
                var parametro = new DynamicParameters();

                parametro.Add("@Id", id);

                base.Connection.Execute($"DELETE FROM Usuario WHERE Id = @Id", parametro);

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

    public class Retorno
    {
        public string Message { get; set; }

        public bool Success { get; set; }

        public string ErrorMessage { get; set; }

    }
}
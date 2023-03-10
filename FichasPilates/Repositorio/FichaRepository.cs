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
            return base.Connection.Query<ModelNovaFicha>($"SELECT * FROM Usuario where id = {id}").Single();
        }
    }
}
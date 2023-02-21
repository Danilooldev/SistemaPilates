using Dapper;
using FichasPilates.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasPilates.Repositorio
{
    public class EvolucaoRepository : BaseRepository
    {
        public IList<ModelEvolucao> Listar()
        {
            return base.Connection.Query<ModelEvolucao>("SELECT * FROM Evolucao").ToList();
        }

        
    }
}
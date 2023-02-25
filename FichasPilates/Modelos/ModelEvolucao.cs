using FichasPilates.Enumerador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasPilates.Modelos
{
    public class ModelEvolucao
    {
        // DTO
       public DateTime Data { get; set; }
       public int Id { get; set; }

        public EEquilibrio Equilibrio { get; set; }
        public ESolo Solo { get; set; }
        public EReformer Reformer { get; set; }
        public ECadilac Cadilac { get; set; }
        public EChair Chair { get; set; }

        public EBarrel Barrel { get; set; }
        public ESkate Skate { get; set; }
        public ESlack Slack { get; set; }
        public ESkier Skier { get; set; }
        public ELira Lira { get; set; }

        public EFixball Fixball { get; set; }

    }

    public class ModelEvolucaoBancoDeDados
    {
        // DAO
        // conversor
        public ModelEvolucaoBancoDeDados(ModelEvolucao m)
        {
            Equilibrio = (int)m.Equilibrio;

        }

        public DateTime Data { get; private set; }

        public int Equilibrio { get; private set; }
        public ESolo Solo { get; private set; }
        public EReformer Reformer { get; private set; }
        public ECadilac Cadilac { get; private set; }
        public EChair Chair { get; private set; }

        public EBarrel Barrel { get; private set; }
        public ESkate Skate { get; private set; }
        public ESlack Slack { get; private set; }
        public ESkier Skier { get; private set; }
        public ELira Lira { get; private set; }

        public EFixball Fixball { get; private set; }

    }
}

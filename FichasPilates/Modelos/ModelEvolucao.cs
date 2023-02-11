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

        public DateTime Data { get; set; }

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
}

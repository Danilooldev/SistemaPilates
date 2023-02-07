using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.Modelos
{
    public class ModelConfiguracaoBancoDados
    {
        public string NomeComputador { get; set; }

        public string Instancia { get; set; }

        public string Usuario { get; set; }

        public string Senha { get; set; }

        public string Banco { get; set; }

        public bool Local { get; set; }


        public string StringConexao => Local ? $"Data Source=({NomeComputador})\\{Instancia};Initial Catalog={Banco};Integrated Security=true;" :
                                               $"server={NomeComputador};database={Banco};user={Usuario};password={Senha}";

    }
}

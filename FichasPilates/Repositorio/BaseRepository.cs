using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasPilates.Repositorio
{
    public class BaseRepository
    {
        private string banco = ConfigurationManager.AppSettings["TipoBanco"];

        public DbConnection Connection { get; private set; }

        public BaseRepository()
        {
            switch (banco)
            {
                case "SqlServer":
                    Connection = new SqlConnection(ConfigurationManager.AppSettings["SqlServer"]);
                    break;

                case "MySql":
                    Connection = new MySqlConnection(ConfigurationManager.AppSettings["MySql"]);
                    break;

                case "Oracle":
                    Connection = new MySqlConnection(ConfigurationManager.AppSettings["Oracle"]);
                    break;

                case "SqlServer2":
                    Connection = new SqlConnection(ConfigurationManager.AppSettings["SqlServer2"]);
                    break;
            }
        }
    }
}
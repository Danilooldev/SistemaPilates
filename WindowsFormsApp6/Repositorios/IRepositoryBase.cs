using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.Repositorios
{
    public interface IRepositoryBase
    {
        SqlConnection Connection { get; }


    }
}

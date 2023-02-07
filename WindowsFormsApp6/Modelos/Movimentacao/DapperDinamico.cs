using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.Modelos.Movimentacao
{
    public abstract class DapperDinamico
    {
        public DynamicParameters Salvar(object x) => salvar(x);

        public DynamicParameters salvar(object obj)
        {
            DynamicParameters opa = new DynamicParameters();

            PropertyInfo[] props = obj.GetType().GetProperties();

            foreach (var item in props)
                if (!item.PropertyType.FullName.Contains("Dapper") && !item.Name.Equals("Consulta"))
                    opa.Add(item.Name, item.GetValue(obj));

            opa.Add("@Return", dbType: DbType.Int64, direction: ParameterDirection.ReturnValue);

            return opa;
        }
    }

    public static class DynamicDapper
    {
        public static DynamicParameters Salvar(this object obj)
        {
            DynamicParameters opa = new DynamicParameters();

            PropertyInfo[] props = obj.GetType().GetProperties();

            foreach (var item in props)
                if (!item.PropertyType.FullName.Contains("Dapper") && !item.Name.Equals("Consulta"))
                    opa.Add(item.Name, item.GetValue(obj));

            opa.Add("@Return", dbType: DbType.Int64, direction: ParameterDirection.ReturnValue);

            return opa;
        }
    }

}

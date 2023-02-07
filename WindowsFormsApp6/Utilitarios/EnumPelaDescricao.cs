using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.Utilitarios
{
    public static class EnumPelaDescricao
    {
        public static IEnumerable<String> GetDescriptions(Type type)
        {
            var descs = new List<string>();
            var names = System.Enum.GetNames(type);
            foreach (var name in names)
            {
                var field = type.GetField(name);
                var fds = field.GetCustomAttributes(typeof(DescriptionAttribute), true);
                foreach (DescriptionAttribute fd in fds)
                {
                    descs.Add(fd.Description.ToUpper());
                }
            }
            return descs;
        }

        /// <summary>
        /// Obtém a descrição de um determinado Enumerador.
        /// </summary>
        /// <param name="valor">Enumerador que terá a descrição obtida.</param>
        /// <returns>String com a descrição do Enumerador.</returns>
        public static string ObterDescricao(Enum valor)
        {
            FieldInfo fieldInfo = valor.GetType().GetField(valor.ToString());

            DescriptionAttribute[] atributos = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return atributos.Length > 0 ? atributos[0].Description ?? "Nulo" : valor.ToString();
        }

        /// <summary>
        /// Retorna uma lista com os valores de um determinado enumerador.
        /// </summary>
        /// <param name="tipo">Enumerador que terá os valores listados.</param>
        /// <returns>Lista com os valores do Enumerador.</returns>
        public static IList Listar(Type tipo)
        {
            ArrayList lista = new ArrayList();
            if (tipo != null)
            {
                Array enumValores = Enum.GetValues(tipo);
                foreach (Enum valor in enumValores)
                {
                    lista.Add(new KeyValuePair<Enum, string>(valor, ObterDescricao(valor)));
                }
            }

            return lista;
        }

    
        public static string Descricao(this System.Enum currentEnum)
        {
            string description;

            DescriptionAttribute da;
            FieldInfo fi = currentEnum.GetType().GetField(currentEnum.ToString());

            da = (DescriptionAttribute)Attribute.GetCustomAttribute
                (fi, typeof(DescriptionAttribute));

            if (da != null)
                description = da.Description;
            else
                description = currentEnum.ToString();

            return description;
        }

        public static String PegarCategoria(this Enum en)
        {
            //Verifica se o parâmetro é null
            FieldInfo elementEnum = (en != null) ? en.GetType().GetField(en.ToString()) : null;
            //Se o Length for 0, significa que o Enum não tem nenhum elemento
            if (elementEnum != null)
            {
                object[] customDescription = elementEnum.GetCustomAttributes(typeof(CategoryAttribute), false);
                return (customDescription.Length == 0) ? en.ToString() : ((CategoryAttribute)customDescription[0]).Category;
            }
            else
                return null;
        }


        //public static IEnumerable<string> GetDescriptions(Enum value)
        //{
        //    var descs = new List<string>();
        //    var type = value.GetType();
        //    var name = Enum.GetName(type, value);
        //    var field = type.GetField(name);
        //    var fds = field.GetCustomAttributes(typeof(DescriptionAttribute), true);
        //    foreach (DescriptionAttribute fd in fds)
        //    {
        //        descs.Add(fd.Description);
        //    }
        //    return descs;
        //}


    }
}

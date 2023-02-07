using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.Interface;
using WindowsFormsApp6.Modelos.Movimentacao;

namespace WindowsFormsApp6.Modelos
{
    public class ModelCliente : DapperDinamico, IModeloGenerico
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Telefone { get; set; }
        public long Cidade { get; set; }
        public string Obs { get; set; }
        public bool Fornecedor { get; set; }
        public bool Ativo { get; set; }

        [Browsable(false)]
        public string Consulta => Nome;

        [Browsable(false)]
        public DynamicParameters Save => Salvar(this);

    }

    public class ModelClienteDapper : DynamicParameters
    {
        public ModelClienteDapper(ModelCliente cli)
        {
            base.Add("@Id", cli.Id);
            base.Add("@Nome", cli.Nome);
            base.Add("@Cpf", cli.Cpf);
            base.Add("@Endereco", cli.Endereco);
            base.Add("@Numero", cli.Numero);
            base.Add("@Bairro", cli.Bairro);
            base.Add("@Complemento", cli.Complemento);
            base.Add("@Telefone", cli.Telefone);
            base.Add("@Cidade", cli.Cidade);
            base.Add("@Fornecedor", cli.Fornecedor);
            base.Add("@Obs", cli.Obs);
            base.Add("@Return", dbType: DbType.Int64, direction: ParameterDirection.ReturnValue);
        }
    }
}
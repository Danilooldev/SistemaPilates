using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.Utilitarios;

namespace WindowsFormsApp6.Relatorio.ModeloRelatorio
{
    public class Relatorio01_ListaCliente
    {
        public Int64 Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }
        public string Obs { get; set; }
        public string Tipo { get; set; }
        public bool Ativo { get; set; }

        public bool Fornecedor { get; set; }

        public string ProxyAtivo => Ativo ? "Sim" : "Não";

        public string ProxyFornecedor => Fornecedor ? "Sim" : "Não";

        public string ProxyTel => Telefone.TelefoneMascara();

        public string ProxyCpf => Cpf.CpfCnpjMascara();
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.Enumeradores;
using WindowsFormsApp6.Utilitarios;

namespace WindowsFormsApp6.Modelos.Historico
{
    public class ModelHistoricoCliente
    {
        public Int64 Id { get; set; }

        public String Nota { get; set; }

        public DateTime Data { get; set; }

        [Browsable(false)]
        public int Operacao { get; set; }

        [DisplayName("Operação")]
        public string EOperacao => EnumPelaDescricao.ObterDescricao((EOperacaoMovimento)Operacao);
    }
}

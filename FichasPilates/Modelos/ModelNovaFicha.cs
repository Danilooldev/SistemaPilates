using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichasPilates.Modelos
{
    public class ModelNovaFicha
    {
        public Int64 Id { get; set; }
        public string Nome { get; set; }
        public bool Sexo { get; set; }

        [DisplayName("Sexo"), ReadOnly(true)]
        public String SexoPorExtenso => Sexo ? "Masculino" : "Feminino";

        [DisplayName("Nascimento")]
        public DateTime DataNasc { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Profissao { get; set; }
        public string Patologia { get; set; }
        public string Cirurgias { get; set; }
        public string Exames { get; set; }

        [DisplayName("Queixa Principal")]
        public string QueixaPrincipal { get; set; }
        public string Anamnese { get; set; }
        public string Objetivo { get; set; }
    }

    public class ModelNovaFichaDB
    {

        public ModelNovaFichaDB(ModelNovaFicha ficha)
        {
            Id = ficha.Id;
            Nome = ficha.Nome;
            Sexo = ficha.Sexo;
            DataNasc = ficha.DataNasc;
            Endereco = ficha.Endereco;
            Telefone = ficha.Telefone;
            Celular = ficha.Celular;
            Profissao = ficha.Profissao;
            Patologia = ficha.Patologia;
            Cirurgias = ficha.Cirurgias;
            Exames = ficha.Exames;
            QueixaPrincipal = ficha.QueixaPrincipal;
            Anamnese = ficha.Anamnese;
            Objetivo = ficha.Objetivo;
        }

        public Int64 Id { get; private set; }
        public string Nome { get; private set; }
        public bool Sexo { get; private set; }

        public DateTime DataNasc { get; private set; }
        public string Endereco { get; private set; }
        public string Telefone { get; private set; }
        public string Celular { get; private set; }
        public string Profissao { get; private set; }
        public string Patologia { get; private set; }
        public string Cirurgias { get; private set; }
        public string Exames { get; private set; }

        public string QueixaPrincipal { get; private set; }
        public string Anamnese { get; private set; }
        public string Objetivo { get; private set; }
    }
}

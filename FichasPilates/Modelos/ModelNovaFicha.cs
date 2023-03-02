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

        [DisplayName("Sexo")]
        public String SexoPorExtenso => Sexo ? "Masculino" : "Feminino";

        [DisplayName("Nascimento")]
        public DateTime DataNasc { get; set; }
        public string Endereco  { get; set; }
        public string  Telefone { get; set; }
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
}
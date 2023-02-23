using FichasPilates.Janelas;
using FichasPilates.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasPilates.Controller
{
    public class CtrlFicha
    {
        public FarmFicha frm = new FarmFicha();
         

        public CtrlFicha()
        {
            DelegarEvento();

            frm.Show();
          


        }
        private void BtnPesquiar(object sender, EventArgs e)
        {
            CtrlPesquisaPaciente ctrlPesquisaPaciente = new CtrlPesquisaPaciente();

            ctrlPesquisaPaciente.frm.ShowDialog();

            var retorno = ctrlPesquisaPaciente.RetornaObjetoSelecionado();

            ObjetoParaTela(retorno);

            "".ToString();
        }

        private void DelegarEvento()
        {
            
            frm.btnAdicionar.Click += BtnAdicionar_Click;
            frm.btnPesquisar.Click += BtnPesquiar;
            
        }
        

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            CtrlEvolucao ctrl = new CtrlEvolucao();

        }


        private void ObjetoParaTela(ModelNovaFicha m)
        {
            if(m != null)
            {
                this.frm.txtPaciente.Text = m.Nome;
                this.frm.txtCel.Text = m.Celular.ToString();
                this.frm.rchObjetivo.Text = m.Objetivo;
                this.frm.txtSexo.Text = m.Sexo ? "Masculino" : "Feminino";
                this.frm.txtTel.Text = m.Telefone.ToString();
                this.frm.txtCirurgias.Text = m.Cirurgias;
                this.frm.txtExames.Text = m.Exames;
                this.frm.txtPatologia.Text = m.Patologia;
                this.frm.txtQueixaPrincipal.Text = m.QueixaPrincipal;
                this.frm.txtProfissao.Text = m.Profissao;
                this.frm.dteNasc.Value= m.DataNasc;
                


            }



        }


    }
}

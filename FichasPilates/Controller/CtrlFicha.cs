using FichasPilates.Janelas;
using FichasPilates.Modelos;
using FichasPilates.Repositorio;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichasPilates.Controller
{
    public class CtrlFicha
    {
        public FarmFicha frm = new FarmFicha();
        public EvolucaoRepository repositorievolucao = new EvolucaoRepository();
        

        public CtrlFicha()
        {
            DelegarEvento();

            frm.Show();
            RetornaParaTelaEvolucao();
            frm.dataGridView1.DataSource = repositorievolucao.Listar();






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
        public ModelEvolucao RetornaParaTelaEvolucao()
        {
            if (frm.DialogResult == DialogResult.OK &&
                frm.dataGridView1.Rows.Count > 0)
                return frm.dataGridView1.Rows[frm.dataGridView1.CurrentRow.Index].DataBoundItem as ModelEvolucao;

            return null;

            
        }



    }
}

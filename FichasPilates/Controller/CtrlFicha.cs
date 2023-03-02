using FichasPilates.Janelas;
using FichasPilates.Modelos;
using FichasPilates.Repositorio;
using FichasPilates.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichasPilates.Controller
{
    public class CtrlFicha
    {
        public FarmFicha frm = new FarmFicha();
        public EvolucaoRepository repositorievolucao = new EvolucaoRepository();

        private PosturaRepository repositoriopostura = new PosturaRepository();


        private IList<RadioButton> anteriorCabeca = new List<RadioButton>();
        private IList<RadioButton> anteriorOmbro = new List<RadioButton>();
        private IList<RadioButton> anteriorMamilos = new List<RadioButton>();
        private IList<RadioButton> anteriorPelve = new List<RadioButton>();
        private IList<RadioButton> anteriorJoelhos = new List<RadioButton>();
        private IList<RadioButton> anteriorPes = new List<RadioButton>();

        private IList<RadioButton> lateralCabeca = new List<RadioButton>();
        private IList<RadioButton> lateralOmbro = new List<RadioButton>();
        private IList<RadioButton> lateralColinaToracica = new List<RadioButton>();
        private IList<RadioButton> lateralPelve = new List<RadioButton>();
        private IList<RadioButton> lateralColunaLombar = new List<RadioButton>();




        private Int64 idUsuario = 0;




        public CtrlFicha()
        {
            DelegarEvento();


            frm.tabGeral.TabPages.Remove(frm.tabPostura);
            frm.tabGeral.TabPages.Remove(frm.tabEvolucao);

            frm.Show();



            CarregarRadios();


            //pegarDoBanco();


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
            frm.btnSalvar.Click += BtnSalvar_Click;

            frm.dataGridView1.DoubleClick += DataGridView1_DoubleClick;

        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var modelo = RetornaParaTelaEvolucao();

            if (modelo != null)
            {
                CtrlEvolucao ctrl = new CtrlEvolucao(modelo);

                if (ctrl.frm.DialogResult.Equals(DialogResult.OK))
                    ObjetoPAraAbaEvolucao(idUsuario);
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var pegarDados = TelaParaObjetoRadio();

            repositoriopostura.Salvar(pegarDados);

            MessageBox.Show("salvo");
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            CtrlEvolucao ctrl = new CtrlEvolucao(idUsuario);

            if (ctrl.frm.DialogResult.Equals(DialogResult.OK))
                ObjetoPAraAbaEvolucao(idUsuario);

        }


        private void ObjetoParaTela(ModelNovaFicha m)
        {
            if (m != null)
            {
                idUsuario = m.Id;

                ObjetoParaAbaFicha(m);

                ObjetoParaAbaPostura(m.Id);

                ObjetoPAraAbaEvolucao(m.Id);
            }
        }

        private void ObjetoParaAbaFicha(ModelNovaFicha m)
        {

            this.frm.txtPaciente.Text = m.Nome;
            this.frm.txtCel.Text = m.Celular?.ToString();
            this.frm.rchObjetivo.Text = m.Objetivo;
            this.frm.txtSexo.Text = m.Sexo ? "Masculino" : "Feminino";
            this.frm.txtTel.Text = m.Telefone?.ToString();
            this.frm.txtCirurgias.Text = m.Cirurgias;
            this.frm.txtExames.Text = m.Exames;
            this.frm.txtPatologia.Text = m.Patologia;
            this.frm.txtQueixaPrincipal.Text = m.QueixaPrincipal;
            this.frm.txtProfissao.Text = m.Profissao;
            this.frm.dteNasc.Value = m.DataNasc;

            if (!frm.tabGeral.TabPages.Contains(frm.tabPostura))
                frm.tabGeral.TabPages.Add(frm.tabPostura);

            if (!frm.tabGeral.TabPages.Contains(frm.tabEvolucao))
                frm.tabGeral.TabPages.Add(frm.tabEvolucao);


        }


        private void ObjetoParaAbaPostura(Int64 idUsuario)
        {
            var modeloPostura = repositoriopostura.CarregarPosturaDoUsuario(idUsuario);

            ObjetoParaTelaRadio(modeloPostura);
        }

        private void ObjetoPAraAbaEvolucao(Int64 idUsuario)
        {
            frm.dataGridView1.DataSource = repositorievolucao.Listar(idUsuario);

            TratamentoGridEvolucao();
        }

        #region Postura

        private void CarregarRadios()
        {
            // Anterior
            anteriorCabeca.Add(frm.rbtAnteriorCabecaSimetrica);
            anteriorCabeca.Add(frm.rbtAnteriorCabecaIncliDir);
            anteriorCabeca.Add(frm.rbtAnteriorCabecaIncliEsq);
            anteriorCabeca.Add(frm.rbtAnteriorCabecaRodaDir);
            anteriorCabeca.Add(frm.rbtAnteriorCabecaRodaEsq);

            anteriorOmbro.Add(frm.rbtAnteriorOmbroSimetrica);
            anteriorOmbro.Add(frm.rbtAnteriorOmbroDirAlta);
            anteriorOmbro.Add(frm.rbtAnteriorOmbroEsqAlta);

            anteriorMamilos.Add(frm.rbtAnteriorMamilosSimetrica);
            anteriorMamilos.Add(frm.rbtAnteriorMamilosDirAlta);
            anteriorMamilos.Add(frm.rbtAnteriorMamilosEsqAlta);

            anteriorPelve.Add(frm.rbtAnteriorPelveSimetrica);
            anteriorPelve.Add(frm.rbtAnteriorPelveDirAlta);
            anteriorPelve.Add(frm.rbtAnteriorPelveEsqAlta);

            anteriorJoelhos.Add(frm.rbtAnteriorJoelhosNormal);
            anteriorJoelhos.Add(frm.rbtAnteriorJoelhosMedial);
            anteriorJoelhos.Add(frm.rbtAnteriorJoelhosLateral);

            anteriorPes.Add(frm.rbtAnteriorPesPlano);
            anteriorPes.Add(frm.rbtAnteriorPesCavo);
            anteriorPes.Add(frm.rbtAnteriorPesNormal);

            //Lateral
            lateralCabeca.Add(frm.rbtLateralCabecaAlinhada);
            lateralCabeca.Add(frm.rbtLateralCabecaAnteriorizada);

            lateralOmbro.Add(frm.rbtLateralOmbroSimetrica);
            lateralOmbro.Add(frm.rbtLateralOmbroDireitaMaisAlta);
            lateralOmbro.Add(frm.rbtLateralOmbroEsquerdaMaisAlta);

            lateralColinaToracica.Add(frm.rbtLateralToracicaSimetrica);
            lateralColinaToracica.Add(frm.rbtLateralToracicaDireitaMaisAlta);
            lateralColinaToracica.Add(frm.rbtLateralToracicaEsquerdaMaisAlta);

            lateralPelve.Add(frm.rbtLateralPelveSimetrica);
            lateralPelve.Add(frm.rbtLateralPelveDireitaMaisAlta);
            lateralPelve.Add(frm.rbtLateralPelveEsquerdaMaisAlta);

            lateralColunaLombar.Add(frm.rbtLateralLombarNormal);
            lateralColunaLombar.Add(frm.rbtLateralLombarMedial);
            lateralColunaLombar.Add(frm.rbtLateralLombarLateral);





        }

        private void ObjetoParaTelaRadio(ModelPostural modelopos)
        {
            if (modelopos != null)
            {
                anteriorCabeca.SelecionarRadio(modelopos.AnteriorCabeca);
                anteriorOmbro.SelecionarRadio(modelopos.AnteriorOmbro);
                anteriorMamilos.SelecionarRadio(modelopos.AnteriorMamilos);
                anteriorPelve.SelecionarRadio(modelopos.AnteriorPelve);
                anteriorJoelhos.SelecionarRadio(modelopos.AnteriorJoelhos);
                anteriorPes.SelecionarRadio(modelopos.AnteriorPes);

                lateralCabeca.SelecionarRadio(modelopos.LateralCabeca);
                lateralOmbro.SelecionarRadio(modelopos.LateralOmbro);
                lateralColinaToracica.SelecionarRadio(modelopos.LateralColunaToracica);
                lateralPelve.SelecionarRadio(modelopos.LateralPelve);
                lateralColunaLombar.SelecionarRadio(modelopos.LateralColunaLombar);
            }
        }

        private ModelPostural TelaParaObjetoRadio()
        {
            ModelPostural modelo = new ModelPostural();

            modelo.Id = idUsuario;

            modelo.AnteriorCabeca = anteriorCabeca.RadioSelecionado();
            modelo.AnteriorOmbro = anteriorOmbro.RadioSelecionado();
            modelo.AnteriorMamilos = anteriorMamilos.RadioSelecionado();
            modelo.AnteriorPelve = anteriorPelve.RadioSelecionado();
            modelo.AnteriorJoelhos = anteriorJoelhos.RadioSelecionado();
            modelo.AnteriorPes = anteriorPes.RadioSelecionado();

            modelo.LateralCabeca = lateralCabeca.RadioSelecionado();
            modelo.LateralOmbro = lateralOmbro.RadioSelecionado();
            modelo.LateralColunaToracica = lateralColinaToracica.RadioSelecionado();
            modelo.LateralPelve = lateralPelve.RadioSelecionado();
            modelo.LateralColunaLombar = lateralColunaLombar.RadioSelecionado();

            return modelo;

        }


        #endregion


        #region Evolução

        private ModelEvolucao RetornaParaTelaEvolucao()
        {
            if (frm.dataGridView1.Rows.Count > 0)
                return frm.dataGridView1.Rows[frm.dataGridView1.CurrentRow.Index].DataBoundItem as ModelEvolucao;

            return null;

        }

        private void TratamentoGridEvolucao()
        {
            this.frm.dataGridView1.Columns[1].Visible = false;
            this.frm.dataGridView1.Columns[2].Visible = false;
        }

        #endregion
    }
}


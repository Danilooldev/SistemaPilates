using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Controles.Cadastros;
using WindowsFormsApp6.Enumeradores;
using WindowsFormsApp6.Interface.Movimentacao;
using WindowsFormsApp6.Menus.Movimentacao;
using WindowsFormsApp6.Modelos;
using WindowsFormsApp6.Modelos.Movimentacao;
using WindowsFormsApp6.Utilitarios;
using static WindowsFormsApp6.Utilitarios.Util;

namespace WindowsFormsApp6.Controles.Movimentacao
{
    public class CtrlSaidaMercadoria
    {
        private RegraMercadoria regraMercadoria = new RegraMercadoria();
        

        private ModelItemMovimentacao mercadoriaCarregada;

        public IAddVendaMercadoria SaidaMercadoriaView { get; set; }

        public CtrlSaidaMercadoria()
        {
            SaidaMercadoriaView = new FrmAddMercadoriaSaida();

            SaidaMercadoriaView.SaidaMercadoriaView.StartPosition = FormStartPosition.CenterScreen;

            DelegarEventos();

            MapeamentoInicial();

            SaidaMercadoriaView.SaidaMercadoriaView.ShowDialog();
        }

        private void DelegarEventos()
        {
            SaidaMercadoriaView.BtnAdd.Click += BtnAdd_Click;
            SaidaMercadoriaView.BtnCancelar.Click += BtnExc_Click;

            SaidaMercadoriaView.CbmMercadoria.DataSource = regraMercadoria.ListaMercadoriasEntrada();
            SaidaMercadoriaView.CbmMercadoria.DisplayMember = "Descricao";
            SaidaMercadoriaView.CbmMercadoria.ValueMember = "Id";

            SaidaMercadoriaView.CbmMercadoria.SelectedValueChanged += CbmDescricao_SelectedValueChanged;
            SaidaMercadoriaView.CbmMercadoria.DropDownStyle = ComboBoxStyle.DropDownList;


            SaidaMercadoriaView.TxtQtd.KeyPress += Validadores.CampoNumericoDecimal;


            SaidaMercadoriaView.TxtQtd.LostFocus += Txt_LostFocus;



        }

        private void Txt_LostFocus(object sender, EventArgs e)
        {
            AtualizacaoValores();

        }

        private void MapeamentoInicial()
        {
            this.mercadoriaCarregada = regraMercadoria.ListaMercadoriasEntrada().FirstOrDefault();

            SaidaMercadoriaView.TxtQtd.Text = "1";
            SaidaMercadoriaView.TxtPreco.Text = this.mercadoriaCarregada.PrecoVenda.ToString();

            AtualizacaoValores();
        }

        private void AtualizacaoValores()
        {

            decimal.TryParse(SaidaMercadoriaView.TxtQtd.Text.Replace(".", ","), out decimal valorQtd);
            decimal.TryParse(SaidaMercadoriaView.TxtPreco.Text.Replace(".", ","), out decimal valorUnit);

            decimal totalValor = valorUnit * valorQtd;

            SaidaMercadoriaView.LblTotal.Text = $"Total {totalValor.ToString("C2")}";

            mercadoriaCarregada.PrecoVenda = valorUnit;
            mercadoriaCarregada.Quantidade = valorQtd;
            mercadoriaCarregada.ValorTotal = totalValor;


        }
       
        private void CbmDescricao_SelectedValueChanged(object sender, EventArgs e)
        {
            this.mercadoriaCarregada = (sender as ComboBox).SelectedItem as ModelItemMovimentacao;

            if (this.mercadoriaCarregada != null)
                SaidaMercadoriaView.TxtPreco.Text = this.mercadoriaCarregada.PrecoVenda.ToString();
            else
                SaidaMercadoriaView.TxtPreco.Text = null;
                
            AtualizacaoValores();
        }

        private void BtnExc_Click(object sender, EventArgs e)
        {
            SaidaMercadoriaView.SaidaMercadoriaView.DialogResult = DialogResult.Cancel;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SaidaMercadoriaView.SaidaMercadoriaView.DialogResult = DialogResult.OK;
        }


        public ModelItemMovimentacao RetornaObjetoSelecionado()
        {
            AtualizacaoValores();

            if (SaidaMercadoriaView.SaidaMercadoriaView.DialogResult == DialogResult.OK)
                return this.mercadoriaCarregada;

            return null;
        }
    }
}

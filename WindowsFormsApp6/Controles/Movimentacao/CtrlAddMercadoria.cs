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
    public class CtrlAddMercadoria
    {
        private RegraMercadoria regraMercadoria = new RegraMercadoria();
        private RegraAddEntrada regraAddEntrada = new RegraAddEntrada();

        private ModelItemMovimentacao mercadoriaCarregada;

        public IAddEntradaMercadoria EntradaMercadoriaView { get; set; }

        public CtrlAddMercadoria()
        {
            EntradaMercadoriaView = new FrmAddMercadoria();

            EntradaMercadoriaView.AddMercadoriaView.StartPosition = FormStartPosition.CenterScreen;

            DelegarEventos();

            MapeamentoInicial();

            EntradaMercadoriaView.AddMercadoriaView.ShowDialog();
        }

        private void DelegarEventos()
        {
            EntradaMercadoriaView.BtnAdd.Click += BtnAdd_Click;
            EntradaMercadoriaView.BtnExc.Click += BtnExc_Click;

            EntradaMercadoriaView.CbmDescricao.DataSource = regraMercadoria.ListaMercadoriasEntrada();
            EntradaMercadoriaView.CbmDescricao.DisplayMember = "Descricao";
            EntradaMercadoriaView.CbmDescricao.ValueMember = "Id";

            EntradaMercadoriaView.CbmUnidade.DataSource = SetDataSource.Carregar(typeof(EUnidadeMedida));
            EntradaMercadoriaView.CbmUnidade.DisplayMember = SetDataSource.Mostrador;
            EntradaMercadoriaView.CbmUnidade.ValueMember = SetDataSource.Valor;

            EntradaMercadoriaView.CbmDescricao.SelectedValueChanged += CbmDescricao_SelectedValueChanged;
            EntradaMercadoriaView.CbmUnidade.SelectedValueChanged += CbmUnidade_SelectedValueChanged;

            EntradaMercadoriaView.CbmDescricao.DropDownStyle = ComboBoxStyle.DropDownList;
            EntradaMercadoriaView.CbmUnidade.DropDownStyle = ComboBoxStyle.DropDownList;

            EntradaMercadoriaView.TxtPrecoCusto.KeyPress += Validadores.CampoNumericoDecimal;
            EntradaMercadoriaView.TxtQuantidade.KeyPress += Validadores.CampoNumericoDecimal;
            EntradaMercadoriaView.TxtPrecoVenda.KeyPress += Validadores.CampoNumericoDecimal;

            EntradaMercadoriaView.TxtQuantidade.LostFocus += Txt_LostFocus;
            EntradaMercadoriaView.TxtPrecoCusto.LostFocus += Txt_LostFocus;
            EntradaMercadoriaView.TxtPrecoVenda.LostFocus += Txt_LostFocus;



        }

        private void Txt_LostFocus(object sender, EventArgs e)
        {
            int unidade = (int)(EUnidadeMedida)((KeyValuePair<Enum, string>)EntradaMercadoriaView.CbmUnidade.SelectedItem).Key;

            AtualizacaoValores(unidade);

        }

        private void MapeamentoInicial()
        {

            this.mercadoriaCarregada = regraMercadoria.ListaMercadoriasEntrada().FirstOrDefault();

            EntradaMercadoriaView.TxtPrecoVenda.Text = this.mercadoriaCarregada.PrecoVenda.ToString();
            EntradaMercadoriaView.TxtPrecoCusto.Text = this.mercadoriaCarregada.PrecoCusto.ToString();

            AtualizacaoValores(1);
        }
       
        private void AtualizacaoValores(int unidade)
        {
           
            decimal.TryParse(EntradaMercadoriaView.TxtQuantidade.Text.Replace(".", ","), out decimal valorQtd);
            decimal.TryParse(EntradaMercadoriaView.TxtPrecoVenda.Text.Replace(".", ","), out decimal valorUnit);
            decimal.TryParse(EntradaMercadoriaView.TxtPrecoCusto.Text.Replace(".", ","), out decimal valorCusto);

            decimal totalValor = valorCusto * valorQtd * unidade;

            decimal totalUnidade = valorQtd * unidade;

            EntradaMercadoriaView.LblTotal.Text = $"Total {totalValor.ToString("C2")}";

            EntradaMercadoriaView.LblUnidades.Text = $"Total {totalUnidade.ToString("N2")} unidades";

            mercadoriaCarregada.PrecoCusto = valorCusto;
            mercadoriaCarregada.PrecoVenda = valorUnit;
            mercadoriaCarregada.Quantidade = totalUnidade;
            mercadoriaCarregada.ValorTotal = totalValor;


        }

        private void CbmUnidade_SelectedValueChanged(object sender, EventArgs e)
        {
            int unidade = (int)(EUnidadeMedida)((KeyValuePair<Enum, string>)(sender as ComboBox).SelectedItem).Key;

            AtualizacaoValores(unidade);

        }

        private void CbmDescricao_SelectedValueChanged(object sender, EventArgs e)
        {
            this.mercadoriaCarregada = (sender as ComboBox).SelectedItem as ModelItemMovimentacao;

            int unidade = (int)(EUnidadeMedida)((KeyValuePair<Enum, string>)EntradaMercadoriaView.CbmUnidade.SelectedItem).Key;

            if (this.mercadoriaCarregada != null)
            {
                EntradaMercadoriaView.TxtPrecoCusto.Text = this.mercadoriaCarregada.PrecoCusto.ToString();
                EntradaMercadoriaView.TxtPrecoVenda.Text = this.mercadoriaCarregada.PrecoVenda.ToString();
            }
            else
            {
                EntradaMercadoriaView.TxtPrecoCusto.Text = null;
                EntradaMercadoriaView.TxtPrecoVenda.Text = null;
            }

            AtualizacaoValores(unidade);
        }

        private void BtnExc_Click(object sender, EventArgs e)
        {
            EntradaMercadoriaView.AddMercadoriaView.DialogResult = DialogResult.Cancel;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            EntradaMercadoriaView.AddMercadoriaView.DialogResult = DialogResult.OK;

            //RetornaObjetoSelecionado();
        }


        public ModelItemMovimentacao RetornaObjetoSelecionado()
        {
            int unidade = (int)(EUnidadeMedida)((KeyValuePair<Enum, string>)EntradaMercadoriaView.CbmUnidade.SelectedItem).Key;
            AtualizacaoValores(unidade);

            if (EntradaMercadoriaView.AddMercadoriaView.DialogResult == DialogResult.OK)
                return this.mercadoriaCarregada;

            return null;
        }
    }
}

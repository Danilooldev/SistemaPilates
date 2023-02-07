using KS_System.Interfaces;
using KS_System.Interfaces.Cadastros;
using KS_System.Modelos;
using KS_System.Visualizacoes.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KS_System.Controles.Cadastros
{
    public class CtrlMercadoria

    {
        IPrincipal Pai;
        public IMercadoria MercadoriaView{ get; set; }

        public CtrlMercadoria(IPrincipal Pai)
        {
            this.Pai = Pai;
            MercadoriaView = new FrmCadastroMercadoria();
           
            MercadoriaView.MercadoriaView.MdiParent = Pai.PrincipalView;

            MercadoriaView.MercadoriaView.StartPosition = FormStartPosition.CenterScreen;

            MercadoriaView.MercadoriaView.Show();

            DelegarEventos();



        }

        private void DelegarEventos()
        {
            MercadoriaView.BtnExcluir.Click += BtnExcluir_Click;
            MercadoriaView.BtnSalvar.Click += BtnSalvar_Click;
            MercadoriaView.BtnPesquisar.Click += BtnPesquisar_Click;
            MercadoriaView.BtnLimpar.Click += BtnLimpar_Click;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
           
            
        }

        private  ModelMercadoria TelaParaObjeto()
        {
            ModelMercadoria mercadoria = new ModelMercadoria();
            mercadoria.Descricao = MercadoriaView.TxtDescricao.Text;
            mercadoria.Id = Convert.ToInt32(MercadoriaView.TxtId.Text);
            mercadoria.Venda = Convert.ToDecimal(MercadoriaView.TxtVenda.Text);
            mercadoria.Quantidade =Convert.ToInt32(MercadoriaView.TxtQuantidade.Text);
            mercadoria.Custo = Convert.ToDecimal(MercadoriaView.TxtCusto.Text);

            return mercadoria;
        }

    }
}

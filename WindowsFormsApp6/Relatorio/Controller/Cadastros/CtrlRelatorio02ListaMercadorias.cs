using DevExpress.XtraReports.UI;
using Relatorios.Controller.Abstrato;
using Relatorios.Enumeradores;
using Relatorios.Query.Entrada;
using Relatorios.View.Cadastros.Mercadorias;
using System;
using System.Collections.Generic;
using WindowsFormsApp6.Relatorio.ModeloRelatorio;

namespace Relatorios.Controller.Cadastros
{
    public class CtrlRelatorio02ListaMercadorias : IDisposable
    {
        QueryRelatorio02ListaMercadoriasEstoque QueryRelatorio = new QueryRelatorio02ListaMercadoriasEstoque();

        Relatorio02EstoqueMercadorias Relatorio = new Relatorio02EstoqueMercadorias(ERelatorio.ListaMercadorias02);

        IList<Relatorio02_ListaMercadorias> Lista = null;

        public void Dispose()
        {
            if (Relatorio != null)
            {
                Relatorio.Dispose();
                Relatorio = null;
            }
        }
        public CtrlRelatorio02ListaMercadorias(object[] parametros)
        {
            Lista = QueryRelatorio.QueryRelatorio(parametros);

            if (VerificaRelatorioVazio.Verificar(Lista))
                return;


            this.Relatorio.DataSource = Lista;

            Inicializacao();

            Relatorio.ShowPreview();
        }

        private void Inicializacao()
        {

          //  Relatorio.LblPrecoVenda.DataBindings.Add(new XRBinding("Text", null, "PrecoVenda", "{0:C2}"));

          //  Relatorio.LblEstoque.DataBindings.Add(new XRBinding("Text", null, "QtdEstoque", "{0:N3}"));
        }
       

    }
}

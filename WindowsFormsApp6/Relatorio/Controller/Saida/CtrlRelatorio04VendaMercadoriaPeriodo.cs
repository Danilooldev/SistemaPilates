
using Relatorios.View.Cadastros.Mercadorias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraReports.UI;
using Relatorios.Enumeradores;
using Relatorios.Controller.Abstrato;
using WindowsFormsApp6.Relatorio.ModeloRelatorio;
using Relatorios.Query.Entrada;
using Relatorios.View.Cadastros.Entrada;

namespace Relatorios.Controller.Cadastros
{
    public class CtrlRelatorio04VendaMercadoriaPeriodo : IDisposable
    {
        QueryRelatorio04VendaMercadoriaPeriodo QueryRelatorio01 = new QueryRelatorio04VendaMercadoriaPeriodo();

        Relatorio04VendaDeMercadoriaPorPeriodo Relatorio = null;

        IList<Relatorio04_VendaMercadoriaPeriodo> lista = null;

        IList<AgrupadorRelatorio04> Lista = null;

        public void Dispose()
        {
            if (Relatorio != null)
            {
                Relatorio.Dispose();
                Relatorio = null;
            }
        }
        public CtrlRelatorio04VendaMercadoriaPeriodo(object[] parametros)
        {
            lista = QueryRelatorio01.QueryRelatorio(parametros);

            MontaRelatorio();

            if (VerificaRelatorioVazio.Verificar(Lista))
                return;

            string nomeFooter = "Valor Total das Vendas:";
            decimal valor = lista.Sum(x => x.Valor);

            string valorString = (valor).ToString("C2");

            this.Relatorio = new Relatorio04VendaDeMercadoriaPorPeriodo(ERelatorio.VendaDeMercadoriaPorPeriodo04, nomeFooter, valorString);

            this.Relatorio.DataSource = Lista;

            Inicializacao();

            Relatorio.ShowPreview();
        }

        private void MontaRelatorio()
        {
            this.Lista =

                lista
                .GroupBy(x => new { x.Data }).Select(agrupado => new AgrupadorRelatorio04()
                {
                    Data = agrupado.Key.Data.ToString("dd/MM/yyyy"),
                    Lista = lista.Where(x => x.Data == agrupado.Key.Data)
                          .ToList<Relatorio04_VendaMercadoriaPeriodo>(),
                }).ToList();

            foreach (var item in Lista)
            {
                item.Lista.LastOrDefault().ValorDia = item.Lista.Sum(x => x.Valor);
            }


            //this.Lista.FirstOrDefault().Lista.LastOrDefault().ValorDia = lista.Sum(x => x.Valor);

        }


        private void Inicializacao()
        {

            //Relatorio.LblPrecoVenda.DataBindings.Add(new XRBinding("Text", null, "PrecoVenda", "{0:C2}"));

            //Relatorio.LblEstoque.DataBindings.Add(new XRBinding("Text", null, "QtdEstoque", "{0:N3}"));
        }


    }
}

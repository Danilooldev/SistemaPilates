
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
    public class CtrlRelatorio03EntradaNotas : IDisposable
    {
        QueryRelatorio03NotasEntrada QueryRelatorio01 = new QueryRelatorio03NotasEntrada();

        Relatorio03NotasDeEntrada Relatorio = null;

        IList<Relatorio03_NotaDeEntrada> lista = null;

        IList<AgrupadorRelatorio03> Lista = null;

        public void Dispose()
        {
            if (Relatorio != null)
            {
                Relatorio.Dispose();
                Relatorio = null;
            }
        }
        public CtrlRelatorio03EntradaNotas(object[] parametros)
        {
            lista = QueryRelatorio01.QueryRelatorio(parametros);

            MontaRelatorio();

            if (VerificaRelatorioVazio.Verificar(Lista))
                return;


            string nomeFooter = "Valor Total das Notas:";

            string valor = lista.GroupBy(x => new { x.Id, x.ValorLiquidoTotal}).ToList().Sum(x => x.Key.ValorLiquidoTotal).ToString("C2");

            this.Relatorio = new Relatorio03NotasDeEntrada(ERelatorio.NotaEntadaPeriodo03, nomeFooter, valor);

            this.Relatorio.DataSource = Lista;

            Inicializacao();

            Relatorio.ShowPreview();
        }

        private void MontaRelatorio()
        {
            this.Lista =

                lista
                .GroupBy(x => new { x.Id, x.Fornecedor, x.DescricaoNota, x.Data, x.ValorLiquidoTotal, x.DescAcres, x.ValorTotal }).Select(agrupado => new AgrupadorRelatorio03()
                {
                    Id = agrupado.Key.Id,
                    DescricaoNota = agrupado.Key.DescricaoNota,
                    Fornecedor = agrupado.Key.Fornecedor,
                    ValorLiquidoTotal = agrupado.Key.ValorLiquidoTotal.ToString("C2"),
                    ValorTotal = agrupado.Key.ValorTotal,
                    DescAcres = agrupado.Key.DescAcres,
                    Data = agrupado.Key.Data.ToString("dd/MM/yyyy"),
                    Lista = lista.Where(x => x.Id == agrupado.Key.Id)
                         .ToList<Relatorio03_NotaDeEntrada>()

                }).ToList();


        }


        private void Inicializacao()
        {

            //Relatorio.LblPrecoVenda.DataBindings.Add(new XRBinding("Text", null, "PrecoVenda", "{0:C2}"));

            //Relatorio.LblEstoque.DataBindings.Add(new XRBinding("Text", null, "QtdEstoque", "{0:N3}"));
        }


    }
}

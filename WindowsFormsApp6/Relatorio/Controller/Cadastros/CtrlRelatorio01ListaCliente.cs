
using Relatorios.View.Cadastros.Mercadorias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraReports.UI;
using Relatorios.Enumeradores;
using Relatorios.Controller.Abstrato;
using Relatorios.Query.Entrada;
using WindowsFormsApp6.Relatorio.ModeloRelatorio;

namespace Relatorios.Controller.Cadastros
{
    public class CtrlRelatorio01ListaCliente : IDisposable
    {
        QueryRelatorio01ListaCliente QueryRelatorio01 = new QueryRelatorio01ListaCliente();

        Relatorio01ListaClientes Relatorio = new Relatorio01ListaClientes(ERelatorio.ListaClientes01);



        IList<Relatorio01_ListaCliente> Lista = null;

        public void Dispose()
        {
            if (Relatorio != null)
            {
                Relatorio.Dispose();
                Relatorio = null;
            }
        }
        public CtrlRelatorio01ListaCliente(object[] parametros)
        {
            Lista = QueryRelatorio01.QueryRelatorio(parametros);

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

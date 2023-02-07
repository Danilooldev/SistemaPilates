using DevExpress.XtraReports.UI;
using Relatorios.Impressao;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.Controles.Cadastros;
using WindowsFormsApp6.Modelos;
using WindowsFormsApp6.Modelos.Movimentacao;

namespace WindowsFormsApp6.Relatorio.Impressao
{
    public class CtrlImpressaoReport
    {
        ImpressaoSaida Relatorio = new ImpressaoSaida();

        IList<ModeloImpressaoReport> Lista = null;

        RegraCliente cli = new RegraCliente();

        public CtrlImpressaoReport(ModelCliente cliente, IList<ModelItemMovimentacao> mercadorias, Int64 idPedido, decimal totalPedido, string nomeImp)
        {
            Imprimir(cliente, mercadorias, idPedido.ToString(), totalPedido.ToString("C2"), nomeImp);

        }

        private void Imprimir(ModelCliente cliente, IList<ModelItemMovimentacao> mercadorias, string idPedido, string totalPedido, string nomeImp)
        {

            Lista = new List<ModeloImpressaoReport>();

            ModelEmpresa empresa = new ModelEmpresa
            {
                Nome = "BIG JET GAS",
                Bairro = "Centro",
                Cidade = "Assai-PR",
                Endereco = "Rua Brasil, 173 Ao lado da BIG BURGUER",
                Telefone = "(43) 3262-2436"
            };

            IList<ModelItemImpressao> listaModel = new List<ModelItemImpressao>();

            foreach (var item in mercadorias)
            {
                listaModel.Add(
                    new ModelItemImpressao
                    {
                        Descricao = item.Descricao,
                        Id = item.Id,
                        IdDocumento = item.IdDocumento,
                        IdMercadoria = item.IdMercadoria,
                        PrecoCusto = item.PrecoCusto,
                        PrecoVenda = item.PrecoVenda,
                        Quantidade = item.Quantidade,
                        Status = item.Status,
                        ValorTotal = item.ValorTotal
                    });
            }





            ModeloImpressaoReport modelo = new ModeloImpressaoReport
            {
                EmpresaCidade = empresa.Cidade,
                EmpresaEndereco = empresa.Endereco,
                EmpresaNome = empresa.Nome,
                EmpresaTelefone = empresa.Telefone,
                ClienteBairro = cliente.Bairro,
                ClienteCidade = Cidade(cliente.Cidade).Nome,
                ClienteComplemento = cliente.Complemento,
                ClienteCondicaoPagamento = "A Vista",
                ClienteTelefone = cliente.Telefone,
                ClienteEndereco = cliente.Endereco,
                ClienteNome = cliente.Nome,
                ClienteVencimento = "30 dias",
                Hora = DateTime.Now.ToString("HH:mm"),
                Lista = listaModel,
                NumeroPedido = idPedido,
                TotalPedido = totalPedido
            };

            Lista.Add(modelo);


            this.Relatorio.DataSource = Lista;

            this.Relatorio.ShowPrintMarginsWarning = false;
            this.Relatorio.PrinterName = nomeImp;

           // Relatorio.ShowPreview();

            this.Relatorio.Print();
            
        }

        private IList<string> ListaImpressoras()
        {
            IList<string> impressoras = new List<string>();

            String pkInstalledPrinters;
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                impressoras.Add(pkInstalledPrinters);
            }

            return impressoras;
        }


        private ModeloCidade Cidade(Int64 id)
        {
            return cli.ListarCidades().Where(x => x.Id == id).FirstOrDefault();
        }


    }
}

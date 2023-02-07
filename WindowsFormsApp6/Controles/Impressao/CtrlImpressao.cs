using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.Controles.Cadastros;
using WindowsFormsApp6.Modelos;
using WindowsFormsApp6.Modelos.Movimentacao;

namespace WindowsFormsApp6.Controles.Impressao
{
    public class CtrlImpressao
    {
        ModelCliente cliente;
        IList<ModelItemMovimentacao> mercadorias;
        string idPedido;
        string totalPedido;
        string porta;


        RegraCliente cli = new RegraCliente();

        public CtrlImpressao(ModelCliente cliente, IList<ModelItemMovimentacao> mercadorias, Int64 idPedido, decimal totalPedido, string porta)
        {
            this.cliente = cliente;
            this.mercadorias = mercadorias;
            this.idPedido = idPedido.ToString();
            this.totalPedido = totalPedido.ToString("C2");
            this.porta = porta;

            Imprimir();

        }

        private ModeloCidade Cidade(Int64 id)
        {
            return cli.ListarCidades().Where(x => x.Id == id).FirstOrDefault();
        }

        private void Imprimir()
        {
            ImpressaoLPT imprimir = new ImpressaoLPT();

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


            ModelImpressao impressao = new ModelImpressao()
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
                Mercadorias = listaModel,
                NumeroPedido = idPedido,
                TotalPedido = totalPedido
            };

            imprimir.Imprimir(impressao, porta);
        }
    }
}

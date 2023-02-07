using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Controles.Cadastros;
using WindowsFormsApp6.Interface.Utilitarios;
using WindowsFormsApp6.Menus.Utilitarios;
using WindowsFormsApp6.Modelos;
using WindowsFormsApp6.Repositorios.Cliente;

namespace WindowsFormsApp6.Controles.Utilitarios
{
    public class CtrlImportacao
    {
        public IImportador ImportadorView { get; set; }

        RepositorioCliente regra = new RepositorioCliente();

        public CtrlImportacao(IPrincipalView pai)
        {
            ImportadorView = new FrmImportador();

            ImportadorView.ImportadorView.MdiParent = pai.PrincipalView;

            ImportadorView.ImportadorView.StartPosition = FormStartPosition.CenterScreen;

            ImportadorView.ImportadorView.Show();

            DelegarEventos();
        }

        private void DelegarEventos()
        {
            this.ImportadorView.BtnImportar.Click += BtnImportar_Click;
        }

        private void BtnImportar_Click(object sender, EventArgs e)
        {

            string campo = this.ImportadorView.TxtCaminho.Text;

            if (string.IsNullOrEmpty(campo))
            {
                MessageBox.Show("Preencha o campo com o local onde está o excel");
                return;
            }

            Ler(campo);
        }

        public void Ler(string arquivo)
        {
            try
            {
                //@"C:\Temp\ExemploExcel.xlsx"

                var xls = new XLWorkbook(arquivo);
                var planilha = xls.Worksheets.First(w => w.Name == "Planilha1");
                var totalLinhas = planilha.Rows().Count();
                // primeira linha é o cabecalho

                IList<ModelCliente> listaClientes = new List<ModelCliente>();

                for (int l = 2; l <= totalLinhas; l++)
                {
                    var nome = planilha.Cell($"A{l}").Value.ToString();
                    var cpf = planilha.Cell($"B{l}").Value.ToString();
                    var endereco = planilha.Cell($"C{l}").Value.ToString();
                    var num = planilha.Cell($"D{l}").Value.ToString();
                    var bairro = planilha.Cell($"E{l}").Value.ToString();
                    var compl = planilha.Cell($"F{l}").Value.ToString();
                    var telefone = planilha.Cell($"G{l}").Value.ToString();
                    var cidade = int.Parse(planilha.Cell($"H{l}").Value.ToString());
                    var obs = planilha.Cell($"I{l}").Value.ToString();
                    var fornec = planilha.Cell($"J{l}").Value.ToString();



                    var cliente = new ModelCliente
                    {
                        Ativo = true,
                        Bairro = bairro,
                        Cidade = cidade,
                        Complemento = compl,
                        Cpf = cpf,
                        Endereco = endereco,
                        Id = 0,
                        Nome = nome,
                        Numero = num,
                        Fornecedor = fornec.Equals("Sim"),
                        Obs = obs,
                        Telefone = telefone
                    };

                    listaClientes.Add(cliente);

                }

                foreach (var item in listaClientes)
                    regra.Salvar(item);

                MessageBox.Show("Importaçao realizada com sucesso");

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao tentar importar\n\n" + e.Message);
            }

        }
    }
}
/*
var nome = int.Parse(planilha.Cell($"A{l}").Value.ToString());
var cpf = planilha.Cell($"B{l}").Value.ToString();
var endereco = decimal.Parse(planilha.Cell($"C{l}").Value.ToString());
var num = decimal.Parse(planilha.Cell($"D{l}").Value.ToString());
var bairro = decimal.Parse(planilha.Cell($"E{l}").Value.ToString());
var compl = decimal.Parse(planilha.Cell($"F{l}").Value.ToString());
var telefone = decimal.Parse(planilha.Cell($"G{l}").Value.ToString());
var cidade = decimal.Parse(planilha.Cell($"H{l}").Value.ToString());
var obs = decimal.Parse(planilha.Cell($"I{l}").Value.ToString());
var fornec = decimal.Parse(planilha.Cell($"J{l}").Value.ToString());
*/
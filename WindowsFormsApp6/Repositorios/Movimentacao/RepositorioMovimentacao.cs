using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.Enumeradores;
using WindowsFormsApp6.Modelos.Movimentacao;

namespace WindowsFormsApp6.Repositorios.Movimentacao
{
    public class RepositorioMovimentacao : RepositorioBase
    {
        SqlConnection Conexao;

        public RepositorioMovimentacao() : base()
        {
            Conexao = base.Connection;
        }


        public Int64 Salvar(ModelMovimentacao mov)
        {
            try
            {
                var p = mov.Save;
                Conexao.Execute("SalvarMovimentacao", p, commandType: CommandType.StoredProcedure);
                var b = p.Get<object>("@Return");
                return Convert.ToInt64(b.ToString());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void SalvarItens(IList<ModelItemMovimentacao> itens)
        {
            try
            {
                foreach (var item in itens)
                {
                    var p = item.Save;
                    Conexao.Execute("SalvarItemMovimentacao", p, commandType: CommandType.StoredProcedure);
                    //var b = p.Get<object>("@Return");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public IList<ModelMovimentacao> Listar(EOperacaoMovimento operacao, EStatusMovimento status)
        {
            var consulta = Conexao.Query<ModelMovimentacao>($"SELECT * FROM ConsultaNotas({(byte)operacao},{(byte)status})").ToList();

            return consulta;
        }

        public IList<ModelItemMovimentacao> ListaMercadoriasNotas(Int64 Id, EOperacaoMovimento operacao, EStatusMovimento status)
        {
            var consulta = Conexao.Query<ModelItemMovimentacao>($"SELECT * FROM ListaMercadoriasNotas({Id},{(byte)operacao},{(byte)status})").ToList();

            return consulta;
        }

        public void CancelarNotaDeSaida(Int64 id)
        {
            try
            {
                var p = new DynamicParameters();

                p.Add("@Id", id);
                Conexao.Execute("CancelarNotaDeSaida", p, commandType: CommandType.StoredProcedure);

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<ModelMovimentacaoPeriodo> ListarNotasPorPeriodo(EOperacaoMovimento operacao, EStatusMovimento status, string inicio, string fim)
        {
            var consulta = Conexao.Query<ModelMovimentacaoPeriodo>($"SELECT * FROM ConsultaNotasPorPeriodo({(byte)operacao},{(byte)status},'{inicio}','{fim}')").ToList();

            return consulta;
        }
    }
}
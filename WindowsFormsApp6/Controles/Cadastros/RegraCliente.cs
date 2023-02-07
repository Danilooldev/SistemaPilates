using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Modelos;
using WindowsFormsApp6.Modelos.Historico;
using WindowsFormsApp6.Repositorios.Cliente;

namespace WindowsFormsApp6.Controles.Cadastros
{
    public class RegraCliente
    {
        private RepositorioCliente repositorio = new RepositorioCliente();

        public bool Salvar(ModelCliente cliente)
        {
            try
            {
                repositorio.Salvar(cliente);

                string salvarExc = cliente.Ativo ? "Salvo" : "Excluido";

                MessageBox.Show($"{salvarExc} com sucesso");
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro na hora de salvar\n\n\n\n" + ex.Message.ToString());

                return false;
            }
        }

        public IList<ModelCliente> ListaClientes()
        {
            return repositorio.Listar().OrderBy(x=> x.Nome).ToList();
        }

        public IList<ModelHistoricoCliente> ListaNotasHistoricas(Int64 id)
        {
            return repositorio.ListaNotasHistoricas(id).OrderByDescending(x => x.Data).ThenByDescending(y => y.Nota).ToList();
        }

        public IList<ModeloCidade> ListarCidades()
        {
            return repositorio.ListaCidades().ToList();
        }
    }
}

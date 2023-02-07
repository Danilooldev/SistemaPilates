using System.Collections.Generic;
using System.Windows.Forms;

namespace Relatorios.Controller.Abstrato
{
    public static class VerificaRelatorioVazio
    {
        public static bool Verificar<T>(this IList<T> lista)
        {
            if (lista is null || lista.Count == 0)
            {
                //CtrlMensagem.Informacao("O relatório não possui dados", "Relatório");
                MessageBox.Show("O relatório não possui dados");
                return true;
            }

            return false;
        }
    }
}

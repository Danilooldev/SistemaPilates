using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6.Interface.Utilitarios
{
    public interface IConfiguracao
    {
        Form ConfiguracaoView { get; }

        TextBox TxtValorFrete { get; }

        TextBox TxtPortaImpressora { get; }

        Button BtnTesteImpressao { get; }

        Button BtnSalvar { get; }

        Button BtnCancelar { get; }

        CheckBox ChkMostrarExc { get; }

        DataGridView DgvImpressora { get; }

    }
}

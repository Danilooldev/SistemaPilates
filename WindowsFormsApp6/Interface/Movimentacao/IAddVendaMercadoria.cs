using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6.Interface.Movimentacao
{
    public interface IAddVendaMercadoria
    {
        Form SaidaMercadoriaView { get; }

        ComboBox CbmMercadoria { get; }

        TextBox TxtQtd { get; }

        TextBox TxtPreco { get; }

        Button BtnAdd { get; }

        Button BtnCancelar{ get; }

        Label LblTotal { get; }

    }
}

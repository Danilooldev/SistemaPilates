using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6.Interface.Movimentacao
{
    public interface IAddEntradaMercadoria
    {

        Form AddMercadoriaView { get; }

        TextBox TxtQuantidade { get; }

        TextBox TxtPrecoVenda { get; }

        TextBox TxtPrecoCusto { get; }

        ComboBox CbmUnidade { get; }

        ComboBox CbmDescricao { get; }

        Button BtnAdd { get; }

        Button BtnExc { get; }

        Label LblUnidades { get; }

        Label LblTotal { get; }

    }
}

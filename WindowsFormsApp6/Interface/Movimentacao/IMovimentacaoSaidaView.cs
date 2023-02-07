using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6.Interface.Movimentacao
{
    public interface IMovimentacaoSaidaView
    {
        Form SaidaView { get; }

        TextBox TxtCliente { get; }

        Label LblEndereco { get; }

        Label LblTelefone { get; }

        Label LblCidade { get; }

        TextBox TxtDescAcres { get; }

        TextBox TxtValorBruto { get; }

        DateTimePicker DteVenda { get; }

        Label LblValorLiquido { get; }

        Button BtnPesquisar { get; }

        Button BtnAdd { get; }

        Button BtnExc { get; }

        Button BtnFinalizar { get; }

        DataGridView DgvMercadorias { get; }

        CheckBox SemFrete { get; }

        CheckBox NaoImprimir { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6.Interface.Movimentacao
{
    public interface IMovimentacaoEntradaView
    {
        Form MovimentacaoEntradaView { get; }

        TextBox TxtId { get; }

        TextBox TxtDescricao { get; }

        TextBox TxtNumeroNota { get; }

        Button BtnPesquisar { get; }

        Button BtnLimpar { get; }

        Button BtnSalvar { get; }

        Button BtnEstornar { get; }

        Button BtnProcessar { get; }

        Button BtnAdd { get; }

        Button BtnRemove { get; }

        Label Status { get; }

        Label ValorTotal { get; }

        TextBox TxtDescAcres { get; }

        DateTimePicker DteData { get; }

        DataGridView DgvMercadorias { get; }

        ComboBox CbmFornecedor { get; }

        TextBox TxtValorTotal { get; }
    }
}

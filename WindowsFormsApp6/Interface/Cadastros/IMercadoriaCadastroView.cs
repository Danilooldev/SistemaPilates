using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6.Interface.Cadastros
{
    public interface IMercadoriaCadastroView
    {
        Form MercadoriaView { get; }

        TextBox TxtId { get; }

        TextBox TxtDescricao { get; }

        TextBox TxtPrecoVenda { get; }

        TextBox TxtPrecoCusto { get; }

        TextBox TxtQtd { get; }

        Button BtnPesquisar { get; }

        Button BtnLimpar { get; }

        Button BtnExcluir { get; }

        Button BtnSalvar { get; }

        DataGridView DgvHistorico { get; }

        Label LblAtivo { get; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6.Interface.Cadastros
{
    public interface IClienteCadastroView
    {
        Form ClienteView { get; }

        TextBox TxtId { get; }

        TextBox TxtNome { get; }

        TextBox TxtCPF { get; }

        TextBox TxtEnd { get; }

        TextBox TxtNumero { get; }

        TextBox TxtBairro { get; }

        TextBox TxtComp { get; }

        TextBox TxtTelefone { get; }

        ComboBox CbmCidade { get; }

        Button BtnSalvar { get; }

        Button BtnPesquisar { get; }

        Button BtnExcluir { get; }

        Button BtnCancelar { get; }

        DataGridView DgvHistorico { get; }

        RichTextBox RchObs { get; }

        CheckBox ChkFornecedor { get; }

        Label LblAtivo { get; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KS_System.Interfaces.Cadastros
{
    public interface IMercadoria
    {
        Form MercadoriaView { get; }

        TextBox TxtId { get; }

        TextBox TxtDescricao{ get; }

        TextBox TxtVenda { get; }

        TextBox TxtQuantidade { get; }

        TextBox TxtCusto { get; }

        Button BtnPesquisar { get; }

        Button BtnLimpar { get; }

        Button BtnSalvar { get; }

        Button BtnExcluir { get; }





    }
}

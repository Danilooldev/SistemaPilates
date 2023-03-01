using FichasPilates.Janelas;
using FichasPilates.Modelos;
using FichasPilates.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichasPilates.Controller
{
    public class CtrlGridEvolucao
    {
        //public FormPesquisaPaciente frm = new FormPesquisaPaciente();

        //private FichaRepository repositorio = new FichaRepository();

        //public CtrlPesquisaPaciente()
        //{
        //    DelegarEventos();

        //    frm.dgvListaPesquisa.DataSource = repositorio.Listar();

        //}
        //private void DelegarEventos()
        //{
        //    frm.dgvListaPesquisa.DoubleClick += GrdPesquisar_DoubleClick;
        //    frm.dgvListaPesquisa.KeyPress += GrdPesquisar_KeyPress;
        //    frm.dgvListaPesquisa.KeyDown += GrdPesquisar_KeyDown;

        //}

        //#region Eventos

        //void GrdPesquisar_DoubleClick(object sender, EventArgs e)
        //{
        //    frm.DialogResult = DialogResult.OK;

        //    RetornaObjetoSelecionado();

        //}

        //void GrdPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == 13)
        //    {
        //        frm.DialogResult = DialogResult.OK;
        //        RetornaObjetoSelecionado();

        //    }

        //    if (e.KeyChar == 27)
        //    {
        //        frm.DialogResult = DialogResult.Cancel;
        //    }

        //}

        //void GrdPesquisar_KeyDown(object sender, KeyEventArgs e)
        //{
        //    // 32 = space / 13 enter
        //    if (e.KeyValue.Equals(13))
        //    {
        //        e.SuppressKeyPress = true;
        //        frm.DialogResult = DialogResult.OK;

        //        RetornaObjetoSelecionado();
        //    }
        //    ///e.SuppressKeyPress = true;
        //}

        //#endregion

        //public ModelNovaFicha RetornaObjetoSelecionado()
        //{
        //    if (frm.DialogResult == DialogResult.OK &&
        //        frm.dgvListaPesquisa.Rows.Count > 0)
        //        return frm.dgvListaPesquisa.Rows[frm.dgvListaPesquisa.CurrentRow.Index].DataBoundItem as ModelNovaFicha;

        //    return null;
        }
    }
}

using FichasPilates.Janelas;
using FichasPilates.Modelos;
using FichasPilates.Repositorio;
using FichasPilates.Utilitarios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichasPilates.Controller
{
    public class CtrlPesquisaPaciente
    {
        public FormPesquisaPaciente frm = new FormPesquisaPaciente();

        private FichaRepository repositorio = new FichaRepository();

        private IList<ModelNovaFicha> listaCompleta;

        public CtrlPesquisaPaciente()
        {
            DelegarEventos();

            frm.dgvListaPesquisa.DataSource = listaCompleta = repositorio.Listar();

            frm.dgvListaPesquisa.Columns[2].Visible = false;



        }
        private void DelegarEventos()
        {
            frm.dgvListaPesquisa.DoubleClick += GrdPesquisar_DoubleClick;
            frm.dgvListaPesquisa.KeyPress += GrdPesquisar_KeyPress;
            frm.dgvListaPesquisa.KeyDown += GrdPesquisar_KeyDown;

            frm.txtNome.KeyPress += TxtNome_KeyPress;
            frm.txtNome.KeyDown += TxtNome_KeyDown;

        }

        private void TxtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
                frm.DialogResult = DialogResult.Cancel;

            var texto = sender.RetornaTextoParaBusca(e);


            if (e.KeyValue.Equals(13))
            {
                frm.DialogResult = DialogResult.OK;
                RetornaObjetoSelecionado();
            }

            frm.dgvListaPesquisa.DataSource = listaCompleta.ToList().Where(x => x.Nome.ToUpper().Contains(texto.ToUpper())).ToList();
        }

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            var texto = sender.RetornaTextoParaBusca(e);

            texto = texto.Replace("\r", "");

            if (e.KeyChar == 13)
            {
                frm.DialogResult = DialogResult.OK;
                RetornaObjetoSelecionado();
            }

            frm.dgvListaPesquisa.DataSource = listaCompleta.ToList().Where(x => x.Nome.ToUpper().Contains(texto.ToUpper())).ToList();

        }

        #region Eventos

        void GrdPesquisar_DoubleClick(object sender, EventArgs e)
        {
            frm.DialogResult = DialogResult.OK;

            RetornaObjetoSelecionado();

        }


        void GrdPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                frm.DialogResult = DialogResult.OK;
                RetornaObjetoSelecionado();

            }

            if (e.KeyChar == 27)
            {
                frm.DialogResult = DialogResult.Cancel;
            }

        }

        void GrdPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            // 32 = space / 13 enter
            if (e.KeyValue.Equals(13))
            {
                e.SuppressKeyPress = true;
                frm.DialogResult = DialogResult.OK;

                RetornaObjetoSelecionado();
            }
            ///e.SuppressKeyPress = true;
        }

        #endregion

        public ModelNovaFicha RetornaObjetoSelecionado()
        {
            if (frm.DialogResult == DialogResult.OK &&
                frm.dgvListaPesquisa.Rows.Count > 0)
                return frm.dgvListaPesquisa.Rows[frm.dgvListaPesquisa.CurrentRow.Index].DataBoundItem as ModelNovaFicha;

            return null;
        }




    }
}

using Relatorios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relatorios.Filtros
{
    public partial class FrmFiltro : Form, IFiltroRelatorio
    {
        public FrmFiltro()
        {
            InitializeComponent();
        }

        public Form FiltroView { get { return this; } }

        //public Button BtnOk { get { return this.btnOk; } }

        //public Button BtnCancelar { get { return this.btnCancelar; } }

        public FlowLayoutPanel Painel { get { return this.painel; } }

        public Label NomeRelatorio { get { return this.lblNome; } }

        public GroupBox Grupo { get { return this.grupo; } }
    }
}

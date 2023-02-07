using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Interface.Movimentacao;

namespace WindowsFormsApp6.Menus.Movimentacao
{
    public partial class FrmCancelamentoSaida : Form, ICancelamentoSaida
    {
        public FrmCancelamentoSaida() { InitializeComponent(); }

        public Form CancelamentoView => this;

        public Button BtnBuscar => btnBuscar;

        public Button BtnExecutar => btnExecutar;

        public DateTimePicker DteInicio => dteInicio;

        public DateTimePicker DteFim => dteFim;

        public DataGridView DgvLista => dgvLista;
    }
}

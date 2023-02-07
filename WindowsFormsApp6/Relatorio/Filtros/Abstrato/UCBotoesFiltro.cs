using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Relatorios.Interfaces;

namespace Relatorios.Filtros.Abstrato
{
    public partial class UCBotoesFiltro : UserControl, IBotoesRelatorio
    {
        public UCBotoesFiltro()
        {
            InitializeComponent();
        }

        public UserControl BotoesFiltroView { get { return this; } }

        public Button BtnOk { get { return this.btnOk; } }

        public Button BtnCancelar { get { return this.btnCancelar; } }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relatorios.Filtros.Venda
{
    public partial class UCFiltro004 : UserControl
    {
        public UCFiltro004()
        {
            InitializeComponent();
        }

        public UserControl UCFiltro { get { return this; } }

        public DateTimePicker DateInicio { get { return this.dteInicio; } }

        public DateTimePicker DateFim { get { return this.dteFim; } }

    }
}

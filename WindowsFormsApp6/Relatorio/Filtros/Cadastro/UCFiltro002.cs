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
    public partial class UCFiltro002 : UserControl
    {
        public UCFiltro002() { InitializeComponent(); }

        public UserControl UCFiltro { get { return this; } }

        public ComboBox Situacao { get { return this.cbmSituacao; } }

    }
}

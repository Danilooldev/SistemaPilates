using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relatorios.Filtros.Cadastro
{
    public partial class UCFiltro001 : UserControl
    {
        public UCFiltro001()
        {
            InitializeComponent();
        }

        public ComboBox Situacao { get { return this.cbmSituacao; } }

        public CheckBox Fornecedores { get { return this.chkForn; } }

        public CheckBox Clientes { get { return this.chkCli; } }
    }
}

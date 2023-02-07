using Relatorios.Controller.Cadastros;
using Relatorios.ControllerFiltros;
using Relatorios.Enumeradores;
using Relatorios.Filtros.Cadastro;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using static WindowsFormsApp6.Utilitarios.Util;

namespace Relatorios.CtrlFiltros.Cadastro
{
    public class BehaviorFiltro001 : ACtrlFiltroRelatorio
    {
        private UCFiltro001 filtroRelatorio = new UCFiltro001();

        public override void ConfiguraUserControl()
        {
            var carregar = SetDataSource.Carregar(typeof(EAtivo));

            this.filtroRelatorio.Situacao.DataSource = carregar;
            this.filtroRelatorio.Situacao.DisplayMember = SetDataSource.Mostrador;
            this.filtroRelatorio.Situacao.ValueMember = SetDataSource.Valor;

            this.filtroRelatorio.Situacao.SelectedIndex = 2;
        }

        public override object[] dadosFiltro =>
            new object[3]
            {
                this.filtroRelatorio.Situacao.SelectedValue,
                this.filtroRelatorio.Fornecedores.Checked,
                this.filtroRelatorio.Clientes.Checked,
            };

        public BehaviorFiltro001(ERelatorio relatorio) : base(relatorio) { }

        public override UserControl Controle => this.filtroRelatorio;

        public override object ControlRelatorio() => new CtrlRelatorio01ListaCliente(dadosFiltro);
    }



}

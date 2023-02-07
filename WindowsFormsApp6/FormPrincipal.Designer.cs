
namespace WindowsFormsApp6
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mercadoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelamentoSaidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.movimentaçãoToolStripMenuItem,
            this.utilitáriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.mercadoriasToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // mercadoriasToolStripMenuItem
            // 
            this.mercadoriasToolStripMenuItem.Name = "mercadoriasToolStripMenuItem";
            this.mercadoriasToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.mercadoriasToolStripMenuItem.Text = "Mercadorias";
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaToolStripMenuItem,
            this.saidaToolStripMenuItem,
            this.cancelamentoSaidaToolStripMenuItem});
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.movimentaçãoToolStripMenuItem.Text = "Movimentação";
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.entradaToolStripMenuItem.Text = "Entrada";
            // 
            // saidaToolStripMenuItem
            // 
            this.saidaToolStripMenuItem.Name = "saidaToolStripMenuItem";
            this.saidaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.saidaToolStripMenuItem.Text = "Saída";
            // 
            // cancelamentoSaidaToolStripMenuItem
            // 
            this.cancelamentoSaidaToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.cancelamentoSaidaToolStripMenuItem.Name = "cancelamentoSaidaToolStripMenuItem";
            this.cancelamentoSaidaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cancelamentoSaidaToolStripMenuItem.Text = "Cancelamento Saída";
            // 
            // utilitáriosToolStripMenuItem
            // 
            this.utilitáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracoesToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.importarToolStripMenuItem});
            this.utilitáriosToolStripMenuItem.Name = "utilitáriosToolStripMenuItem";
            this.utilitáriosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.utilitáriosToolStripMenuItem.Text = "Utilitários";
            // 
            // configuracoesToolStripMenuItem
            // 
            this.configuracoesToolStripMenuItem.Name = "configuracoesToolStripMenuItem";
            this.configuracoesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configuracoesToolStripMenuItem.Text = "Configurações";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.relatoriosToolStripMenuItem.Text = "Relatórios";
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importarToolStripMenuItem.Text = "Importar";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 504);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Big Jet Gás";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mercadoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelamentoSaidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
    }
}


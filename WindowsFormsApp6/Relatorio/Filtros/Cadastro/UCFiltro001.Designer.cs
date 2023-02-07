namespace Relatorios.Filtros.Cadastro
{
    partial class UCFiltro001
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbmSituacao = new System.Windows.Forms.ComboBox();
            this.chkForn = new System.Windows.Forms.CheckBox();
            this.chkCli = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Situação:";
            // 
            // cbmSituacao
            // 
            this.cbmSituacao.FormattingEnabled = true;
            this.cbmSituacao.Location = new System.Drawing.Point(72, 90);
            this.cbmSituacao.Name = "cbmSituacao";
            this.cbmSituacao.Size = new System.Drawing.Size(116, 21);
            this.cbmSituacao.TabIndex = 0;
            // 
            // chkForn
            // 
            this.chkForn.AutoSize = true;
            this.chkForn.Checked = true;
            this.chkForn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkForn.Location = new System.Drawing.Point(72, 59);
            this.chkForn.Name = "chkForn";
            this.chkForn.Size = new System.Drawing.Size(91, 17);
            this.chkForn.TabIndex = 2;
            this.chkForn.Text = "Fornecedores";
            this.chkForn.UseVisualStyleBackColor = true;
            // 
            // chkCli
            // 
            this.chkCli.AutoSize = true;
            this.chkCli.Checked = true;
            this.chkCli.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCli.Location = new System.Drawing.Point(72, 27);
            this.chkCli.Name = "chkCli";
            this.chkCli.Size = new System.Drawing.Size(63, 17);
            this.chkCli.TabIndex = 2;
            this.chkCli.Text = "Clientes";
            this.chkCli.UseVisualStyleBackColor = true;
            // 
            // UCFiltro001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkCli);
            this.Controls.Add(this.chkForn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbmSituacao);
            this.Name = "UCFiltro001";
            this.Size = new System.Drawing.Size(202, 132);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmSituacao;
        private System.Windows.Forms.CheckBox chkForn;
        private System.Windows.Forms.CheckBox chkCli;
    }
}

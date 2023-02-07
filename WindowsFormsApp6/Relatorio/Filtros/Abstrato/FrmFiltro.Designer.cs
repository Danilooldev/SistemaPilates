namespace Relatorios.Filtros
{
    partial class FrmFiltro
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
            this.lblNome = new System.Windows.Forms.Label();
            this.painel = new System.Windows.Forms.FlowLayoutPanel();
            this.grupo = new System.Windows.Forms.GroupBox();
            this.grupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(10, 14);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(176, 16);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "000 - Nome do Relatório";
            // 
            // painel
            // 
            this.painel.Location = new System.Drawing.Point(6, 19);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(188, 75);
            this.painel.TabIndex = 3;
            // 
            // grupo
            // 
            this.grupo.Controls.Add(this.painel);
            this.grupo.Location = new System.Drawing.Point(5, 37);
            this.grupo.Name = "grupo";
            this.grupo.Size = new System.Drawing.Size(200, 100);
            this.grupo.TabIndex = 4;
            this.grupo.TabStop = false;
            // 
            // FrmFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 140);
            this.ControlBox = false;
            this.Controls.Add(this.grupo);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFiltro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filtro";
            this.grupo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.FlowLayoutPanel painel;
        private System.Windows.Forms.GroupBox grupo;
    }
}
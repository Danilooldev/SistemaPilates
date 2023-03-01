namespace FichasPilates
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNovaFicha = new System.Windows.Forms.Button();
            this.btnBuscarFicha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNovaFicha
            // 
            this.btnNovaFicha.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnNovaFicha.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaFicha.Location = new System.Drawing.Point(151, 180);
            this.btnNovaFicha.Name = "btnNovaFicha";
            this.btnNovaFicha.Size = new System.Drawing.Size(204, 41);
            this.btnNovaFicha.TabIndex = 0;
            this.btnNovaFicha.Text = "Nova Ficha";
            this.btnNovaFicha.UseVisualStyleBackColor = false;
            this.btnNovaFicha.Click += new System.EventHandler(this.btnNovaFicha_Click);
            // 
            // btnBuscarFicha
            // 
            this.btnBuscarFicha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarFicha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscarFicha.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFicha.Location = new System.Drawing.Point(151, 115);
            this.btnBuscarFicha.Name = "btnBuscarFicha";
            this.btnBuscarFicha.Size = new System.Drawing.Size(204, 41);
            this.btnBuscarFicha.TabIndex = 1;
            this.btnBuscarFicha.Text = "Buscar Ficha";
            this.btnBuscarFicha.UseVisualStyleBackColor = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(510, 302);
            this.Controls.Add(this.btnBuscarFicha);
            this.Controls.Add(this.btnNovaFicha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudioPilates";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnNovaFicha;
        public System.Windows.Forms.Button btnBuscarFicha;
    }
}


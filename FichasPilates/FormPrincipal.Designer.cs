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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovaFicha
            // 
            this.btnNovaFicha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovaFicha.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnNovaFicha.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaFicha.Location = new System.Drawing.Point(125, 321);
            this.btnNovaFicha.Name = "btnNovaFicha";
            this.btnNovaFicha.Size = new System.Drawing.Size(358, 41);
            this.btnNovaFicha.TabIndex = 0;
            this.btnNovaFicha.Text = "Nova Ficha";
            this.btnNovaFicha.UseVisualStyleBackColor = false;
            this.btnNovaFicha.Click += new System.EventHandler(this.btnNovaFicha_Click);
            // 
            // btnBuscarFicha
            // 
            this.btnBuscarFicha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarFicha.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBuscarFicha.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFicha.Location = new System.Drawing.Point(125, 262);
            this.btnBuscarFicha.Name = "btnBuscarFicha";
            this.btnBuscarFicha.Size = new System.Drawing.Size(358, 41);
            this.btnBuscarFicha.TabIndex = 1;
            this.btnBuscarFicha.Text = "Buscar Ficha";
            this.btnBuscarFicha.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::FichasPilates.Properties.Resources.semfundo;
            this.pictureBox1.Location = new System.Drawing.Point(116, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(612, 400);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBuscarFicha);
            this.Controls.Add(this.btnNovaFicha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudioPilates";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnNovaFicha;
        public System.Windows.Forms.Button btnBuscarFicha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


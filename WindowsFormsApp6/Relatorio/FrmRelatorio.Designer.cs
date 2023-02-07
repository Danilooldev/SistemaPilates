namespace Relatorios
{
    partial class FrmRelatorio
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
            this.lstRelatorios = new System.Windows.Forms.ListBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstRelatorios
            // 
            this.lstRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRelatorios.FormattingEnabled = true;
            this.lstRelatorios.ItemHeight = 16;
            this.lstRelatorios.Location = new System.Drawing.Point(10, 12);
            this.lstRelatorios.Name = "lstRelatorios";
            this.lstRelatorios.Size = new System.Drawing.Size(434, 196);
            this.lstRelatorios.TabIndex = 1;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(182, 214);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(128, 23);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir Relatório";
            this.btnAbrir.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(316, 214);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(128, 23);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 258);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.lstRelatorios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRelatorio";
            this.Text = "Relatórios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstRelatorios;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnFechar;
    }
}


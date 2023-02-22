namespace FichasPilates.Janelas
{
    partial class FormPesquisaPaciente
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
            this.listPesquisa = new System.Windows.Forms.ListView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listPesquisa
            // 
            this.listPesquisa.HideSelection = false;
            this.listPesquisa.Location = new System.Drawing.Point(12, 68);
            this.listPesquisa.Name = "listPesquisa";
            this.listPesquisa.Size = new System.Drawing.Size(660, 402);
            this.listPesquisa.TabIndex = 0;
            this.listPesquisa.UseCompatibleStateImageBehavior = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(22, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(495, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(543, 29);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(114, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "PESQUISAR\r\n";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // PesquisaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 500);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.listPesquisa);
            this.Name = "PesquisaPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PesquisaPaciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listPesquisa;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnPesquisar;
    }
}
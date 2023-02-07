namespace Relatorios.Filtros.Venda
{
    partial class UCFiltro004
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
            this.dteInicio = new System.Windows.Forms.DateTimePicker();
            this.dteFim = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Inicio:";
            // 
            // dteInicio
            // 
            this.dteInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteInicio.Location = new System.Drawing.Point(50, 18);
            this.dteInicio.Name = "dteInicio";
            this.dteInicio.Size = new System.Drawing.Size(96, 20);
            this.dteInicio.TabIndex = 7;
            // 
            // dteFim
            // 
            this.dteFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteFim.Location = new System.Drawing.Point(50, 46);
            this.dteFim.Name = "dteFim";
            this.dteFim.Size = new System.Drawing.Size(96, 20);
            this.dteFim.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fim:";
            // 
            // UCFiltro003
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dteInicio);
            this.Controls.Add(this.dteFim);
            this.Controls.Add(this.label2);
            this.Name = "UCFiltro003";
            this.Size = new System.Drawing.Size(166, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dteInicio;
        private System.Windows.Forms.DateTimePicker dteFim;
        private System.Windows.Forms.Label label2;
    }
}

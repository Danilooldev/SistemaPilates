
namespace WindowsFormsApp6.Menus.Movimentacao
{
    partial class FrmAddMercadoria
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
            this.cbmDesc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExc = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblUnidades = new System.Windows.Forms.Label();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbmUnid = new System.Windows.Forms.ComboBox();
            this.txtVenda = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbmDesc
            // 
            this.cbmDesc.FormattingEnabled = true;
            this.cbmDesc.Location = new System.Drawing.Point(84, 18);
            this.cbmDesc.Name = "cbmDesc";
            this.cbmDesc.Size = new System.Drawing.Size(198, 21);
            this.cbmDesc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExc);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblUnidades);
            this.groupBox1.Controls.Add(this.cbmDesc);
            this.groupBox1.Controls.Add(this.txtCusto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbmUnid);
            this.groupBox1.Controls.Add(this.txtVenda);
            this.groupBox1.Controls.Add(this.txtQtd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(5, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 160);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada";
            // 
            // btnExc
            // 
            this.btnExc.Location = new System.Drawing.Point(199, 122);
            this.btnExc.Name = "btnExc";
            this.btnExc.Size = new System.Drawing.Size(83, 23);
            this.btnExc.TabIndex = 6;
            this.btnExc.Text = "Cancelar";
            this.btnExc.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(82, 122);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(176, 98);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(78, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total R$ 00,00";
            // 
            // lblUnidades
            // 
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.Location = new System.Drawing.Point(176, 77);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(86, 13);
            this.lblUnidades.TabIndex = 3;
            this.lblUnidades.Text = "Total 0 unidades";
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(84, 96);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(73, 20);
            this.txtCusto.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Preço Custo:";
            // 
            // cbmUnid
            // 
            this.cbmUnid.FormattingEnabled = true;
            this.cbmUnid.Location = new System.Drawing.Point(204, 45);
            this.cbmUnid.Name = "cbmUnid";
            this.cbmUnid.Size = new System.Drawing.Size(78, 21);
            this.cbmUnid.TabIndex = 2;
            // 
            // txtVenda
            // 
            this.txtVenda.Location = new System.Drawing.Point(84, 71);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(73, 20);
            this.txtVenda.TabIndex = 3;
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(84, 46);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(73, 20);
            this.txtQtd.TabIndex = 1;
            this.txtQtd.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preço Venda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Unid.:";
            // 
            // FrmAddMercadoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 165);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddMercadoria";
            this.Text = "Adição Mercadoria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUnidades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbmUnid;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.TextBox txtVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTotal;
    }
}
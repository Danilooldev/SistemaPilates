
namespace WindowsFormsApp6.Menus.Movimentacao
{
    partial class FrmSaidas
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMercadorias = new System.Windows.Forms.DataGridView();
            this.btnRem = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtDescAcre = new System.Windows.Forms.TextBox();
            this.lblValorLiquidoTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkNaoImprimir = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMercadorias)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(234, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // btnProcessar
            // 
            this.btnProcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessar.ForeColor = System.Drawing.Color.Green;
            this.btnProcessar.Location = new System.Drawing.Point(260, 373);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(74, 22);
            this.btnProcessar.TabIndex = 35;
            this.btnProcessar.Text = "Finalizar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMercadorias);
            this.groupBox1.Controls.Add(this.btnRem);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(5, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 177);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mercadorias";
            // 
            // dgvMercadorias
            // 
            this.dgvMercadorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMercadorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMercadorias.Location = new System.Drawing.Point(4, 15);
            this.dgvMercadorias.Name = "dgvMercadorias";
            this.dgvMercadorias.RowHeadersVisible = false;
            this.dgvMercadorias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvMercadorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMercadorias.Size = new System.Drawing.Size(284, 152);
            this.dgvMercadorias.TabIndex = 0;
            // 
            // btnRem
            // 
            this.btnRem.BackgroundImage = global::BigJetGas.Properties.Resources.botao_menos;
            this.btnRem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRem.Location = new System.Drawing.Point(291, 46);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(34, 30);
            this.btnRem.TabIndex = 2;
            this.btnRem.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::BigJetGas.Properties.Resources.botao_mais;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Location = new System.Drawing.Point(291, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(34, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(75, 134);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(89, 20);
            this.txtValorTotal.TabIndex = 38;
            this.txtValorTotal.Text = "0,00";
            // 
            // txtDescAcre
            // 
            this.txtDescAcre.Location = new System.Drawing.Point(75, 108);
            this.txtDescAcre.Name = "txtDescAcre";
            this.txtDescAcre.Size = new System.Drawing.Size(89, 20);
            this.txtDescAcre.TabIndex = 33;
            this.txtDescAcre.Text = "0,00";
            // 
            // lblValorLiquidoTotal
            // 
            this.lblValorLiquidoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorLiquidoTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblValorLiquidoTotal.Location = new System.Drawing.Point(152, 157);
            this.lblValorLiquidoTotal.Name = "lblValorLiquidoTotal";
            this.lblValorLiquidoTotal.Size = new System.Drawing.Size(182, 26);
            this.lblValorLiquidoTotal.TabIndex = 45;
            this.lblValorLiquidoTotal.Text = "R$ 0,00";
            this.lblValorLiquidoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(8, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Valor Merc.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Desc/Acrés.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(198, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(67, 9);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(226, 20);
            this.txtCliente.TabIndex = 49;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(67, 32);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(62, 13);
            this.lblEnd.TabIndex = 51;
            this.lblEnd.Text = "Endereço...";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(67, 51);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(49, 13);
            this.lblTel.TabIndex = 51;
            this.lblTel.Text = "Telefone";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(67, 71);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 51;
            this.lblCidade.Text = "Cidade";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblCidade);
            this.groupBox2.Controls.Add(this.txtCliente);
            this.groupBox2.Controls.Add(this.lblTel);
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Controls.Add(this.lblEnd);
            this.groupBox2.Location = new System.Drawing.Point(5, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 100);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::BigJetGas.Properties.Resources.lupa2;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Location = new System.Drawing.Point(299, 7);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(21, 23);
            this.btnPesquisar.TabIndex = 50;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(75, 162);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 54;
            this.checkBox1.Text = "Sem frete";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chkNaoImprimir
            // 
            this.chkNaoImprimir.AutoSize = true;
            this.chkNaoImprimir.Location = new System.Drawing.Point(157, 374);
            this.chkNaoImprimir.Name = "chkNaoImprimir";
            this.chkNaoImprimir.Size = new System.Drawing.Size(83, 17);
            this.chkNaoImprimir.TabIndex = 54;
            this.chkNaoImprimir.Text = "Não imprimir";
            this.chkNaoImprimir.UseVisualStyleBackColor = true;
            // 
            // FrmSaidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 400);
            this.Controls.Add(this.chkNaoImprimir);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtDescAcre);
            this.Controls.Add(this.lblValorLiquidoTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSaidas";
            this.Text = "Venda de Mercadorias";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMercadorias)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMercadorias;
        private System.Windows.Forms.Button btnRem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtDescAcre;
        private System.Windows.Forms.Label lblValorLiquidoTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkNaoImprimir;
    }
}

namespace WindowsFormsApp6.Movimentacao
{
    partial class FrmEntradas
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValorLiquidoTotal = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMercadorias = new System.Windows.Forms.DataGridView();
            this.btnRem = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEstornar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescAcre = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbmFornecedor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMercadorias)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(76, 12);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(89, 20);
            this.txtId.TabIndex = 0;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(76, 37);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(259, 20);
            this.txtDesc.TabIndex = 3;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(260, 11);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 22);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(176, 11);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(69, 22);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Descrição:";
            // 
            // lblValorLiquidoTotal
            // 
            this.lblValorLiquidoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorLiquidoTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblValorLiquidoTotal.Location = new System.Drawing.Point(5, 343);
            this.lblValorLiquidoTotal.Name = "lblValorLiquidoTotal";
            this.lblValorLiquidoTotal.Size = new System.Drawing.Size(319, 20);
            this.lblValorLiquidoTotal.TabIndex = 23;
            this.lblValorLiquidoTotal.Text = "R$ 0,00";
            this.lblValorLiquidoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(76, 90);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(89, 20);
            this.txtNum.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMercadorias);
            this.groupBox1.Controls.Add(this.btnRem);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(4, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 177);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mercadorias";
            // 
            // dgvMercadorias
            // 
            this.dgvMercadorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMercadorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMercadorias.Location = new System.Drawing.Point(4, 19);
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
            this.btnRem.Location = new System.Drawing.Point(292, 50);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(34, 30);
            this.btnRem.TabIndex = 2;
            this.btnRem.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::BigJetGas.Properties.Resources.botao_mais;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Location = new System.Drawing.Point(292, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(34, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnProcessar
            // 
            this.btnProcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessar.ForeColor = System.Drawing.Color.Green;
            this.btnProcessar.Location = new System.Drawing.Point(80, 372);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(74, 22);
            this.btnProcessar.TabIndex = 8;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Location = new System.Drawing.Point(170, 372);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(74, 22);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnEstornar
            // 
            this.btnEstornar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstornar.ForeColor = System.Drawing.Color.Red;
            this.btnEstornar.Location = new System.Drawing.Point(261, 372);
            this.btnEstornar.Name = "btnEstornar";
            this.btnEstornar.Size = new System.Drawing.Size(74, 22);
            this.btnEstornar.TabIndex = 10;
            this.btnEstornar.Text = "Estornar";
            this.btnEstornar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nº Nota:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(232, 144);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(92, 16);
            this.lblStatus.TabIndex = 23;
            this.lblStatus.Text = "Processada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Desc/Acrés.:";
            // 
            // txtDescAcre
            // 
            this.txtDescAcre.Location = new System.Drawing.Point(76, 116);
            this.txtDescAcre.Name = "txtDescAcre";
            this.txtDescAcre.Size = new System.Drawing.Size(89, 20);
            this.txtDescAcre.TabIndex = 6;
            this.txtDescAcre.Text = "0,00";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(235, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(199, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Data:";
            // 
            // cbmFornecedor
            // 
            this.cbmFornecedor.FormattingEnabled = true;
            this.cbmFornecedor.Location = new System.Drawing.Point(76, 63);
            this.cbmFornecedor.Name = "cbmFornecedor";
            this.cbmFornecedor.Size = new System.Drawing.Size(259, 21);
            this.cbmFornecedor.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Fornecedor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(168, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Valor Merc.:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(235, 116);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(100, 20);
            this.txtValorTotal.TabIndex = 11;
            this.txtValorTotal.Text = "0,00";
            // 
            // FrmEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 402);
            this.Controls.Add(this.cbmFornecedor);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnEstornar);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtDescAcre);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblValorLiquidoTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEntradas";
            this.Text = "Entrada de Mercadorias";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMercadorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValorLiquidoTotal;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEstornar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescAcre;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMercadorias;
        private System.Windows.Forms.ComboBox cbmFornecedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorTotal;
    }
}
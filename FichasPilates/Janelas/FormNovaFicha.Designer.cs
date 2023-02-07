namespace FichasPilates.Janelas
{
    partial class FormNovaFicha
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
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblProfissao = new System.Windows.Forms.Label();
            this.lblPatologia = new System.Windows.Forms.Label();
            this.lblCirurgias = new System.Windows.Forms.Label();
            this.lblExames = new System.Windows.Forms.Label();
            this.lblQueixaPrincipal = new System.Windows.Forms.Label();
            this.lblAnamnese = new System.Windows.Forms.Label();
            this.lblObjetivo = new System.Windows.Forms.Label();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.rbtFeminino = new System.Windows.Forms.RadioButton();
            this.dteNascimento = new System.Windows.Forms.DateTimePicker();
            this.rchObjetivo = new System.Windows.Forms.RichTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtProfissao = new System.Windows.Forms.TextBox();
            this.txtQueixaPrincipal = new System.Windows.Forms.TextBox();
            this.txtPatologia = new System.Windows.Forms.TextBox();
            this.txtExames = new System.Windows.Forms.TextBox();
            this.txtCirurgias = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.txtAnamnese = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(82, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(56, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome :";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(88, 79);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(50, 16);
            this.lblSexo.TabIndex = 1;
            this.lblSexo.Text = "Sexo :";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(50, 116);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(88, 16);
            this.lblNascimento.TabIndex = 2;
            this.lblNascimento.Text = "Data Nasc :";
            // 
            // lblEndereço
            // 
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.Location = new System.Drawing.Point(56, 165);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(82, 16);
            this.lblEndereço.TabIndex = 3;
            this.lblEndereço.Text = "Endereço :";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(294, 196);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(64, 16);
            this.lblCelular.TabIndex = 4;
            this.lblCelular.Text = "Celular :";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(61, 196);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(77, 16);
            this.lblTelefone.TabIndex = 5;
            this.lblTelefone.Text = "Telefone :";
            // 
            // lblProfissao
            // 
            this.lblProfissao.AutoSize = true;
            this.lblProfissao.Location = new System.Drawing.Point(57, 226);
            this.lblProfissao.Name = "lblProfissao";
            this.lblProfissao.Size = new System.Drawing.Size(81, 16);
            this.lblProfissao.TabIndex = 6;
            this.lblProfissao.Text = "Profissão :";
            // 
            // lblPatologia
            // 
            this.lblPatologia.AutoSize = true;
            this.lblPatologia.Location = new System.Drawing.Point(56, 256);
            this.lblPatologia.Name = "lblPatologia";
            this.lblPatologia.Size = new System.Drawing.Size(82, 16);
            this.lblPatologia.TabIndex = 7;
            this.lblPatologia.Text = "Patologia :";
            // 
            // lblCirurgias
            // 
            this.lblCirurgias.AutoSize = true;
            this.lblCirurgias.Location = new System.Drawing.Point(61, 288);
            this.lblCirurgias.Name = "lblCirurgias";
            this.lblCirurgias.Size = new System.Drawing.Size(77, 16);
            this.lblCirurgias.TabIndex = 8;
            this.lblCirurgias.Text = "Cirurgias :";
            this.lblCirurgias.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblExames
            // 
            this.lblExames.AutoSize = true;
            this.lblExames.Location = new System.Drawing.Point(68, 319);
            this.lblExames.Name = "lblExames";
            this.lblExames.Size = new System.Drawing.Size(70, 16);
            this.lblExames.TabIndex = 9;
            this.lblExames.Text = "Exames :";
            // 
            // lblQueixaPrincipal
            // 
            this.lblQueixaPrincipal.AutoSize = true;
            this.lblQueixaPrincipal.Location = new System.Drawing.Point(11, 352);
            this.lblQueixaPrincipal.Name = "lblQueixaPrincipal";
            this.lblQueixaPrincipal.Size = new System.Drawing.Size(127, 16);
            this.lblQueixaPrincipal.TabIndex = 10;
            this.lblQueixaPrincipal.Text = "Queixa principal :";
            // 
            // lblAnamnese
            // 
            this.lblAnamnese.AutoSize = true;
            this.lblAnamnese.Location = new System.Drawing.Point(53, 385);
            this.lblAnamnese.Name = "lblAnamnese";
            this.lblAnamnese.Size = new System.Drawing.Size(88, 16);
            this.lblAnamnese.TabIndex = 11;
            this.lblAnamnese.Text = "Anamnese :";
            // 
            // lblObjetivo
            // 
            this.lblObjetivo.AutoSize = true;
            this.lblObjetivo.Location = new System.Drawing.Point(65, 425);
            this.lblObjetivo.Name = "lblObjetivo";
            this.lblObjetivo.Size = new System.Drawing.Size(73, 16);
            this.lblObjetivo.TabIndex = 12;
            this.lblObjetivo.Text = "Objetivo :";
            this.lblObjetivo.Click += new System.EventHandler(this.lblObjetivo_Click);
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(151, 73);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(95, 20);
            this.rbtMasculino.TabIndex = 13;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtFeminino
            // 
            this.rbtFeminino.AutoSize = true;
            this.rbtFeminino.Location = new System.Drawing.Point(270, 75);
            this.rbtFeminino.Name = "rbtFeminino";
            this.rbtFeminino.Size = new System.Drawing.Size(88, 20);
            this.rbtFeminino.TabIndex = 14;
            this.rbtFeminino.TabStop = true;
            this.rbtFeminino.Text = "Feminino";
            this.rbtFeminino.UseVisualStyleBackColor = true;
            this.rbtFeminino.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // dteNascimento
            // 
            this.dteNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteNascimento.Location = new System.Drawing.Point(145, 116);
            this.dteNascimento.Name = "dteNascimento";
            this.dteNascimento.Size = new System.Drawing.Size(200, 22);
            this.dteNascimento.TabIndex = 15;
            // 
            // rchObjetivo
            // 
            this.rchObjetivo.Location = new System.Drawing.Point(140, 422);
            this.rchObjetivo.Name = "rchObjetivo";
            this.rchObjetivo.Size = new System.Drawing.Size(657, 166);
            this.rchObjetivo.TabIndex = 16;
            this.rchObjetivo.Text = "";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(706, 683);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(103, 49);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(140, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(657, 22);
            this.txtNome.TabIndex = 18;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(140, 165);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(657, 22);
            this.txtEnd.TabIndex = 19;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(140, 196);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(122, 22);
            this.txtTel.TabIndex = 20;
            // 
            // txtProfissao
            // 
            this.txtProfissao.Location = new System.Drawing.Point(140, 226);
            this.txtProfissao.Name = "txtProfissao";
            this.txtProfissao.Size = new System.Drawing.Size(657, 22);
            this.txtProfissao.TabIndex = 21;
            // 
            // txtQueixaPrincipal
            // 
            this.txtQueixaPrincipal.Location = new System.Drawing.Point(140, 349);
            this.txtQueixaPrincipal.Name = "txtQueixaPrincipal";
            this.txtQueixaPrincipal.Size = new System.Drawing.Size(657, 22);
            this.txtQueixaPrincipal.TabIndex = 22;
            // 
            // txtPatologia
            // 
            this.txtPatologia.Location = new System.Drawing.Point(140, 256);
            this.txtPatologia.Name = "txtPatologia";
            this.txtPatologia.Size = new System.Drawing.Size(657, 22);
            this.txtPatologia.TabIndex = 23;
            // 
            // txtExames
            // 
            this.txtExames.Location = new System.Drawing.Point(140, 316);
            this.txtExames.Name = "txtExames";
            this.txtExames.Size = new System.Drawing.Size(657, 22);
            this.txtExames.TabIndex = 24;
            // 
            // txtCirurgias
            // 
            this.txtCirurgias.Location = new System.Drawing.Point(140, 288);
            this.txtCirurgias.Name = "txtCirurgias";
            this.txtCirurgias.Size = new System.Drawing.Size(657, 22);
            this.txtCirurgias.TabIndex = 25;
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(364, 196);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(158, 22);
            this.txtCel.TabIndex = 26;
            // 
            // txtAnamnese
            // 
            this.txtAnamnese.Location = new System.Drawing.Point(140, 382);
            this.txtAnamnese.Name = "txtAnamnese";
            this.txtAnamnese.Size = new System.Drawing.Size(657, 22);
            this.txtAnamnese.TabIndex = 27;
            // 
            // FormNovaFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 817);
            this.Controls.Add(this.txtAnamnese);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.txtCirurgias);
            this.Controls.Add(this.txtExames);
            this.Controls.Add(this.txtPatologia);
            this.Controls.Add(this.txtQueixaPrincipal);
            this.Controls.Add(this.txtProfissao);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.rchObjetivo);
            this.Controls.Add(this.dteNascimento);
            this.Controls.Add(this.rbtFeminino);
            this.Controls.Add(this.rbtMasculino);
            this.Controls.Add(this.lblObjetivo);
            this.Controls.Add(this.lblAnamnese);
            this.Controls.Add(this.lblQueixaPrincipal);
            this.Controls.Add(this.lblExames);
            this.Controls.Add(this.lblCirurgias);
            this.Controls.Add(this.lblPatologia);
            this.Controls.Add(this.lblProfissao);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblEndereço);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNovaFicha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Ficha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblEndereço;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblProfissao;
        private System.Windows.Forms.Label lblPatologia;
        private System.Windows.Forms.Label lblCirurgias;
        private System.Windows.Forms.Label lblExames;
        private System.Windows.Forms.Label lblQueixaPrincipal;
        private System.Windows.Forms.Label lblAnamnese;
        private System.Windows.Forms.Label lblObjetivo;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.RadioButton rbtFeminino;
        private System.Windows.Forms.DateTimePicker dteNascimento;
        private System.Windows.Forms.RichTextBox rchObjetivo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtProfissao;
        private System.Windows.Forms.TextBox txtQueixaPrincipal;
        private System.Windows.Forms.TextBox txtPatologia;
        private System.Windows.Forms.TextBox txtExames;
        private System.Windows.Forms.TextBox txtCirurgias;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.TextBox txtAnamnese;
        public System.Windows.Forms.Button btnSalvar;
    }
}
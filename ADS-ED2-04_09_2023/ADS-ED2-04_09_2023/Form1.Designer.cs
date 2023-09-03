namespace ADS_ED2_04_09_2023
{
    partial class Form1
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
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.gTelefones = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cbPrincipal = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gContato = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gTelefones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gContato)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(149, 39);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(499, 12);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(152, 39);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(344, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(130, 39);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(184, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(138, 39);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(75, 68);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(204, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // cbTipo
            // 
            this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] { "Móvel", "Residencia", "Comercial" });
            this.cbTipo.Location = new System.Drawing.Point(315, 213);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(59, 24);
            this.cbTipo.TabIndex = 7;
            // 
            // gTelefones
            // 
            this.gTelefones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gTelefones.Location = new System.Drawing.Point(295, 57);
            this.gTelefones.Name = "gTelefones";
            this.gTelefones.Size = new System.Drawing.Size(356, 148);
            this.gTelefones.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(75, 115);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(204, 26);
            this.txtNome.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Data de nascimento";
            // 
            // txtDia
            // 
            this.txtDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDia.Location = new System.Drawing.Point(16, 216);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(27, 26);
            this.txtDia.TabIndex = 13;
            // 
            // txtAno
            // 
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.Location = new System.Drawing.Point(82, 216);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(54, 26);
            this.txtAno.TabIndex = 15;
            // 
            // txtMes
            // 
            this.txtMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMes.Location = new System.Drawing.Point(49, 216);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(27, 26);
            this.txtMes.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(374, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(426, 215);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(92, 22);
            this.txtNumero.TabIndex = 19;
            // 
            // cbPrincipal
            // 
            this.cbPrincipal.AutoSize = true;
            this.cbPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrincipal.Location = new System.Drawing.Point(520, 217);
            this.cbPrincipal.Name = "cbPrincipal";
            this.cbPrincipal.Size = new System.Drawing.Size(79, 20);
            this.cbPrincipal.TabIndex = 20;
            this.cbPrincipal.Text = "Principal";
            this.cbPrincipal.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 31);
            this.button1.TabIndex = 21;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gContato
            // 
            this.gContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gContato.Location = new System.Drawing.Point(17, 253);
            this.gContato.Name = "gContato";
            this.gContato.Size = new System.Drawing.Size(634, 152);
            this.gContato.TabIndex = 22;
            this.gContato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gContato_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 27);
            this.button2.TabIndex = 23;
            this.button2.Text = "Listar contatos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gContato);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbPrincipal);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.gTelefones);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnNovo);
            this.Name = "Form1";
            this.Text = "Agenda";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.gTelefones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gContato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSalvar;

        #endregion

        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.DataGridView gTelefones;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.CheckBox cbPrincipal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gContato;
        private System.Windows.Forms.Button button2;
    }
}
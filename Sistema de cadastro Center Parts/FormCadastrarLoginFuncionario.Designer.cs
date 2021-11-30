
namespace Sistema_de_cadastro_Center_Parts
{
    partial class FormCadastrarLoginFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrarLoginFuncionario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxSenha = new System.Windows.Forms.CheckBox();
            this.TxtSenhaFuncionario = new System.Windows.Forms.TextBox();
            this.TxtEmailFuncionario = new System.Windows.Forms.TextBox();
            this.LabelSenha = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.txtcadastrar = new System.Windows.Forms.Button();
            this.TxtNomeUsuarioFuncionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(109, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 105);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxSenha
            // 
            this.checkBoxSenha.AutoSize = true;
            this.checkBoxSenha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSenha.Location = new System.Drawing.Point(112, 267);
            this.checkBoxSenha.Name = "checkBoxSenha";
            this.checkBoxSenha.Size = new System.Drawing.Size(110, 21);
            this.checkBoxSenha.TabIndex = 13;
            this.checkBoxSenha.Text = "Mostrar senha";
            this.checkBoxSenha.UseVisualStyleBackColor = true;
            // 
            // TxtSenhaFuncionario
            // 
            this.TxtSenhaFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenhaFuncionario.Location = new System.Drawing.Point(90, 228);
            this.TxtSenhaFuncionario.Name = "TxtSenhaFuncionario";
            this.TxtSenhaFuncionario.PasswordChar = '*';
            this.TxtSenhaFuncionario.Size = new System.Drawing.Size(173, 26);
            this.TxtSenhaFuncionario.TabIndex = 12;
            this.TxtSenhaFuncionario.TextChanged += new System.EventHandler(this.TxtSenhaFuncionario_TextChanged);
            // 
            // TxtEmailFuncionario
            // 
            this.TxtEmailFuncionario.BackColor = System.Drawing.SystemColors.Control;
            this.TxtEmailFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmailFuncionario.Location = new System.Drawing.Point(90, 196);
            this.TxtEmailFuncionario.Name = "TxtEmailFuncionario";
            this.TxtEmailFuncionario.Size = new System.Drawing.Size(173, 26);
            this.TxtEmailFuncionario.TabIndex = 11;
            this.TxtEmailFuncionario.TextChanged += new System.EventHandler(this.txtEmailFunc_TextChanged);
            // 
            // LabelSenha
            // 
            this.LabelSenha.AutoSize = true;
            this.LabelSenha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSenha.Location = new System.Drawing.Point(20, 231);
            this.LabelSenha.Name = "LabelSenha";
            this.LabelSenha.Size = new System.Drawing.Size(54, 20);
            this.LabelSenha.TabIndex = 10;
            this.LabelSenha.Text = "Senha";
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelEmail.Location = new System.Drawing.Point(20, 202);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(51, 20);
            this.LabelEmail.TabIndex = 9;
            this.LabelEmail.Text = "E-mail";
            // 
            // txtcadastrar
            // 
            this.txtcadastrar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtcadastrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtcadastrar.Location = new System.Drawing.Point(117, 292);
            this.txtcadastrar.Name = "txtcadastrar";
            this.txtcadastrar.Size = new System.Drawing.Size(103, 38);
            this.txtcadastrar.TabIndex = 14;
            this.txtcadastrar.Text = "Cadastrar";
            this.txtcadastrar.UseVisualStyleBackColor = false;
            this.txtcadastrar.Click += new System.EventHandler(this.txtcadastrar_Click);
            // 
            // TxtNomeUsuarioFuncionario
            // 
            this.TxtNomeUsuarioFuncionario.BackColor = System.Drawing.SystemColors.Control;
            this.TxtNomeUsuarioFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeUsuarioFuncionario.Location = new System.Drawing.Point(90, 164);
            this.TxtNomeUsuarioFuncionario.Name = "TxtNomeUsuarioFuncionario";
            this.TxtNomeUsuarioFuncionario.Size = new System.Drawing.Size(173, 26);
            this.TxtNomeUsuarioFuncionario.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(20, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Usuario";
            // 
            // TxtID
            // 
            this.TxtID.BackColor = System.Drawing.SystemColors.Control;
            this.TxtID.Enabled = false;
            this.TxtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID.Location = new System.Drawing.Point(90, 132);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(173, 26);
            this.TxtID.TabIndex = 17;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label.Location = new System.Drawing.Point(20, 138);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(24, 20);
            this.label.TabIndex = 18;
            this.label.Text = "Id";
            // 
            // FormCadastrarLoginFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(329, 342);
            this.Controls.Add(this.label);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNomeUsuarioFuncionario);
            this.Controls.Add(this.txtcadastrar);
            this.Controls.Add(this.checkBoxSenha);
            this.Controls.Add(this.TxtSenhaFuncionario);
            this.Controls.Add(this.TxtEmailFuncionario);
            this.Controls.Add(this.LabelSenha);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastrarLoginFuncionario";
            this.Text = "CadastrarLoginFuncionario";
            this.Load += new System.EventHandler(this.FormCadastrarLoginFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxSenha;
        private System.Windows.Forms.TextBox TxtSenhaFuncionario;
        private System.Windows.Forms.TextBox TxtEmailFuncionario;
        private System.Windows.Forms.Label LabelSenha;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Button txtcadastrar;
        private System.Windows.Forms.TextBox TxtNomeUsuarioFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label;
    }
}
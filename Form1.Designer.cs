namespace Funcionarios
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtCPF = new TextBox();
            txtEndereco = new TextBox();
            btnCadastrar = new Button();
            mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            btnPesquisar = new Button();
            label5 = new Label();
            lblid = new Label();
            btnLimpar = new Button();
            btnAtualizar = new Button();
            btnDeletar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 81);
            label1.Name = "label1";
            label1.Size = new Size(45, 16);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 124);
            label2.Name = "label2";
            label2.Size = new Size(48, 16);
            label2.TabIndex = 2;
            label2.Text = "E-mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 171);
            label3.Name = "label3";
            label3.Size = new Size(37, 16);
            label3.TabIndex = 3;
            label3.Text = "CPF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 209);
            label4.Name = "label4";
            label4.Size = new Size(66, 16);
            label4.TabIndex = 4;
            label4.Text = "Endereço:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(108, 71);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(514, 26);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(108, 114);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(514, 26);
            txtEmail.TabIndex = 2;
            // 
            // txtCPF
            // 
            txtCPF.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCPF.Location = new Point(108, 161);
            txtCPF.MaxLength = 11;
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(514, 26);
            txtCPF.TabIndex = 3;
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndereco.Location = new Point(108, 199);
            txtEndereco.MaxLength = 200;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(514, 26);
            txtEndereco.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(12, 317);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(105, 38);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisar.Location = new Point(135, 317);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(105, 38);
            btnPesquisar.TabIndex = 6;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 29);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 7;
            label5.Text = "Funcionário Id: ";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(108, 29);
            lblid.Name = "lblid";
            lblid.Size = new Size(17, 15);
            lblid.TabIndex = 8;
            lblid.Text = "id";
            // 
            // btnLimpar
            // 
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpar.Location = new Point(874, 12);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(105, 38);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtualizar.Location = new Point(260, 317);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(105, 38);
            btnAtualizar.TabIndex = 10;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.FlatStyle = FlatStyle.Flat;
            btnDeletar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeletar.Location = new Point(383, 317);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(105, 38);
            btnDeletar.TabIndex = 11;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 385);
            Controls.Add(btnDeletar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnLimpar);
            Controls.Add(lblid);
            Controls.Add(label5);
            Controls.Add(btnPesquisar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtEndereco);
            Controls.Add(txtCPF);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Funcionarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtCPF;
        private TextBox txtEndereco;
        private Button btnCadastrar;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private Button btnPesquisar;
        private Label label5;
        private Label lblid;
        private Button btnLimpar;
        private Button btnAtualizar;
        private Button btnDeletar;
    }
}
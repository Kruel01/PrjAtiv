namespace pjrAtiv
{
    partial class TelaCadastro
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
            TxtNome = new TextBox();
            TxtRG = new TextBox();
            TxtCPF = new TextBox();
            TxtEndereco = new TextBox();
            TxtTelefone = new TextBox();
            TxtEmail = new TextBox();
            TxtCidade = new TextBox();
            TxtSenha = new TextBox();
            CbTipoConta = new ComboBox();
            DtNascimento = new DateTimePicker();
            BtnCadastrar = new Button();
            BtnLimpar = new Button();
            SuspendLayout();
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(12, 44);
            TxtNome.Name = "TxtNome";
            TxtNome.PlaceholderText = "Nome";
            TxtNome.Size = new Size(125, 23);
            TxtNome.TabIndex = 0;
            TxtNome.TextChanged += textBox1_TextChanged;
            // 
            // TxtRG
            // 
            TxtRG.Location = new Point(12, 150);
            TxtRG.Name = "TxtRG";
            TxtRG.PlaceholderText = "RG";
            TxtRG.Size = new Size(125, 23);
            TxtRG.TabIndex = 1;
            // 
            // TxtCPF
            // 
            TxtCPF.Location = new Point(12, 202);
            TxtCPF.Name = "TxtCPF";
            TxtCPF.PlaceholderText = "CPF";
            TxtCPF.Size = new Size(125, 23);
            TxtCPF.TabIndex = 2;
            // 
            // TxtEndereco
            // 
            TxtEndereco.Location = new Point(12, 257);
            TxtEndereco.Name = "TxtEndereco";
            TxtEndereco.PlaceholderText = "Endereço";
            TxtEndereco.Size = new Size(125, 23);
            TxtEndereco.TabIndex = 3;
            // 
            // TxtTelefone
            // 
            TxtTelefone.Location = new Point(12, 355);
            TxtTelefone.Name = "TxtTelefone";
            TxtTelefone.PlaceholderText = "Telefone";
            TxtTelefone.Size = new Size(125, 23);
            TxtTelefone.TabIndex = 4;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(215, 101);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.PlaceholderText = "Email";
            TxtEmail.Size = new Size(128, 23);
            TxtEmail.TabIndex = 5;
            // 
            // TxtCidade
            // 
            TxtCidade.Location = new Point(12, 304);
            TxtCidade.Name = "TxtCidade";
            TxtCidade.PlaceholderText = "Cidade";
            TxtCidade.Size = new Size(125, 23);
            TxtCidade.TabIndex = 6;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(215, 150);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.PlaceholderText = "Senha";
            TxtSenha.Size = new Size(128, 23);
            TxtSenha.TabIndex = 7;
            TxtSenha.UseSystemPasswordChar = true;
            TxtSenha.TextChanged += TxtSenha_TextChanged;
            // 
            // CbTipoConta
            // 
            CbTipoConta.FormattingEnabled = true;
            CbTipoConta.Items.AddRange(new object[] { "Conta Corrente", "Saque Especial" });
            CbTipoConta.Location = new Point(215, 44);
            CbTipoConta.Name = "CbTipoConta";
            CbTipoConta.Size = new Size(125, 23);
            CbTipoConta.TabIndex = 8;
            CbTipoConta.Text = "Tipo de Conta";
            CbTipoConta.SelectedIndexChanged += CbTipoConta_SelectedIndexChanged;
            // 
            // DtNascimento
            // 
            DtNascimento.Location = new Point(12, 98);
            DtNascimento.Name = "DtNascimento";
            DtNascimento.Size = new Size(136, 23);
            DtNascimento.TabIndex = 9;
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.Location = new Point(215, 201);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(75, 23);
            BtnCadastrar.TabIndex = 10;
            BtnCadastrar.Text = "Cadastrar";
            BtnCadastrar.UseVisualStyleBackColor = true;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(215, 246);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(75, 23);
            BtnLimpar.TabIndex = 11;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            BtnLimpar.Click += BtnLimpar_Click;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 428);
            Controls.Add(BtnLimpar);
            Controls.Add(BtnCadastrar);
            Controls.Add(DtNascimento);
            Controls.Add(CbTipoConta);
            Controls.Add(TxtSenha);
            Controls.Add(TxtCidade);
            Controls.Add(TxtEmail);
            Controls.Add(TxtTelefone);
            Controls.Add(TxtEndereco);
            Controls.Add(TxtCPF);
            Controls.Add(TxtRG);
            Controls.Add(TxtNome);
            Name = "TelaCadastro";
            Text = "TelaCadastro";
            Load += TelaCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNome;
        private TextBox TxtRG;
        private TextBox TxtCPF;
        private TextBox TxtEndereco;
        private TextBox TxtTelefone;
        private TextBox TxtEmail;
        private TextBox TxtCidade;
        private TextBox TxtSenha;
        private ComboBox CbTipoConta;
        private DateTimePicker DtNascimento;
        private Button BtnCadastrar;
        private Button BtnLimpar;
    }
}
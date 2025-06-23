namespace App.WinForms.Forms
{
    partial class FornecedorForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblCNPJ = new Label();
            txtCNPJ = new TextBox();
            btnBuscarCNPJ = new Button();
            lblRazaoSocial = new Label();
            txtRazaoSocial = new TextBox();
            lblLogradouro = new Label();
            txtLogradouro = new TextBox();
            lblNumero = new Label();
            txtNumero = new TextBox();
            lblBairro = new Label();
            txtBairro = new TextBox();
            lblCidade = new Label();
            txtCidade = new TextBox();
            lblEstado = new Label();
            txtEstado = new TextBox();
            lblCEP = new Label();
            txtCEP = new TextBox();
            lblTelefone = new Label();
            txtTelefone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblResponsavel = new Label();
            txtResponsavel = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();

            lblCNPJ.AutoSize = true;
            lblCNPJ.Location = new Point(16, 37);
            lblCNPJ.Name = "lblCNPJ";
            lblCNPJ.Size = new Size(37, 15);
            lblCNPJ.TabIndex = 0;
            lblCNPJ.Text = "CNPJ:";

            txtCNPJ.Location = new Point(80, 33);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(186, 23);
            txtCNPJ.TabIndex = 1;

            btnBuscarCNPJ.Location = new Point(272, 33);
            btnBuscarCNPJ.Name = "btnBuscarCNPJ";
            btnBuscarCNPJ.Size = new Size(97, 23);
            btnBuscarCNPJ.TabIndex = 2;
            btnBuscarCNPJ.Text = "Buscar CNPJ";
            btnBuscarCNPJ.UseVisualStyleBackColor = true;
            btnBuscarCNPJ.Click += btnBuscarCNPJ_Click;

            lblRazaoSocial.AutoSize = true;
            lblRazaoSocial.Location = new Point(3, 83);
            lblRazaoSocial.Name = "lblRazaoSocial";
            lblRazaoSocial.Size = new Size(75, 15);
            lblRazaoSocial.TabIndex = 3;
            lblRazaoSocial.Text = "Razão Social:";

            txtRazaoSocial.Location = new Point(80, 80);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(186, 23);
            txtRazaoSocial.TabIndex = 4;

            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(3, 134);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(72, 15);
            lblLogradouro.TabIndex = 7;
            lblLogradouro.Text = "Logradouro:";

            txtLogradouro.Location = new Point(80, 131);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(186, 23);
            txtLogradouro.TabIndex = 8;

            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(276, 134);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 9;
            lblNumero.Text = "Número:";

            txtNumero.Location = new Point(336, 131);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(153, 23);
            txtNumero.TabIndex = 10;

            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(495, 134);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(41, 15);
            lblBairro.TabIndex = 11;
            lblBairro.Text = "Bairro:";

            txtBairro.Location = new Point(542, 131);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(172, 23);
            txtBairro.TabIndex = 12;

            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(6, 184);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(47, 15);
            lblCidade.TabIndex = 13;
            lblCidade.Text = "Cidade:";

            txtCidade.Location = new Point(80, 184);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(186, 23);
            txtCidade.TabIndex = 14;

            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(276, 187);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 15;
            lblEstado.Text = "Estado:";

            txtEstado.Location = new Point(336, 181);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(153, 23);
            txtEstado.TabIndex = 16;

            lblCEP.AutoSize = true;
            lblCEP.Location = new Point(505, 184);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(31, 15);
            lblCEP.TabIndex = 17;
            lblCEP.Text = "CEP:";

            txtCEP.Location = new Point(542, 181);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(172, 23);
            txtCEP.TabIndex = 18;

            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(6, 237);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(55, 15);
            lblTelefone.TabIndex = 19;
            lblTelefone.Text = "Telefone:";

            txtTelefone.Location = new Point(80, 234);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(186, 23);
            txtTelefone.TabIndex = 20;

            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(276, 237);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 21;
            lblEmail.Text = "E-mail:";

            txtEmail.Location = new Point(336, 229);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(153, 23);
            txtEmail.TabIndex = 22;

            lblResponsavel.AutoSize = true;
            lblResponsavel.Location = new Point(6, 289);
            lblResponsavel.Name = "lblResponsavel";
            lblResponsavel.Size = new Size(75, 30);
            lblResponsavel.TabIndex = 23;
            lblResponsavel.Text = "Nome do \r\nResponsável:";

            txtResponsavel.Location = new Point(80, 296);
            txtResponsavel.Name = "txtResponsavel";
            txtResponsavel.Size = new Size(186, 23);
            txtResponsavel.TabIndex = 24;

            btnSalvar.Location = new Point(602, 403);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 25;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;

            btnCancelar.Location = new Point(695, 403);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtResponsavel);
            Controls.Add(lblResponsavel);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(txtCEP);
            Controls.Add(lblCEP);
            Controls.Add(txtEstado);
            Controls.Add(lblEstado);
            Controls.Add(txtCidade);
            Controls.Add(lblCidade);
            Controls.Add(txtBairro);
            Controls.Add(lblBairro);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(txtLogradouro);
            Controls.Add(lblLogradouro);
            Controls.Add(txtRazaoSocial);
            Controls.Add(lblRazaoSocial);
            Controls.Add(btnBuscarCNPJ);
            Controls.Add(txtCNPJ);
            Controls.Add(lblCNPJ);
            Name = "FornecedorForm";
            Text = "FornecedorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblCNPJ;
        private TextBox txtCNPJ;
        private Button btnBuscarCNPJ;
        private Label lblRazaoSocial;
        private TextBox txtRazaoSocial;
        private Label lblLogradouro;
        private TextBox txtLogradouro;
        private Label lblNumero;
        private TextBox txtNumero;
        private Label lblBairro;
        private TextBox txtBairro;
        private Label lblCidade;
        private TextBox txtCidade;
        private Label lblEstado;
        private TextBox txtEstado;
        private Label lblCEP;
        private TextBox txtCEP;
        private Label lblTelefone;
        private TextBox txtTelefone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblResponsavel;
        private TextBox txtResponsavel;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}
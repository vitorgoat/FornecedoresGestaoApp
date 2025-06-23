namespace App.WinForms.Forms
{
    public partial class MainForm : Form
    {
       
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnNovoFornecedor;
        private System.Windows.Forms.Button btnListarFornecedores;

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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "MainForm";

            this.btnNovoFornecedor = new System.Windows.Forms.Button();
            this.btnListarFornecedores = new System.Windows.Forms.Button();

            this.btnNovoFornecedor.Location = new System.Drawing.Point(30, 30);
            this.btnNovoFornecedor.Name = "btnNovoFornecedor";
            this.btnNovoFornecedor.Size = new System.Drawing.Size(150, 40);
            this.btnNovoFornecedor.TabIndex = 0;
            this.btnNovoFornecedor.Text = "Novo Fornecedor";
            this.btnNovoFornecedor.UseVisualStyleBackColor = true;
            this.btnNovoFornecedor.Click += new System.EventHandler(this.btnNovoFornecedor_Click);

            this.btnListarFornecedores.Location = new System.Drawing.Point(30, 80);
            this.btnListarFornecedores.Name = "btnListarFornecedores";
            this.btnListarFornecedores.Size = new System.Drawing.Size(150, 40);
            this.btnListarFornecedores.TabIndex = 1;
            this.btnListarFornecedores.Text = "Listar Fornecedores";
            this.btnListarFornecedores.UseVisualStyleBackColor = true;
            this.btnListarFornecedores.Click += new System.EventHandler(this.btnListarFornecedores_Click);

            this.Controls.Add(this.btnNovoFornecedor);
            this.Controls.Add(this.btnListarFornecedores);
        }
    }
}
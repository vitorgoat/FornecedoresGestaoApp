namespace App.WinForms.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            var form = new FornecedorForm();
            form.ShowDialog();
        }

        private void btnListarFornecedores_Click(object sender, EventArgs e)
        {
            var form = new FornecedorListForm();
            form.ShowDialog();
        }
    }
}

using App.Infrastructure.Repositories;
using App.Domain.Entities;

namespace App.WinForms.Forms
{
    public partial class FornecedorListForm : Form
    {
        public FornecedorListForm()
        {
            InitializeComponent();
            CarregarFornecedores();
        }

        private void CarregarFornecedores()
        {
            var repo = new FornecedorRepository();
            var lista = repo.ListarTodos();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarFornecedores();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Fornecedor fornecedor)
            {
                var form = new FornecedorForm(fornecedor);
                form.ShowDialog();
                CarregarFornecedores();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Fornecedor fornecedor)
            {
                if (MessageBox.Show("Confirma exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var repo = new FornecedorRepository();
                    repo.Excluir(fornecedor.Id);
                    CarregarFornecedores();
                }
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Fornecedor fornecedor)
            {
                var form = new FornecedorForm(fornecedor, somenteLeitura: true);
                form.ShowDialog();
            }
        }
    }
}

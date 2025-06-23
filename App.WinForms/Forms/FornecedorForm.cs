using App.ApplicationServices.ExternalServices;
using App.Domain.Entities;
using System.Text.RegularExpressions;
using App.Infrastructure.Repositories;

namespace App.WinForms.Forms
{
    public partial class FornecedorForm : Form
    {
        private Fornecedor _fornecedorEmEdicao;
        private bool _somenteLeitura = false;

        public FornecedorForm()
        {
            InitializeComponent();
        }

        public FornecedorForm(Fornecedor fornecedor = null, bool somenteLeitura = false)
        {
            InitializeComponent();
            _somenteLeitura = somenteLeitura;
            if (fornecedor != null)
            {
                _fornecedorEmEdicao = fornecedor;
                txtRazaoSocial.Text = fornecedor.RazaoSocial;
                txtCNPJ.Text = fornecedor.CNPJ;
                txtLogradouro.Text = fornecedor.Logradouro;
                txtNumero.Text = fornecedor.Numero;
                txtBairro.Text = fornecedor.Bairro;
                txtCidade.Text = fornecedor.Cidade;
                txtEstado.Text = fornecedor.Estado;
                txtCEP.Text = fornecedor.CEP;
                txtTelefone.Text = fornecedor.Telefone;
                txtEmail.Text = fornecedor.Email;
                txtResponsavel.Text = fornecedor.NomeDoResponsavel;
            }
            if (_somenteLeitura)
            {
                txtRazaoSocial.ReadOnly = true;
                txtCNPJ.ReadOnly = true;
                txtLogradouro.ReadOnly = true;
                txtNumero.ReadOnly = true;
                txtBairro.ReadOnly = true;
                txtCidade.ReadOnly = true;
                txtEstado.ReadOnly = true;
                txtCEP.ReadOnly = true;
                txtTelefone.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtResponsavel.ReadOnly = true;
                btnSalvar.Enabled = false;
                btnBuscarCNPJ.Enabled = false;
            }
        }

        private async void btnBuscarCNPJ_Click(object sender, EventArgs e)
        {
            string cnpj = Regex.Replace(txtCNPJ.Text, @"[^\d]", "");

            if (cnpj.Length != 14)
            {
                MessageBox.Show("CNPJ inválido. Insira um CNPJ com 14 dígitos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var cnpjService = new CnpjApiService();
                var fornecedor = await cnpjService.ConsultarPorCnpj(cnpj);

                if (fornecedor != null)
                {
                    txtRazaoSocial.Text = fornecedor.RazaoSocial;
                    txtLogradouro.Text = fornecedor.Logradouro;
                    txtNumero.Text = fornecedor.Numero;
                    txtBairro.Text = fornecedor.Bairro;
                    txtCidade.Text = fornecedor.Cidade;
                    txtEstado.Text = fornecedor.Estado;
                    txtCEP.Text = fornecedor.CEP;
                    txtTelefone.Text = fornecedor.Telefone;
                    txtEmail.Text = fornecedor.Email;
                }
                else
                {
                    MessageBox.Show("CNPJ não encontrado ou sem dados disponíveis. Preencha manualmente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar CNPJ:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtRazaoSocial.Text))
            {
                MessageBox.Show("O campo Razão Social é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRazaoSocial.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCNPJ.Text))
            {
                MessageBox.Show("O campo CNPJ é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCNPJ.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLogradouro.Text))
            {
                MessageBox.Show("O campo Logradouro é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogradouro.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                MessageBox.Show("O campo Número é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                MessageBox.Show("O campo Bairro é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBairro.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCidade.Text))
            {
                MessageBox.Show("O campo Cidade é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCidade.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEstado.Text))
            {
                MessageBox.Show("O campo Estado é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstado.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCEP.Text))
            {
                MessageBox.Show("O campo CEP é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCEP.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                MessageBox.Show("O campo Telefone é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefone.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("O campo Email é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtResponsavel.Text))
            {
                MessageBox.Show("O campo Nome do Responsável é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtResponsavel.Focus();
                return false;
            }
            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {
                var repo = new FornecedorRepository();
                if (_fornecedorEmEdicao == null)
                {
                    var novo = new Fornecedor(
                        txtRazaoSocial.Text,
                        txtCNPJ.Text,
                        txtLogradouro.Text,
                        txtNumero.Text,
                        txtBairro.Text,
                        txtCidade.Text,
                        txtEstado.Text,
                        txtCEP.Text,
                        txtTelefone.Text,
                        txtEmail.Text,
                        txtResponsavel.Text
                    );
                    repo.Adicionar(novo);
                }
                else
                {
                    _fornecedorEmEdicao.RazaoSocial = txtRazaoSocial.Text;
                    _fornecedorEmEdicao.CNPJ = txtCNPJ.Text;
                    _fornecedorEmEdicao.Logradouro = txtLogradouro.Text;
                    _fornecedorEmEdicao.Numero = txtNumero.Text;
                    _fornecedorEmEdicao.Bairro = txtBairro.Text;
                    _fornecedorEmEdicao.Cidade = txtCidade.Text;
                    _fornecedorEmEdicao.Estado = txtEstado.Text;
                    _fornecedorEmEdicao.CEP = txtCEP.Text;
                    _fornecedorEmEdicao.Telefone = txtTelefone.Text;
                    _fornecedorEmEdicao.Email = txtEmail.Text;
                    _fornecedorEmEdicao.NomeDoResponsavel = txtResponsavel.Text;
                    repo.Atualizar(_fornecedorEmEdicao);
                }
                MessageBox.Show("Fornecedor salvo com sucesso!");
                this.Close();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar fornecedor:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblResponsavel_Click(object sender, EventArgs e)
        {

        }
    }
}

using App.Domain.Entities;

namespace App.Domain.Interfaces
{

    public interface IFornecedorRepository
    {
        void Adicionar(Fornecedor fornecedor);
        void Atualizar(Fornecedor fornecedor);
        void Excluir(int id);
        Fornecedor ObterPorCNPJ(string cnpj);
        Fornecedor ObterPorId(int id);
        List<Fornecedor> ListarTodos();
    }

}

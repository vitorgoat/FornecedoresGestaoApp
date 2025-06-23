using App.Domain.Entities;
using App.Domain.Interfaces;

namespace App.ApplicationServices.Services
{
    public class FornecedorService
    {
        private readonly IFornecedorRepository _repository;

        public FornecedorService(IFornecedorRepository repository)
        {
            _repository = repository;
        }

        public void CadastrarFornecedor(Fornecedor fornecedor)
        {
            _repository.Adicionar(fornecedor);
        }

        public List<Fornecedor> ListarTodos()
        {
            return _repository.ListarTodos();
        }
    }
}

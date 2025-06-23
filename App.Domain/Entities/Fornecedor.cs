using System;
using System.ComponentModel.DataAnnotations;

namespace App.Domain.Entities
{
    public class Fornecedor
    {
        public int Id { get; set; }

        [Required]
        public string RazaoSocial { get; set; }

        [Required]
        public string CNPJ { get; set; }

        [Required]
        public string Logradouro { get; set; }

        [Required]
        public string Numero { get; set; }

        [Required]
        public string Bairro { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        public string Estado { get; set; }

        [Required]
        public string CEP { get; set; }

        [Required]
        public string Telefone { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string NomeDoResponsavel { get; set; }

        protected Fornecedor()
        {
            RazaoSocial = string.Empty;
            CNPJ = string.Empty;
            Logradouro = string.Empty;
            Numero = string.Empty;
            Bairro = string.Empty;
            Cidade = string.Empty;
            Estado = string.Empty;
            CEP = string.Empty;
            Telefone = string.Empty;
            Email = string.Empty;
            NomeDoResponsavel = string.Empty;
        }

        public Fornecedor(
            string razaoSocial,
            string cnpj,
            string logradouro,
            string numero,
            string bairro,
            string cidade,
            string estado,
            string cep,
            string telefone,
            string email,
            string nomeDoResponsavel)
        {
            RazaoSocial = razaoSocial ?? throw new ArgumentNullException(nameof(razaoSocial));
            CNPJ = cnpj ?? throw new ArgumentNullException(nameof(cnpj));
            Logradouro = logradouro ?? throw new ArgumentNullException(nameof(logradouro));
            Numero = numero ?? throw new ArgumentNullException(nameof(numero));
            Bairro = bairro ?? throw new ArgumentNullException(nameof(bairro));
            Cidade = cidade ?? throw new ArgumentNullException(nameof(cidade));
            Estado = estado ?? throw new ArgumentNullException(nameof(estado));
            CEP = cep ?? throw new ArgumentNullException(nameof(cep));
            Telefone = telefone ?? throw new ArgumentNullException(nameof(telefone));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            NomeDoResponsavel = nomeDoResponsavel ?? throw new ArgumentNullException(nameof(nomeDoResponsavel));
        }

        public static Fornecedor CriarViaCnpjApi(
            string razaoSocial,
            string cnpj,
            string logradouro,
            string numero,
            string bairro,
            string cidade,
            string estado,
            string cep,
            string telefone,
            string email)
        {
            return new Fornecedor(
                razaoSocial,
                cnpj,
                logradouro,
                numero,
                bairro,
                cidade,
                estado,
                cep,
                telefone,
                email,
                string.Empty
            );
        }
    }
}

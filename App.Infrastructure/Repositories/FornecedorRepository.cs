using App.Domain.Entities;
using App.Domain.Interfaces;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace App.Infrastructure.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly string _connectionString;

        public FornecedorRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"]?.ConnectionString
                                ?? throw new InvalidOperationException("Connection string 'MySqlConnection' not found.");
        }

        public void Adicionar(Fornecedor fornecedor)
        {
            try
            {
                using var conn = new MySqlConnection(_connectionString);
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Fornecedores 
                    (razao_social, cnpj, logradouro, numero, bairro, cidade, estado, cep, telefone, email, nome_responsavel)
                    VALUES 
                    (@RazaoSocial, @CNPJ, @Logradouro, @Numero, @Bairro, @Cidade, @Estado, @CEP, @Telefone, @Email, @NomeDoResponsavel)";
                cmd.Parameters.AddWithValue("@RazaoSocial", DbValue(fornecedor.RazaoSocial));
                cmd.Parameters.AddWithValue("@CNPJ", DbValue(fornecedor.CNPJ));
                cmd.Parameters.AddWithValue("@Logradouro", DbValue(fornecedor.Logradouro));
                cmd.Parameters.AddWithValue("@Numero", DbValue(fornecedor.Numero));
                cmd.Parameters.AddWithValue("@Bairro", DbValue(fornecedor.Bairro));
                cmd.Parameters.AddWithValue("@Cidade", DbValue(fornecedor.Cidade));
                cmd.Parameters.AddWithValue("@Estado", DbValue(fornecedor.Estado));
                cmd.Parameters.AddWithValue("@CEP", DbValue(fornecedor.CEP));
                cmd.Parameters.AddWithValue("@Telefone", DbValue(fornecedor.Telefone));
                cmd.Parameters.AddWithValue("@Email", DbValue(fornecedor.Email));
                cmd.Parameters.AddWithValue("@NomeDoResponsavel", DbValue(fornecedor.NomeDoResponsavel));
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                throw new InvalidOperationException("CNPJ já existe!");
            }
        }

        public void Atualizar(Fornecedor fornecedor)
        {
            using var conn = new MySqlConnection(_connectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"UPDATE Fornecedores SET 
                razao_social = @RazaoSocial,
                cnpj = @CNPJ,
                logradouro = @Logradouro,
                numero = @Numero,
                bairro = @Bairro,
                cidade = @Cidade,
                estado = @Estado,
                cep = @CEP,
                telefone = @Telefone,
                email = @Email,
                nome_responsavel = @NomeDoResponsavel
                WHERE id = @Id";
            cmd.Parameters.AddWithValue("@Id", fornecedor.Id);
            cmd.Parameters.AddWithValue("@RazaoSocial", DbValue(fornecedor.RazaoSocial));
            cmd.Parameters.AddWithValue("@CNPJ", DbValue(fornecedor.CNPJ));
            cmd.Parameters.AddWithValue("@Logradouro", DbValue(fornecedor.Logradouro));
            cmd.Parameters.AddWithValue("@Numero", DbValue(fornecedor.Numero));
            cmd.Parameters.AddWithValue("@Bairro", DbValue(fornecedor.Bairro));
            cmd.Parameters.AddWithValue("@Cidade", DbValue(fornecedor.Cidade));
            cmd.Parameters.AddWithValue("@Estado", DbValue(fornecedor.Estado));
            cmd.Parameters.AddWithValue("@CEP", DbValue(fornecedor.CEP));
            cmd.Parameters.AddWithValue("@Telefone", DbValue(fornecedor.Telefone));
            cmd.Parameters.AddWithValue("@Email", DbValue(fornecedor.Email));
            cmd.Parameters.AddWithValue("@NomeDoResponsavel", DbValue(fornecedor.NomeDoResponsavel));
            cmd.ExecuteNonQuery();
        }

        public void Excluir(int id)
        {
            using var conn = new MySqlConnection(_connectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Fornecedores WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
        }

        public Fornecedor ObterPorId(int id)
        {
            using var conn = new MySqlConnection(_connectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Fornecedores WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", id);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return MapFornecedor(reader);
            }
            throw new InvalidOperationException("Fornecedor com o ID especificado não foi encontrado.");
        }

        public Fornecedor ObterPorCNPJ(string cnpj)
        {
            using var conn = new MySqlConnection(_connectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Fornecedores WHERE CNPJ = @CNPJ";
            cmd.Parameters.AddWithValue("@CNPJ", cnpj);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return MapFornecedor(reader);
            }
            throw new InvalidOperationException("Fornecedor com o CNPJ especificado não foi encontrado.");
        }

        public List<Fornecedor> ListarTodos()
        {
            var fornecedores = new List<Fornecedor>();
            using var conn = new MySqlConnection(_connectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Fornecedores";
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                fornecedores.Add(MapFornecedor(reader));
            }
            return fornecedores;
        }

        private Fornecedor MapFornecedor(MySqlDataReader reader)
        {
            var telefone = ((string)(reader["telefone"] ?? "")).Length > 100
                ? ((string)(reader["telefone"] ?? "")).Substring(0, 100)
                : (string)(reader["telefone"] ?? "");

            return new Fornecedor(
                razaoSocial: reader["razao_social"]?.ToString() ?? string.Empty,
                cnpj: reader["cnpj"]?.ToString() ?? string.Empty,
                logradouro: reader["logradouro"]?.ToString() ?? string.Empty,
                numero: reader["numero"]?.ToString() ?? string.Empty,
                bairro: reader["bairro"]?.ToString() ?? string.Empty,
                cidade: reader["cidade"]?.ToString() ?? string.Empty,
                estado: reader["estado"]?.ToString() ?? string.Empty,
                cep: reader["cep"]?.ToString() ?? string.Empty,
                telefone: telefone,
                email: reader["email"]?.ToString() ?? string.Empty,
                nomeDoResponsavel: reader["nome_responsavel"]?.ToString() ?? string.Empty
            )
            {
                Id = Convert.ToInt32(reader["id"])
            };
        }

        private static object DbValue(string? value) => value ?? string.Empty;
    }
}

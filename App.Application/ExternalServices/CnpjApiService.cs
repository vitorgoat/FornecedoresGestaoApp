using System.Text.RegularExpressions;
using App.Domain.Entities;
using Newtonsoft.Json;

namespace App.ApplicationServices.ExternalServices
{
    public class CnpjApiService
    {
        public async Task<Fornecedor?> ConsultarPorCnpj(string cnpj)
        {
            cnpj = Regex.Replace(cnpj ?? "", @"[^\d]", "");

            using var client = new HttpClient();
            var response = await client.GetAsync($"https://www.receitaws.com.br/v1/cnpj/{cnpj}");

            if (!response.IsSuccessStatusCode)
                return null;

            var json = await response.Content.ReadAsStringAsync();
            var dados = JsonConvert.DeserializeObject<dynamic>(json);

            if (dados == null || (string?)(dados?.status ?? string.Empty) != "OK")
                return null;

            return Fornecedor.CriarViaCnpjApi(
                (string?)(dados?.nome ?? string.Empty) ?? string.Empty,
                Regex.Replace((string?)(dados?.cnpj ?? string.Empty) ?? string.Empty, @"[^\d]", ""),
                (string?)(dados?.logradouro ?? string.Empty) ?? string.Empty,
                (string?)(dados?.numero ?? string.Empty) ?? string.Empty,
                (string?)(dados?.bairro ?? string.Empty) ?? string.Empty,
                (string?)(dados?.municipio ?? string.Empty) ?? string.Empty,
                (string?)(dados?.uf ?? string.Empty) ?? string.Empty,
                Regex.Replace((string?)(dados?.cep ?? string.Empty) ?? string.Empty, @"[^\d]", ""),
                (string?)(dados?.telefone ?? string.Empty) ?? string.Empty,
                (string?)(dados?.email ?? string.Empty) ?? string.Empty
            );
        }
    }
}

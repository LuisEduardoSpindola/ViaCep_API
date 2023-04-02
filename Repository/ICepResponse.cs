using Refit;
using ViaCep_API.Models;

namespace ViaCep_API.Repository
{
    public interface ICepResponse
    {
        [Get("/ws/{cep}/json/")]
        Task<CepResponse> GetAdressAsync(string cep);
    }
}

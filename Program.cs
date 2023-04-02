using Refit;
using System.Text.RegularExpressions;
using ViaCep_API.Repository;

namespace ViaCep_API
{
    public class Program
    {
        static async Task Main() 
        {
            try 
            {
                Console.WriteLine("--- VIA_CEP_API ---");

                var ClientCep = RestService.For<ICepResponse>("https://viacep.com.br");
                Console.WriteLine("\nInforme seu Cep: ");

                var FirstClientResponse = Console.ReadLine().ToString();
                Console.WriteLine("Consultando Informações do infomado ... ");

                var FirstClientResponseFormated = Regex.Replace(FirstClientResponse, "-", "");

                var adress = await ClientCep.GetAdressAsync(FirstClientResponseFormated);

                Console.WriteLine($"\nLogradouro: {adress.Logradouro} \nBairro: {adress.Bairro} \nCidade: {adress.Localidade}");

                Console.WriteLine("Deseja Mais infomações sobre o Cep informado?: s/n");
                var SecondClientResponse = Console.ReadLine().ToString();

                if (SecondClientResponse == "s")
                {
                    Console.WriteLine($"\nUF: {adress.UF} \nDDD: {adress.DDD} \nIBGE: {adress.IBGE} \nSiafi: {adress.Siafi}");
                }
                else 
                {
                    Environment.Exit(0);
                }

            }catch(Exception) 
            {
                Console.WriteLine("Bad Request: Invalid Input");
                Console.WriteLine("\n Valid Input: 12345-678 or 12345678");
            }
        } 
    }
}

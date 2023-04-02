﻿using System.Text.Json.Serialization;

namespace ViaCep_API.Models
{
    public class CepResponse
    {
        [JsonPropertyName("cep")]
        public string Cep { get; set; }

        [JsonPropertyName("logradouro")]
        public string Logradouro { get; set; }

        [JsonPropertyName("complemento")]
        public string Complemento { get; set; }

        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }

        [JsonPropertyName("localidade")]
        public string Localidade { get; set; }

        [JsonPropertyName("uf")]
        public string UF { get; set; }

        [JsonPropertyName("ibge")]
        public string IBGE { get; set; }

        [JsonPropertyName("gia")]
        public string GIA { get; set; }

        [JsonPropertyName("ddd")]
        public string DDD { get; set; }

        [JsonPropertyName("siafi")]
        public string Siafi { get; set; }
    }
}



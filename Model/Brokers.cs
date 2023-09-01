using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IntegraBrasilApi.Model
{
    public class Brokers
    {
        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }

        [JsonPropertyName("cep")]
        public string Cep { get; set; }

        [JsonPropertyName("cnpj")]
        public string Cnpj { get; set; }

        [JsonPropertyName("codigo_cvm")]
        public string CodigoCvm { get; set; }

        [JsonPropertyName("complemento")]
        public string Complemento { get; set; }

        [JsonPropertyName("data_inicio_situacao")]
        public string DataInicioSituacao { get; set; }

        [JsonPropertyName("data_patrimonio_liquido")]
        public string DataPatrimonioLiquido { get; set; }

        [JsonPropertyName("data_registro")]
        public string DataRegistro { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("logradouro")]
        public string Logradouro { get; set; }

        [JsonPropertyName("municipio")]
        public string Municipio { get; set; }

        [JsonPropertyName("nome_social")]
        public string NomeSocial { get; set; }

        [JsonPropertyName("nome_comercial")]
        public string NomeComercial { get; set; }

        [JsonPropertyName("pais")]
        public string Pais { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("telefone")]
        public string Telefone { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("uf")]
        public string Uf { get; set; }

        [JsonPropertyName("valor_patrimonio_liquido")]
        public string ValorPatrimonioLiquido { get; set; }
    }
}
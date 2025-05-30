using System.Text.Json.Serialization;

namespace Target.Models
{
    public class FaturamentoDia
    {
        [JsonPropertyName("dia")]
        public int Dia { get; set; }

        [JsonPropertyName("valor")]
        public decimal Valor { get; set; }
    }
}
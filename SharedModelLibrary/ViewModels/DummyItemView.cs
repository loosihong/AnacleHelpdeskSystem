using System;
using System.Text.Json.Serialization;

namespace SharedModelLibrary
{
    public class DummyItemView
    {
        [JsonPropertyName(nameof(ID))]
        public Guid? ID { get; set; }
        [JsonPropertyName(nameof(Name))]
        public string Name { get; set; }
        [JsonPropertyName(nameof(Quantity))]
        public int? Quantity { get; set; }
        [JsonPropertyName(nameof(UnitCost))]
        public decimal? UnitCost { get; set; }
    }
}

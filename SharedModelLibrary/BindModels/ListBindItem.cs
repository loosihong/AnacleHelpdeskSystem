using System.Text.Json.Serialization;

namespace SharedModelLibrary
{
    public struct ListBindItem<TValue>
    {
        [JsonPropertyName(nameof(Text))]
        public string Text { get; set; }
        [JsonPropertyName(nameof(Value))]
        public TValue Value { get; set; }

        public ListBindItem(string text, TValue value)
        {
            this.Text = text;
            this.Value = value;
        }
    }
}

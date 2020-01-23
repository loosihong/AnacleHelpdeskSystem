using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SharedModelLibrary
{
    public class DummyView
    {
        [JsonPropertyName(nameof(TextFieldValue))]
        public string TextFieldValue { get; set; }
        [JsonPropertyName(nameof(TextAreaValue))]
        public string TextAreaValue { get; set; }
        [JsonPropertyName(nameof(DateTimeValue))]
        public DateTime? DateTimeValue { get; set; }
        [JsonPropertyName(nameof(SelectStringValue))]
        public string SelectStringValue { get; set; }
        [JsonPropertyName(nameof(SelectIntValue))]
        public int? SelectIntValue { get; set; }
        [JsonPropertyName(nameof(RadioStringValue))]
        public string RadioStringValue { get; set; }
        [JsonPropertyName(nameof(RadioIntValue))]
        public int? RadioIntValue { get; set; }
        [JsonPropertyName(nameof(CheckboxStringValues))]
        public List<string> CheckboxStringValues { get; set; }
        [JsonPropertyName(nameof(CheckboxIntValues))]
        public List<int?> CheckboxIntValues { get; set; }
        [JsonPropertyName(nameof(DummyItems))]
        public List<DummyItemView> DummyItems { get; set; }

        public DummyView()
        {
            this.DummyItems = new List<DummyItemView>();
        }
    }
}

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SharedModelLibrary
{
    public class DrawerBindItem
    {
        [JsonPropertyName(nameof(Identifier))]
        public string Identifier { get; set; }
        [JsonPropertyName(nameof(Text))]
        public string Text { get; set; }
        [JsonPropertyName(nameof(IconName))]
        public string IconName { get; set; }
        [JsonPropertyName(nameof(Url))]
        public string Url { get; set; }
        [JsonPropertyName(nameof(ParentIdentifier))]
        public string ParentIdentifier { get; set; }
        [JsonPropertyName(nameof(IsClickable))]
        public bool IsClickable { get; set; }

        public List<DrawerBindItem> Children { get; set; }

        public DrawerBindItem() { }

        public DrawerBindItem(string identifier, string text, string iconName, string url, string parentIdentifier,
            bool isClickable)
        {
            this.Identifier = identifier;
            this.Text = text;
            this.IconName = iconName;
            this.Url = url;
            this.ParentIdentifier = parentIdentifier;
            this.IsClickable = isClickable;
        }
    }
}

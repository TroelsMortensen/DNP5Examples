using System.Text.Json;
using System.Text.Json.Serialization;

namespace JSON
{
    public class MyJsonObject
    {
        public int Number { get; set; }
        public string Text { get; set; }
        public string[] ManyStrings { get; set; }
        public bool B { get; set; }
        
        [JsonIgnore] public string ThisIsIgnored { get; set; }

        public OtherObj OtherObj { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions
            {
                WriteIndented = true
            });
        }
    }
}
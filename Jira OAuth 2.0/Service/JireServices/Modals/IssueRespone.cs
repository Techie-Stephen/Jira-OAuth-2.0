using Newtonsoft.Json;

namespace Jira_OAuth_2._0.JireServices
{
    public class IssueRespone
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("self")]
        public string Self { get; set; }
    }
}
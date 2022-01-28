using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jira_OAuth_2._0.JireServices
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AvatarUrls
    {
        public string _48x48 { get; set; }
        public string _24x24 { get; set; }
        public string _16x16 { get; set; }
        public string _32x32 { get; set; }
    }

    public class Properties
    {
    }

    public class ProjectData
    {
        public string expand { get; set; }
        public string self { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public AvatarUrls avatarUrls { get; set; }
        public string projectTypeKey { get; set; }
        public bool simplified { get; set; }
        public string style { get; set; }
        public bool isPrivate { get; set; }
        public Properties properties { get; set; }
        public string entityId { get; set; }
        public string uuid { get; set; }
    }
}

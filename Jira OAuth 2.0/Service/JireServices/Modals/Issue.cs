using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jira_OAuth_2._0.JireServices
{
    public class Issue
    {
        public Fields fields { get; set; }
    }
    public class Fields
    {
        public Project project { get; set; }
        public string summary { get; set; }
        public Issuetype issuetype { get; set; }
    }

    public class Project
    {
        public string key { get; set; }
    }

    public class Issuetype
    {
        public int id { get; set; }
    }

}

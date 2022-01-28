using Jira_OAuth_2._0.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Jira_OAuth_2._0.JireServices
{
    public class JireService
    {
        public string AccessToken { get; set; }
        public string GetToken(string code)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "https://auth.atlassian.com/oauth/token");

            var jsonData = JsonConvert.SerializeObject(
                new
                {
                    grant_type = "authorization_code",
                    client_id = AppConstants.Client_ID,
                    client_secret = AppConstants.Client_SEC,
                    code = code,
                    redirect_uri = AppConstants.RedirectUrl
                });

            request.Content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var response = client.SendAsync(request).Result.Content.ReadAsStringAsync().Result;

                var res = JsonConvert.DeserializeObject<AuthTokenRespone>(response);

                var token = res.AccessToken;

                if (!string.IsNullOrEmpty(token))
                {
                    AccessToken = token;
                    return token;
                }
            }

            return null;

        }

        public void GetProjects()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://api.atlassian.com/ex/jira/23bf82a7-06b2-496c-8e27-b0e68a939b96/rest/api/3/project");

            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);


            using (var client = new HttpClient())
            {
                var response = client.SendAsync(request).Result;

                if (response.IsSuccessStatusCode)
                {
                    var res = response.Content.ReadAsStringAsync().Result;
                }

                //var res = JsonConvert.DeserializeObject<AuthTokenRespone>(response);
            }

        }

        public bool SubmitIssue(string summary, string issueType)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "https://api.atlassian.com/ex/jira/23bf82a7-06b2-496c-8e27-b0e68a939b96/rest/api/3/issue");
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);

            var fields = new Fields()
            {
                project = new Project() { key = AppConstants.PROJECT_KEY },
                summary = summary,
                issuetype = new Issuetype() { id = GetIssueID(issueType) },

            };

            if (fields != null)
            {
                var issue = new Issue()
                {
                    fields = fields
                };

                var jsonData = JsonConvert.SerializeObject(issue);

                request.Content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                using (var client = new HttpClient())
                {
                    var response = client.SendAsync(request).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var res = JsonConvert.DeserializeObject<IssueRespone>(response.Content.ReadAsStringAsync().Result);
                        if (res != null)
                        {
                            return true;
                        }
                    }

                }
            }

            return false;
        }

        public int GetIssueID(string issueType)
        {
            var issueID = 1;

            if (issueType == "Epic")
            {
                issueID = 10004;
            }
            else if (issueType == "Bug")
            {
                issueID = 10003;
            }
            else if (issueType == "Story")
            {
                issueID = 10001;
            }
            else if (issueType == "Task")
            {
                issueID = 10002;
            }
            else if (issueType == "Subtask")
            {
                issueID = 10005;
            }

            return issueID;
        }
    }
}

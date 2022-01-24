using Jira_OAuth_2._0.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Jira_OAuth_2._0
{
    internal class GetAccessToken
    {
        public string GetToken( string code)
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
                    return token;
                }
            }

            return null;

        }
    }
}

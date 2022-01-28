using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jira_OAuth_2._0
{
    public class AppConstants
    {
        public static string RedirectUrl = "Http://localhost:33007/";
        public static string APP_ID = "1bafe816-a9d5-4e27-b7ec-25b1231ce1a6";
        public static string Client_ID = "GigycDkAoekjEuGxRBc54RSYdqfgQ10o";
        public static string Client_SEC = "ckf2G3CdTQGEjf9ixQ3b5zwchdgmDRXPjv4T3SYJUZ5DlajRZ4neKe3oYck1VS-A";
        public static string YOUR_USER_BOUND_VALUE = "";
        //public static string JiraConnectionUrl = $"https://auth.atlassian.com/authorize?audience=api.atlassian.com&client_id=GigycDkAoekjEuGxRBc54RSYdqfgQ10o&scope=read%3Ajira-user&redirect_uri=Http%3A%2F%2Flocalhost%3A33007%2F&state=${YOUR_USER_BOUND_VALUE}&response_type=code&prompt=consent";
        public static string JiraConnectionUrl = $"https://auth.atlassian.com/authorize?audience=api.atlassian.com&client_id=GigycDkAoekjEuGxRBc54RSYdqfgQ10o&scope=read%3Ajira-user%20write%3Ajira-work%20read%3Ajira-work%20manage%3Ajira-webhook%20manage%3Ajira-project%20manage%3Ajira-data-provider%20manage%3Ajira-configuration&redirect_uri=Http%3A%2F%2Flocalhost%3A33007%2F&state={YOUR_USER_BOUND_VALUE}&response_type=code&prompt=consent";
    }
}

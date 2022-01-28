using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Jira_OAuth_2._0.JireServices;

namespace Jira_OAuth_2._0
{
    public partial class Login : Form
    {
        public static string AccessToken = "";

        public Login()
        {
            InitializeComponent();
        }

        public async Task JiraLogin()
        {
            HttpListener listener = new HttpListener();
            Process browserProcess = null;

            if (listener == null)
            {
                listener = new HttpListener();
            }
            else
            {
                if (listener.IsListening)
                {
                    listener.Stop();
                    listener.Abort();
                }
                listener = new HttpListener();
            }

            listener.Prefixes.Add(AppConstants.RedirectUrl);
            listener.Start();

            browserProcess = new Process();
            browserProcess.StartInfo.FileName = AppConstants.JiraConnectionUrl;
            browserProcess.StartInfo.UseShellExecute = true;
            browserProcess.StartInfo.Verb = "";
            browserProcess.Start();

            var processName = browserProcess.ProcessName;

            var context = listener.GetContext();
            var response = context.Response;

            var code = context.Request.QueryString.Get("code");

            string responseString = string.Format("<html><head></head><body><h1>Login Successful</h1></body><html>");
            var buffer = Encoding.UTF8.GetBytes(responseString);
            response.ContentLength64 = buffer.Length;

            var responseOutput = response.OutputStream;

            Task responseTask = responseOutput.WriteAsync(buffer, 0, buffer.Length).ContinueWith((task) =>
            {
                responseOutput.Close();
                listener.Stop();
                listener = null;
                browserProcess.Close();
            });

            var service = new JireService();
            AccessToken = service.GetToken(code);

            if (!string.IsNullOrEmpty(AccessToken))
            {
                Console.WriteLine(AccessToken);
                Close();
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
                lblError.Show();
            else
            {
                await JiraLogin();
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblError.Hide();
        }
    }
}

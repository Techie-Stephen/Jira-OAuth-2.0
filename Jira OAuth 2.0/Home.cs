using Jira_OAuth_2._0.JireServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jira_OAuth_2._0
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();

            var jira = new JireService();
            jira.GetProjects();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var Issue = cboProject.SelectedItem;
            var accessToken = Login.AccessToken;
            txtToken.Text = accessToken;

            if (!string.IsNullOrEmpty(accessToken))
            {
                if (!string.IsNullOrEmpty(txtIssue.Text) && !string.IsNullOrEmpty(cboProject.SelectedItem.ToString()))
                {
                    var jira = new JireService();
                    var result = jira.SubmitIssue(txtIssue.Text, cboProject.SelectedItem.ToString());

                    if (result)
                    {
                        MessageBox.Show("Ticket Created Successfully","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error Creating Ticket", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }
    }
}

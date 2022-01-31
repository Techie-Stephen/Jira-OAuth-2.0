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
        public List<ProjectData> Projects { get; set; }
        public static string AccessToken { get; set; } = Login.AccessToken;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //Login login = new Login();
            //login.ShowDialog();
            cboProject.Focus();
            cboProject.Items.Clear();
            cboProject.Sorted = true;

            var jira = new JiraService(AccessToken);
            Projects = jira.GetProjects();

            if (Projects != null)
            {
                foreach (var item in Projects)
                {
                    cboProject.Items.Add(item.name);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            if (!string.IsNullOrEmpty(txtIssue.Text) && !string.IsNullOrEmpty(cboIssue.SelectedItem.ToString()) && !string.IsNullOrEmpty(cboProject.SelectedItem.ToString()))
            {
                var project = Projects.FirstOrDefault(x => x.name == cboProject.SelectedItem.ToString());
                txtToken.Text = AccessToken;


                if (!string.IsNullOrEmpty(AccessToken))
                {
                    var jira = new JiraService(AccessToken);
                    var result = jira.SubmitIssue(txtIssue.Text, cboIssue.SelectedItem.ToString(), project.key.ToString());

                    if (result)
                    {
                        MessageBox.Show("Ticket Created Successfully", "Ticket Created Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Error Creating Ticket", "Error Creating Ticket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("All Fields are Required", "Invalid Data Provided", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ClearFields()
        {
            txtIssue.Text = "";
            cboProject.SelectedItem = "";
            cboIssue.SelectedItem = "";
        }

        private void CreateConversion_Click(object sender, EventArgs e)
        {
            var modal = new Conversion();
            modal.ShowDialog();
        }
    }
}

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
    public partial class Conversion : Form
    {
        public Conversion()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Conversion_Load(object sender, EventArgs e)
        {
            txtSummary.Focus();
        }

        private void txtSummary_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty("txtDescription.Text") && !string.IsNullOrEmpty(txtSummary.Text))
            {
                var jira = new JiraService(Home.AccessToken);
                var result = jira.SubmitEpic(txtSummary.Text, txtDescription.Text);

                if (result)
                {
                    MessageBox.Show("Epic Ticket with Issues Created Successfully", "Ticket Created Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Missing Fields are Required", "Please enter Ticket Summary and Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ClearFields()
        {
            txtSummary.Text = "";
            txtDescription.Text = "";
        }
    }
}

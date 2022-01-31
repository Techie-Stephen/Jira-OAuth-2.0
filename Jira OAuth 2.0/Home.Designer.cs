namespace Jira_OAuth_2._0
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIssue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboProject = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblToken = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboIssue = new System.Windows.Forms.ComboBox();
            this.CreateConversion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIssue
            // 
            this.txtIssue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssue.Location = new System.Drawing.Point(30, 215);
            this.txtIssue.Multiline = true;
            this.txtIssue.Name = "txtIssue";
            this.txtIssue.Size = new System.Drawing.Size(659, 152);
            this.txtIssue.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Summary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboProject
            // 
            this.cboProject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProject.FormattingEnabled = true;
            this.cboProject.Location = new System.Drawing.Point(30, 88);
            this.cboProject.Name = "cboProject";
            this.cboProject.Size = new System.Drawing.Size(254, 28);
            this.cboProject.TabIndex = 2;
            this.cboProject.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(530, 376);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(159, 44);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit Issue";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToken.Location = new System.Drawing.Point(12, 382);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(10, 16);
            this.lblToken.TabIndex = 4;
            this.lblToken.Text = ".";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(30, 464);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(659, 20);
            this.txtToken.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Issue Type";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboIssue
            // 
            this.cboIssue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIssue.FormattingEnabled = true;
            this.cboIssue.Items.AddRange(new object[] {
            "Epic",
            "Bug",
            "Story",
            "Task",
            "Subtask"});
            this.cboIssue.Location = new System.Drawing.Point(30, 150);
            this.cboIssue.Name = "cboIssue";
            this.cboIssue.Size = new System.Drawing.Size(254, 28);
            this.cboIssue.TabIndex = 2;
            this.cboIssue.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CreateConversion
            // 
            this.CreateConversion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CreateConversion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateConversion.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.CreateConversion.FlatAppearance.BorderSize = 0;
            this.CreateConversion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateConversion.Location = new System.Drawing.Point(541, 6);
            this.CreateConversion.Name = "CreateConversion";
            this.CreateConversion.Size = new System.Drawing.Size(148, 31);
            this.CreateConversion.TabIndex = 6;
            this.CreateConversion.Text = "Create Conversion";
            this.CreateConversion.UseVisualStyleBackColor = false;
            this.CreateConversion.Click += new System.EventHandler(this.CreateConversion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Create issue";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(715, 496);
            this.Controls.Add(this.CreateConversion);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.lblToken);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cboIssue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboProject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIssue);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIssue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboProject;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboIssue;
        private System.Windows.Forms.Button CreateConversion;
        private System.Windows.Forms.Label label4;
    }
}
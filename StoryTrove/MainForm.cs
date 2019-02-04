using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryTrove
{
    public partial class MainForm : Form
    {
        private TextBox emailTextBox;
        private TextBox pswdTextBox;
        private Button loginBtn;
        private Button guestBtn;
        private Button createBtn;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.pswdTextBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.guestBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(293, 179);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(157, 20);
            this.emailTextBox.TabIndex = 0;
            this.emailTextBox.Text = "E-mail";
            // 
            // pswdTextBox
            // 
            this.pswdTextBox.Location = new System.Drawing.Point(293, 205);
            this.pswdTextBox.Name = "pswdTextBox";
            this.pswdTextBox.Size = new System.Drawing.Size(157, 20);
            this.pswdTextBox.TabIndex = 1;
            this.pswdTextBox.Text = "Password";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(472, 179);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 46);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // guestBtn
            // 
            this.guestBtn.Location = new System.Drawing.Point(375, 261);
            this.guestBtn.Name = "guestBtn";
            this.guestBtn.Size = new System.Drawing.Size(75, 46);
            this.guestBtn.TabIndex = 3;
            this.guestBtn.Text = "View As Guest";
            this.guestBtn.UseVisualStyleBackColor = true;
            this.guestBtn.Click += new System.EventHandler(this.guestBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(292, 261);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(77, 46);
            this.createBtn.TabIndex = 4;
            this.createBtn.Text = "Create Account";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(843, 529);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.guestBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pswdTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {

        }

        private void guestBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

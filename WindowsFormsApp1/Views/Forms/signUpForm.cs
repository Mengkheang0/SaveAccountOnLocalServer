using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using publicAcountOnDataBase.ViewModels;

namespace WindowsFormsApp1.Views.Forms
{
    public partial class signUpForm : Form
    {
        CreateFile file = new CreateFile();
        string path = System.AppDomain.CurrentDomain.BaseDirectory;


        public signUpForm()
        {
            InitializeComponent();
            linkLb.Cursor = Cursors.Hand;
        }

        private void createBt_Click(object sender, EventArgs e)
        {
            if(usernameBox.Text != "" && passwordBox.Text != "" && con_password.Text != "")
            {
                if(passwordBox.Text == con_password.Text)
                {
                    DataSecurity secure = new DataSecurity();
                    var test = secure.FullCheck(usernameBox.Text, passwordBox.Text);

                    if (test)
                    {
                        MessageBox.Show("ACCESS");
                        /*List<string> PersonData = new List<string>() { usernameBox.Text, passwordBox.Text, con_password.Text };
                        file.AddDataToFile("LogIn_Data", usernameBox.Text, PersonData);

                        //Open mainform
                        Views.Forms.mainPageForm mainFrm = new mainPageForm();
                        publicAcountOnDataBase.Models.ClosingForm close = new publicAcountOnDataBase.Models.ClosingForm();
                        close.ClosingFormOnThread(this, mainFrm);

                        MessageBox.Show("Account create success\t", "Information", MessageBoxButtons.OK);*/
                    }
                    
                }
                else
                {
                    MessageBox.Show("Confirm_Passwords didn't match Passwords!!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show("Please complete all fields", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkLb_Click(object sender, EventArgs e)
        {
            publicAcountOnDataBase.Models.ClosingForm close = new publicAcountOnDataBase.Models.ClosingForm();
            Forms.signInForm sign_in = new signInForm();

            close.ClosingFormOnThread(this, sign_in);
        }

        private void showPs_Click(object sender, EventArgs e)
        {
            if (showPs.Checked)
            {
                con_password.UseSystemPasswordChar = false;
                passwordBox.UseSystemPasswordChar = false;  
            }
            else
            {
                con_password.UseSystemPasswordChar = true;
                passwordBox.UseSystemPasswordChar = true;
            }
        }
    }
}

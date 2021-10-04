using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using publicAcountOnDataBase.ViewModels;

namespace WindowsFormsApp1.Views.Forms
{
    public partial class signInForm : Form
    {

        CreateFile cfile = new CreateFile();
        public signInForm()
        {
            InitializeComponent();

        }
        List<string> strDataFromFolder = new List<string>();
        bool succes;

        private void createBt_Click(object sender, EventArgs e)
        {
            string _allDataPath = @"C:\Users\2\Desktop\ResumeProject\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\LogIn_Data";
            succes = CheckInputWithFileData._CheckInputWithData(usernameBox.Text,passwordBox.Text, _allDataPath);

            if(succes)
            {
                Views.Forms.mainPageForm mainFrm = new mainPageForm();
                publicAcountOnDataBase.Models.ClosingForm close = new publicAcountOnDataBase.Models.ClosingForm();
                close.ClosingFormOnThread(this, mainFrm);

            }
         
            
        }

        private void linkLb_Click(object sender, EventArgs e)
        {
            publicAcountOnDataBase.Models.ClosingForm close = new publicAcountOnDataBase.Models.ClosingForm();
            Forms.signUpForm sign_up = new signUpForm();

            this.Invoke((MethodInvoker)(() => close.ClosingFormOnThread(this, sign_up)));
        }

        private void showPs_Click(object sender, EventArgs e)
        {
            if (showPs.Checked)
            {
                passwordBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordBox.UseSystemPasswordChar = true;
            }
        }
    }
}

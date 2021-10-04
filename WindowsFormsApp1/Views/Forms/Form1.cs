using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using publicAcountOnDataBase.ViewModels;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Calling out class libray
        FilterItems ft = new FilterItems();
        LoadDataFromFiles load = new LoadDataFromFiles();



        string path = @"C:\Users\2\Pictures\about\myData.txt";
        public Form1()
        {
            InitializeComponent();


        
            //load.WriteToData(path, new List<string>() { "Jork, 30, jorkfootball@gmail.com" });
            //ft.FilterControls(textBox1, listBox1, str);


        }
        List<string> str = new List<string>();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          /*  if(textBox1.Text != "")
            {
                listBox1.Items.Clear();
                foreach (var item in str)
                {
                    if (item.StartsWith(textBox1.Text))
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
            else
            {
                listBox1.Items.Clear();

                foreach (var item in str)
                {
                    listBox1.Items.Add(item);
                }
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* listBox1.Items.Clear();
            foreach (var item in load.ReadData(path))
            {
                listBox1.Items.Add(item);
            }*/
        }

        Views.Controls.AccountPlateForm acc;
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string path = @"D:\GIF\shimizu.gif";

            acc = new Views.Controls.AccountPlateForm(path,"Hata","Teacher",true);
            flowLayoutPanel1.Controls.Add(acc);
            
        }

    }
}

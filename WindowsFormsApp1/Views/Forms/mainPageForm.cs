using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views.Forms
{
    public partial class mainPageForm : Form
    {
        public mainPageForm()
        {
            InitializeComponent();
            Views.AcountSetting.User_Setting u = new AcountSetting.User_Setting(this.Left+100,0,"Panha","Panha","horser123",true);
            this.Controls.Add(u);

        }
    }
}

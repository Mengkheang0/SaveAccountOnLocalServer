using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views.AcountSetting
{
    public partial class User_Setting : UserControl
    {
        public User_Setting()
        {
            InitializeComponent();
        }
        public User_Setting(int x, int y,string userName1, string userName2, string password, bool active, string img = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7e/Circle-icons-profile.svg/768px-Circle-icons-profile.svg.png")
        {
            InitializeComponent();
            this.Location = new Point(x, y);
            this.userProfile.ImageLocation = img;

            this.userName.Text = userName1;
            this.userName_2.Text = userName2;
            this.passwords.Text = password;

            if (!active)
            {
                Status.FillColor = Color.Gray;
                Status.FillColor2 = Color.Gray;
            }
            else
            {
                Status.FillColor = Color.Green;
                Status.FillColor2 = Color.Green;

            }
        }
    }
}

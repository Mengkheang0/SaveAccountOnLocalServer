using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views.Controls
{
    public partial class AccountPlateForm : UserControl
    {
        public AccountPlateForm()
        {
            InitializeComponent();
        }
        public AccountPlateForm(string imagePath,string name,string occupy,bool Isactive)
        {
            InitializeComponent();
            this.picture.Image = Image.FromFile(imagePath);
            this.Username.Text = name;
            this.Occupy.Text = occupy;
            if (!Isactive)
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

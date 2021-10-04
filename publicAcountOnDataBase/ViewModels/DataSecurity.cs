using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace publicAcountOnDataBase.ViewModels
{
    public class DataSecurity
    {
        void CheckUserNameLength(string userName)
        {
            if(userName.Length < 8)
            {
                MessageBox.Show("You must have atleast 8 character with special character", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void CheckPasswordsLength(string passwords)
        {
            if (passwords.Length < 8)
            {
                MessageBox.Show("You must have atleast 8 character with special character", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool FullCheck(string userName,string passwords)
        {
           

            if(userName.Length<8 && passwords.Length < 8)
            {
                MessageBox.Show("You must have atleast 8 character with special character", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace publicAcountOnDataBase.ViewModels
{
    public static class CheckInputWithFileData
    {
        private static bool found;

        public static bool _CheckInputWithData(string userNameInput,string passwords,string _dataPath)
        {
            
            if(userNameInput.Length > 0)
            {
                string[] files = Directory.GetFiles(_dataPath);

                foreach (var file in files)
                {
                    if (userNameInput == Path.GetFileNameWithoutExtension(file))
                    {

                        string[] txts = File.ReadAllLines(file);

                        //index 1 is my passwords data
                        string Passwords = txts[1];
                        if(passwords == Passwords)
                        {
                            found = true;
                            break;

                        }

                    }
                    else
                    {
                        found = false;
                    }
                }

                if (found)
                {
                    MessageBox.Show("\tLogin succced !!\t", "information", MessageBoxButtons.OK);


                    return true;

                }
                else
                {
                    MessageBox.Show("Acount not found", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
            }
            else
            {
                MessageBox.Show("Please complete all fields", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            return false;
        }

    }
}

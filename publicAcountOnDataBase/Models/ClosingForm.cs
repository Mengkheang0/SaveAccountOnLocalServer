using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace publicAcountOnDataBase.Models
{
    public class ClosingForm
    {
        public void ClosingFormOnThread(Form closeForm,Form openForm)
        {
            closeForm.Close();
            Thread th = new Thread(nform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();


            void nform()
            {
                
                Application.Run(openForm);

            }


        }
        

    }
}

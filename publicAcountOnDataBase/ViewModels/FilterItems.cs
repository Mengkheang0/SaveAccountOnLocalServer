using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace publicAcountOnDataBase.ViewModels
{
    public class FilterItems
    {
        List<string> _backUpData = new List<string>();
        TextBox nTb = new TextBox();
        ListBox nLb = new ListBox();

        public void FilterControls(TextBox tb, ListBox lb,List<string> listItems)
        {
            nTb = tb;
            nLb = lb;
            tb.TextChanged += Tb_TextChanged;
        }

        private void Tb_TextChanged(object sender, EventArgs e)
        {
            if(nTb.Text != "")
            {
                nLb.Items.Clear();

                foreach (var item in _backUpData)
                {
                    if (item.StartsWith(nTb.Text))
                    {
                        nLb.Items.Add(item);
                    }
                }
            }
            else
            {
                nLb.Items.Clear();

                foreach (var item in _backUpData)
                {
                      nLb.Items.Add(item);
                }
            }
        }
    }
}

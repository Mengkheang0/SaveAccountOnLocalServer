using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
namespace publicAcountOnDataBase.ViewModels
{
    public class LoadDataFromFiles
    {
        public List<string> ReadData(string path)
        {
            List<string> myList = new List<string>();
            string[]  list = File.ReadAllLines(path);

            foreach (var item in list)
            {
                myList.Add(item);
            }

            return myList;
        }
        public void WriteToData(string path, List<string> Content)
        {
            //back up all text before re-write new file
            List<string> _backUpPreviusText = new List<string>();
            string[] list = File.ReadAllLines(path);

            foreach (var item in list)
            {
                _backUpPreviusText.Add(item);
            }


            //Add new text to old text (append)
            foreach (var item in Content)
            {
                _backUpPreviusText.Add(item);
            }

            //write Text
            File.WriteAllLines(path, _backUpPreviusText);
        }

    }
}

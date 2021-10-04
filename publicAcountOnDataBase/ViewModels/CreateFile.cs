using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;

namespace publicAcountOnDataBase.ViewModels
{
    public class CreateFile
    {
        public string UserDataPath { get; private set; }
        public void CreateFileInSpecificFolder(string folderName,string fileName)
        {
            //form : C:\Data\
            string localPath = System.AppDomain.CurrentDomain.BaseDirectory;
            string folderPath = localPath + folderName;
            //Create Directory
            Directory.CreateDirectory(folderPath);


            string FileTextLocation = folderPath + "\\" + fileName + ".txt";
            //Creat File
            File.CreateText(FileTextLocation);
        }
        public string AddDataToFile(string folderName,string fileName,List<string> Content)
        {
            //form : C:\Data\
            string localPath = System.AppDomain.CurrentDomain.BaseDirectory;
            string folderPath = localPath + folderName;
            //Create Directory
            Directory.CreateDirectory(folderPath);


            string FileTextLocation = folderPath + "\\" + fileName + ".txt";
            UserDataPath = FileTextLocation;
            //Creat File
            using (StreamWriter writer = new StreamWriter(FileTextLocation))
            {
                //write Text
                //Check is fileExist

                List<string> textFormat = new List<string>() { "Username : ","Password : ","Confirm_Password : "};
               
                for (int i = 0; i < Content.Count; i++)
                {
                    writer.WriteLine(Content[i]);

                }
            }

            return UserDataPath;   

           
        }

       
    }

}

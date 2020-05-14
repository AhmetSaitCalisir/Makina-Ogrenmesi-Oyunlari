using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazılım_Proje_Yönetimi
{
    class Class_MakeMeHappy
    {
        public List<string> NiceWords= new List<string>();
        public List<string> BadWords = new List<string>();
        public List<string> SmileyFaces = new List<string>();
        private List<string> SadFaces = new List<string>();

        public Class_MakeMeHappy()
        {
            NiceWords.Add("Love");
            NiceWords.Add("Cute");
            NiceWords.Add("Kind");
            NiceWords.Add("Cool");
            NiceWords.Add("Awesome");
            NiceWords.Add("Happy");
            NiceWords.Add("Nice");
            NiceWords.Add("Wonderful");
            NiceWords.Add("Beauty");

            BadWords.Add("Terrible");
            BadWords.Add("Awful");
            BadWords.Add("Wicked");
            BadWords.Add("Disgusting");
            BadWords.Add("Bad");
            BadWords.Add("Stupid");
            BadWords.Add("Poor");
            BadWords.Add("Evil");
            PictAdd();
        }

        public void PictAdd()
        {
            SmileyFaces.Add("../../Resimler_MMHappy/HappyFace.jpg");
            SmileyFaces.Add("../../Resimler_MMHappy/HappyFace2.jpg");
            SmileyFaces.Add("../../Resimler_MMHappy/HF3.jpg");
            SmileyFaces.Add("../../Resimler_MMHappy/HF4.jpg");
            SadFaces.Add("../../Resimler_MMHappy/sad.jpg");
            SadFaces.Add("../../Resimler_MMHappy/sad2.jpg");
            SadFaces.Add("../../Resimler_MMHappy/sad3.jpg");
            SadFaces.Add("../../Resimler_MMHappy/sad4.jpg");
        }

        public int WordCheck(string choice,int point)
        {
            foreach(string i in NiceWords)
            {
                if (i == choice)
                {
                    point = point + 1;
                }
            }
            

            foreach (string k in BadWords)
            {
                if (k == choice)
                {
                    point = point - 1;
                }
            }
            return point;
        }

        public void ChangePicture(int point,PictureBox picture)
        {
            switch (point)
            {
                case 0:
                    picture.ImageLocation = SmileyFaces[0];
                    break;
                case 1:
                    picture.ImageLocation = SmileyFaces[1];
                    break;
                case 2:
                    picture.ImageLocation = SmileyFaces[2];
                    break;
                case 3:
                    picture.ImageLocation = SmileyFaces[3];
                    break;
                case -1:
                    picture.ImageLocation = SadFaces[0];
                    break;


                case -2:
                    picture.ImageLocation = SadFaces[1];
                    break;
                case -3:
                    picture.ImageLocation = SadFaces[2];
                    break;
                case -4:
                    picture.ImageLocation = SadFaces[3];
                    break;
                default:
                    MessageBox.Show("Try again...");
                    break;

            }
        }
        
    }
}

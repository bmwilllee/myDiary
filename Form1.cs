using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Timers;

namespace exercise2
{
    public partial class Form1 : Form
    {
        public string titleChoose;
        public string timeChoose;
        public string textEdit;
        string Currentpath = System.Windows.Forms.Application.StartupPath; // obtain the current path;
        //string Currentpath = @"C:\Users\weigirl\Desktop";
        string target = @"\myDiary"; // the new directory name

        public class Diary // each diary as a object of Diary class
        {
            public string time;
            public string text;
            public string title;
            public string path;

            public Diary(string title) // constructor
            {
                this.title = title;
            }
            public void Delete(string path) // delete current choosen diary
            {
                File.Delete(path);
            }

            public void Save(string path) // save current edit or save new diary
            {
                if(path.IndexOf(".txt") != 1)
                {
                    path += ".txt";
                }
                if (File.Exists(path)) // judge weither this file is exist
                {
                    this.Delete(path);
                }
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write); // create new file and write
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(this.text);
                sw.Close();
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        public void listShow()
        {
            string path = string.Concat(Currentpath + target);
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            foreach (FileInfo NextFile in directoryInfo.GetFiles())
            {
                listBox.Items.Add(NextFile.Name);  // traverse the all files and show on the listBox
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = string.Concat(Currentpath + target);
            if (!Directory.Exists(path)) // judge weither there has such directory
            {
                Directory.CreateDirectory(path);
            }
            listShow();

        }

        public string OpenFile(string fileName)
        {
            string readText = "\t";
            StreamReader sr = new StreamReader(fileName);
            string line;
            while((line = sr.ReadLine()) != null){
                Console.WriteLine(line.ToString());
                readText += string.Concat(string.Concat(line, "\r\n"));
            }
            return readText;
        }

        private void NewDiary_Click(object sender, EventArgs e) // clean the title and editBox
        {
            TitleBox.Text = "";
            EditBox.Text = "";
            timer1.Start();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            titleChoose = TitleBox.Text;
            Diary diary = new Diary(titleChoose);
            diary.text = EditBox.Text;
            diary.Save(string.Concat(Currentpath, target, @"\", titleChoose));
        }

        //private void Delete_Click(object sender, EventArgs e)
        //{
        //    titleChoose = TitleBox.Text;
        //    Diary diary = new Diary(titleChoose);
        //    diary.Delete(string.Concat(Currentpath, target, @"\", titleChoose));
        //}

        private void Timer1_Tick(object sender, EventArgs e) // Show the current time
        {
            TimeBox.Text = DateTime.Now.ToString();
        }

        private void ListBox_Click(object sender, EventArgs e) // When click the saved diaries
        {
            string fileName = listBox.SelectedItem.ToString();
            Diary diary = new Diary(fileName);
            diary.text = OpenFile(string.Concat(Currentpath, target, @"\", fileName));
            TitleBox.Text = fileName;
            EditBox.Text = diary.text;
            FileInfo fi = new FileInfo(string.Concat(Currentpath, target, @"\", fileName));
            TimeBox.Text = fi.CreationTime.ToString();
            timer1.Stop();
        }

    }
}

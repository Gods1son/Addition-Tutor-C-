using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Addition_teacher
{
    class VM:INotifyPropertyChanged
    {
        Random r = new Random();
        public int Rand1
        {
            get { return _rand1; }
            set { _rand1 = value; OnPropertyChanged(); }
        }
        private int _rand1;
        public int Rand2
        {
            get { return _rand2; }
            set { _rand2 = value; OnPropertyChanged(); }
        }
        private int _rand2;
        public int Addition
        {
            get { return _addition; }
            set { _addition = value; OnPropertyChanged(); }
        }
        private int _addition;
        public VM()
        {
            Generate();
        }
        public void Generate()
        {           
            Rand1 = r.Next(100, 501);
            Rand2 = r.Next(100, 501);
            
        }
        public void docalc()
        {
            int Add = Rand1 + Rand2;
            if (Addition == Add)
            {
                System.Windows.MessageBox.Show("Congrats, U are Right!!!");
                Generate();
                Addition = 0;
            }
            else if (Addition != Add)
            {
                System.Windows.MessageBox.Show("Wrong, Try Again");
            }
        }
        public void Reveal()
        {
            int Add = Rand1 + Rand2;
            System.Windows.MessageBox.Show(Add.ToString());
            Generate();
            Addition = 0;
        }
        public string DIRNAME = "Tutor";
        public string filename = "question.txt";
        public void Save()
        {
            int Add = Rand1 + Rand2;
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string fullpath = Path.Combine(path, DIRNAME);
            Directory.CreateDirectory(fullpath);
            string fullname = Path.Combine(fullpath, filename);
            StreamWriter sw = File.AppendText(fullname);
            sw.WriteLine(Rand1.ToString() + "+" );
            sw.WriteLine(Rand2.ToString());
            sw.WriteLine("Your answer was " + (Addition.ToString()));
            sw.WriteLine("Correct answer is " + (Add.ToString()));
            sw.Close();
        }
            

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

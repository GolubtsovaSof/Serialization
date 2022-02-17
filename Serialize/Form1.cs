using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialize
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            All_lists_of_students all = new All_lists_of_students();


        }
        [Serializable]
        public class All_lists_of_students
        {
            public List_of_students LOF;
            public All_lists_of_students()
            { }

            public All_lists_of_students(List_of_students lof)
            {
                LOF = lof;
            }
        }
        [Serializable]
        public class List_of_students
        {
            public string Name_of_list;
            public List<Student> list;

            public List_of_students(string name, List<Student> stud)
            {
                Name_of_list = name;
                list = stud;
            }
        }
        [Serializable]
        public class Student
        {
            public string Name;
            public int Age;
            public int Group;
            public string Img_path;

            public Student()
            { }

            public Student(string name, int age, int group, string path)
            {
                Name = name;
                Age = age;
                Group = group;
                Img_path = path;
            }
        }
    }
}

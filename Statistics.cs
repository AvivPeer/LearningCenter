using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningCenter
{
    public partial class Statistics : Form
    {
        DBManager dBManager = new DBManager();

        public Statistics()
        {
            InitializeComponent();
        }
        public void clearAll()
        {
            ninLst.Items.Clear();
            tenLst.Items.Clear();
            elevLst.Items.Clear();
            twelLst.Items.Clear();
        }
        private void classLst_SelectedValueChanged(object sender, EventArgs e)
        {
            clearAll();
            if (subTBox.SelectedItem == null)
            {
                return;
            }

            List<Student> poorStudents = new List<Student>();
            poorStudents = dBManager.GetPoorStudents(((Subject)subTBox.SelectedItem).getName());
            foreach (Student student in poorStudents)
            {
                switch (student.getClassLevel())
                {
                    case 9:
                        ninLst.Items.Add(student);
                        break;
                    case 10:
                        tenLst.Items.Add(student);
                        break;
                    case 11:
                        elevLst.Items.Add(student);
                        break;
                    case 12:
                        twelLst.Items.Add(student);
                        break;
                }
            }


        }
        public void OneTimeRun()
        {
            List<Subject> subjects = new List<Subject>();
            subjects = dBManager.getAllSubjectsAvailable();
            foreach (Subject subject in subjects)
            {
                subTBox.Items.Add(subject);
            }
        }
        private void Statistics_Load(object sender, EventArgs e)
        {
            OneTimeRun();
        }
    }
}

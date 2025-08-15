using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LearningCenter

{
    public partial class StudentsForm : Form
    {
        DBManager dBManager = new DBManager();
        public StudentsForm()
        {
            InitializeComponent();


        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {

        }

        private void stdListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            stdListBox.Items.Clear();
            List<Student> students = new List<Student>();
            students = dBManager.GetStudentsByClass(LcManager.convertClassToInt(classSelect.Text));
            foreach (Student student in students)
            {

                stdListBox.Items.Add(student);
            }

        }
        public void clearAll()
        {
            // stdListBox.Items.Clear();
            weakLst.Items.Clear();
            teachName.Text = "";
            instructorName.Text = "";
            teachPhone.Text = "";
            instructorPhone.Text = "";
            subLst.Items.Clear();
            TeachCmtBox.Text = "";
            visitCnt.Text = "";
        }
        private void stdListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            clearAll();
            if (stdListBox.SelectedItem == null)
            {
                return;
            }
            Student student = dBManager.GetStudentById(((Student)stdListBox.SelectedItem).getstdId()); // Items on the list are students;
            Teacher teacher = dBManager.GetTeacherById(student.getTeacherId());
            teachName.Text = teacher.getName();
            teachPhone.Text = teacher.getPhoneNumber();
            List<Subject> poorSubjects = new List<Subject>();
            poorSubjects = dBManager.GetPoorSubjectsByStdID(student.getId());
            foreach (Subject subject in poorSubjects)
            {

                weakLst.Items.Add(subject.getName());
            }
            List<Comments> comments = new List<Comments>();

            List<Subject> allSubjects = new List<Subject>();
            allSubjects = dBManager.GetAllSubjectsByStdID(student.getId());
            foreach (Subject subject in allSubjects)
            {
                subLst.Items.Add(subject.getName());
            }

            comments = dBManager.getTeacherCmntsByStdID(student.getId());
            foreach (Comments comment in comments)
            {
                //  teacherComments.Items.Add(comment.getCmText());
                TeachCmtBox.Text += comment.getCmText() + "\n";
            }

            visitCnt.Text = student.getCenterVisits().ToString();


        }

        private void subLst_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}

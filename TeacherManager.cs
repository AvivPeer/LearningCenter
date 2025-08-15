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
    public partial class TeacherManager : Form
    {
        DBManager dBManager = new DBManager();
        public TeacherManager()
        {
            InitializeComponent();
        }
        public void clearAll()
        {
            allStds.Items.Clear();
            curStds.Items.Clear();
            nameTbox.Text = "";
            salaryTbox.Text = "";
            phoneTBox.Text = "";
            stdCmnt.Items.Clear();
            newCmnt.Text = "";

        }
        public bool validation()
        {
            if (teachPhTBox.Text == "")
            {
                MessageBox.Show("הזן מספר טלפון לחיפוש מורה");
                return false;
            }
            return true;
        }
        public void refreshData()
        {
            if (!validation())
            {
                return;
            }

            Teacher teacher = new Teacher();
            teacher = dBManager.GetTeacherByPhone(teachPhTBox.Text);
            if (teacher == null)
            {
                MessageBox.Show("לא נמצא מורה");
                return;
            }

            List<Student> students = new List<Student>();
            students = dBManager.GetAllStudents();
            foreach (Student student in students)
            {
                allStds.Items.Add(student);
            }
            List<Student> curStudents = new List<Student>();
            curStudents = dBManager.GetStudentsByTeacher(teacher);
            foreach (Student curStudent in curStudents)
            {
                curStds.Items.Add(curStudent);
            }

            salaryTbox.Text = teacher.getSalary().ToString();
            nameTbox.Text = teacher.getName().ToString();
            phoneTBox.Text = teacher.getPhoneNumber().ToString();
        }
        private void findTeachBtn_Click(object sender, EventArgs e)
        {
            refreshData();

        }

        private void TeacherManager_Load(object sender, EventArgs e)
        {

        }

        public bool addDeleteStd(string choice)
        {
            Teacher teacher = new Teacher();
            teacher = dBManager.GetTeacherByPhone(teachPhTBox.Text);
            Student student = new Student();
            if (choice == "remove")
                student = (Student)curStds.SelectedItem;
            else
                student = (Student)allStds.SelectedItem;
            if (student == null)
            {
                if (choice == "remove")
                    MessageBox.Show("לא נבחר סטודנט למחיקה");
                else
                    MessageBox.Show("לא נבחר סטודנט להוספה");
                return false;
            }
            if (!validation())
            {
                return false;
            }
            switch (choice)
            {
                case "remove":
                    student.setTeacherId(1); // 1 is the Base and represents not teacher for a student;
                    dBManager.UpdateStudent(student);
                    clearAll();
                    refreshData();
                    return true;
                case "add":
                    foreach (Student std in curStds.Items)
                    {
                        if (student.getstdId() == std.getstdId())
                        {
                            MessageBox.Show("התלמיד כבר שייך למורה");
                            return false;
                        }
                    }
                    student.setTeacherId(teacher.getId()); // 1 is the Base and represents not teacher for a student;
                    dBManager.UpdateStudent(student);
                    clearAll();
                    refreshData();
                    return true;

            }
            return false;

        }
        private void removeStd_Click(object sender, EventArgs e)
        {

            if (addDeleteStd("remove"))
            {
                MessageBox.Show("תלמיד נמחק בהצלחה");
                return;

            }
            else
            {
                MessageBox.Show("שגיאה");
            }

        }

        private void addStd_Click(object sender, EventArgs e)
        {

            if (addDeleteStd("add"))
            {
                MessageBox.Show("תלמיד נוסף בהצלחה");
                return;

            }
            else
            {
                MessageBox.Show("שגיאה");
            }


        }
        public void getCurComments()
        {
            stdCmnt.Items.Clear();
            List<Comments> comments = new List<Comments>();
            comments = dBManager.getTeacherCmntsByStdID(((Student)curStds.SelectedItem).getId());
            foreach (Comments c in comments)
            {
                stdCmnt.Items.Add(c);
            }
        }
        private void curStds_SelectedValueChanged(object sender, EventArgs e)
        {
            stdCmnt.Items.Clear();
            if (curStds.SelectedItem == null)
            {
                return;
            }

            getCurComments();

        }

        private void removeCmtBtn_Click(object sender, EventArgs e)
        {
            dBManager.DeleteComment((Comments)stdCmnt.SelectedItem);
            getCurComments();

        }

        private void newCmntBtn_Click(object sender, EventArgs e)
        {

            if (!validation())
            {
                return;
            }
            Teacher teacher = new Teacher();
            teacher = dBManager.GetTeacherByPhone(teachPhTBox.Text);

            Student student = new Student();
            if (curStds.SelectedItem == null)
            {
                MessageBox.Show("לא נבחר תלמיד לקבלת הערה");
                return;
            }
            student = (Student)curStds.SelectedItem;

            dBManager.AddTeacherComment(teacher, student, newCmnt.Text);
            getCurComments();
            newCmnt.Text = "";
        }
        public void createUpdate(string choice)
        {

        }
        private void Save_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();

            if (!validation())
            {

                if (nameTbox.Text == "")
                {
                    MessageBox.Show("אנא בחר שם");
                    return;
                }
                if (phoneTBox.Text == "")
                {
                    MessageBox.Show("אנא הזן מספר טלפון");
                    return;
                }
                if (salaryTbox.Text == "")
                {
                    MessageBox.Show("הזן שכר");
                    return;

                }


            }
            teacher = dBManager.GetTeacherByPhone(teachPhTBox.Text);
            teacher.setName(nameTbox.Text);
            teacher.setPhoneNumber(phoneTBox.Text);
            teacher.setSalary(int.Parse(salaryTbox.Text));
            dBManager.UpdateTeacher(teacher);


        }

        private void newTeachButton_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();


                if (nameTbox.Text == "")
                {
                    MessageBox.Show("אנא בחר שם");
                    return;
                }
                if (phoneTBox.Text == "")
                {
                    MessageBox.Show("אנא הזן מספר טלפון");
                    return;
                }
                if (salaryTbox.Text == "")
                {
                    MessageBox.Show("הזן שכר");
                    return;

                }


            Teacher tempTeach = new Teacher();
            if(dBManager.GetTeacherByPhone(phoneTBox.Text) != null)
            {
                MessageBox.Show("מורה כבר קיים במערכת!");
                return;
            }
            teacher.setName(nameTbox.Text);
            teacher.setPhoneNumber(phoneTBox.Text);
            teacher.setSalary(int.Parse(salaryTbox.Text));
            dBManager.AddTeacher(teacher);


        }
    
    }
}

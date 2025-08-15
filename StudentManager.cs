using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LearningCenter
{
    public partial class StudentManager : Form
    {
        DBManager dBManager = new DBManager();
        public StudentManager()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            subLst.Items.Clear();
            curSubLst.Items.Clear();
            curTeachLst.Items.Clear();
            teachLst.Items.Clear();
            nameTbox.Text = "";
            phoneTBox.Text = "";
            clastTbox.Text = "";
            visitCount.Text = "0";
        }
        public void getStudentData()
        {
            Student student = new Student();
            student = dBManager.GetStudentById(stdIdTBox.Text);
            if (student == null)
            {
                MessageBox.Show("תלמיד לא נמצא");
                return;
            }
            nameTbox.Text = student.getName();
            phoneTBox.Text = student.getStudentPhone();
            clastTbox.Text = student.getClassLevel().ToString();
            List<Teacher> teachers = new List<Teacher>();
            teachers = dBManager.GetAllTeachers();
            foreach (Teacher teacher in teachers)
            {

                teachLst.Items.Add(teacher);
            }
            Teacher curTeach = new Teacher();
            curTeach = dBManager.GetTeacherById(student.getTeacherId());
            curTeachLst.Items.Add(curTeach);
            List<Subject> allSubjects = new List<Subject>();
            allSubjects = dBManager.getAllSubjectsAvailable();
            foreach (Subject subject in allSubjects)
            {
                subLst.Items.Add(subject);
            }
            List<Subject> curSubjects = new List<Subject>();
            curSubjects = dBManager.GetAllSubjectsByStdID(student.getId());
            foreach (Subject subject in curSubjects)
            {
                curSubLst.Items.Add(subject);
            }
            visitCount.Text = (student.getCenterVisits()).ToString();
        }
        private void findStdBtn_Click(object sender, EventArgs e)
        {

            getStudentData();
        }

        private void subLst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void changeTeachBtn_Click(object sender, EventArgs e)
        {
            if (stdIdTBox.Text != "")
            {
                Student student = new Student();
                student = dBManager.GetStudentById(stdIdTBox.Text);
                if (student == null)
                {
                    return;
                }
                if (teachLst.SelectedItem != null)
                {
                    student.setTeacherId(((Teacher)teachLst.SelectedItem).getId());
                    dBManager.UpdateStudent(student);
                }
                clearAll();
                getStudentData();
            }
        }

        private void addSubBtn_Click(object sender, EventArgs e)
        {

            Student student = new Student();
            student = dBManager.GetStudentById(stdIdTBox.Text);
            if (!stdValidationCheck())
            {
                return;
            }
            if (statusSelection.SelectedItem == null)
            {
                MessageBox.Show("אנא בחר את הרמה במקצוע");
                return;
            }


            if (subLst.SelectedItem != null)
            {
                foreach (Subject subject in curSubLst.Items)
                {
                    if (subject.getName() == ((Subject)subLst.SelectedItem).getName())
                    {
                        MessageBox.Show("התלמיד כבר לומד מקצוע זה, אנה בחר מקצוע אחר");
                        return;
                    }
                }
                if (!dBManager.AddStudentSubject(student, (Subject)subLst.SelectedItem, statusSelection.SelectedItem.ToString()))
                {
                    MessageBox.Show("Failed to add subject");
                    return;
                }
                dBManager.UpdateStudent(student);

                clearAll();
                getStudentData();
            }
        }
        public bool stdValidationCheck()
        {
            if (stdIdTBox.Text != "")
            {
                Student student = new Student();
                student = dBManager.GetStudentById(stdIdTBox.Text);
                if (student == null)
                {
                    MessageBox.Show("לא נבחר תלמיד , אנא הזן תעודת זהות ולחץ על חפש תלמיד");
                    return false;
                }
                return true;
            }
            return false;
        }
        private void removeSubBtn_Click(object sender, EventArgs e)
        {
            if (!stdValidationCheck())
            {
                return;
            }
            Student student = new Student();
            student = dBManager.GetStudentById(stdIdTBox.Text);
            if (curSubLst.SelectedItem == null)
            {
                MessageBox.Show("לא בחרת מקצוע למחיקה");
                return;
            }
            dBManager.DeleteStudentSubject(student, (Subject)curSubLst.SelectedItem);
            clearAll();
            getStudentData();

        }
        public bool saveStudent(string Choice)
        {

            Student newstudent = new Student();
            if (clastTbox.Text != "9" && clastTbox.Text != "10" && clastTbox.Text != "11" && clastTbox.Text != "12")
            {
                MessageBox.Show("אנא בחר את הכיתה בפורמט הנכון");
                return false;
            }
            if (nameTbox.Text == "")
            {
                MessageBox.Show("אנא בחר שם");
                return false;
            }
            if (phoneTBox.Text == "")
            {
                MessageBox.Show("אנא הזן מספר טלפון");
                return false;
            }
            if (stdIdTBox.Text == "")
            {
                MessageBox.Show("הזן תעודת זהות"); //  To Implement , Validation for ID;
            }
            int parsedValue;
            if (int.TryParse(visitCount.Text, out parsedValue))
            {
                newstudent.setCenterVisits(parsedValue);
            }
            newstudent.setstdId(stdIdTBox.Text);
            newstudent.setName(nameTbox.Text);
            newstudent.setStudentPhone(phoneTBox.Text);
            newstudent.setClasLevel(int.Parse(clastTbox.Text));
            switch (Choice)
            {
                case "update":
                    dBManager.UpdateStudent(newstudent);
                    break;
                case "add":
                    dBManager.AddStudent(newstudent);
                    break;

            }
            
            clearAll();
            getStudentData();
            return true;
        }
        private void newStdButton_Click(object sender, EventArgs e)
        {

            if (saveStudent("add"))
            {
                MessageBox.Show("תלמיד נוסף בהצלחה");
            }

            

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (saveStudent("update"))
            {
                MessageBox.Show("תלמיד עודכן בהצלחה");
            }
        }
    }
}

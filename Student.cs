using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCenter
{

    internal class Student
    {
        private int Id; // Sql ID
        private string Name;
        private  string studentId; //Student Identification number
        private  string studentPhone;
        private  int ClassLevel;
        private int CenterVists;
        private int TeacherId;
        private List<Subject> subjectIds;
        private DateTime? LastVisitDate;
        private DateTime CreatedAt;
        string Comments;

        public Student() // Basic Constructor for student
        {
            Id = 0;
            studentId = "";
            Name = "";
            studentPhone = "none";
            ClassLevel = 0;
            CenterVists = 0;
            TeacherId = 1;
            LastVisitDate = null;
            CreatedAt = DateTime.Now;
            Comments = "";
            subjectIds = new List<Subject>();

        }

        public Student(string name,string stdId,int classLv)
        {
            studentId = stdId;
            Name = name;
            studentPhone = "none";
            ClassLevel = classLv;
            CenterVists = 0;
            TeacherId = 0;
            LastVisitDate = null;
            CreatedAt = DateTime.Now;
            Comments = "";
            subjectIds = new List<Subject>();
        }

        public void updateCmnt(string comment)
        {
            this.Comments= comment; ;
        }
        public string getCmnt()
        {
            return this.Comments;
        }
        public DateTime? getLastVisitDate()
        {
            return LastVisitDate;
        }
        public string getstdId()
        {
            return studentId;
        }
        public string getName()
        {
            return Name;
        }
        public string getStudentPhone()
        {
            return studentPhone;
        }
        public int getClassLevel()
        {
            return ClassLevel;
        }
        public int getCenterVisits()
        {
            return CenterVists;
        }
        public DateTime? getLatestVisit()
        {
            return LastVisitDate;
        }
        public void setId(int id)
        {
            Id = id;

        }
        public int getTeacherId()
        {
            return TeacherId;
        }
        public int getId()
        {
            return Id;
        }
        public void setstdId(string stdId)
        {
            studentId = stdId;
        }
        public void setName(string newName)
        {
            Name = newName;
        }
        public void setStudentPhone(string phone)
        {
            studentPhone = phone;
        }
        public void setClasLevel(int classLv)
        {
            ClassLevel = classLv;

        }
        public void setTeacherId(int teacherId)
        {
            this.TeacherId= teacherId; 
        }
        public void setCenterVisits(int newVisitCount)
        {
            CenterVists = newVisitCount;
        }
        public void IncreaseVisits()
        {
            CenterVists++;
        }
        public void DecreaseVisits()
        {
            CenterVists--;
        }
        public void updateLatestsVisit()
        {
          LastVisitDate = DateTime.Now;
        }
        public void setLastvisitDate(DateTime? lastvisitDate)
        {
            this.LastVisitDate= lastvisitDate; 
        }

        override
         public string ToString()
        {
            return Name;
        }
    }
}

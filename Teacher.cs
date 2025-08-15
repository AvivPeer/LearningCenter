using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCenter
{
    internal class Teacher
    {
        private int Id;
        private int salary;
        private string Name;
        private string phoneNumber;        


        public Teacher()
        {
            Id = 0;
            salary = 0;
            Name = "";
            phoneNumber= string.Empty;
        }
        public Teacher(int id, int salary, string name, string phoneNumber)
        {
            Id = id;
            this.salary = salary;
            Name = name;
            this.phoneNumber = phoneNumber;
        }
        public int getId()
        {
            return Id;
        }
        public void setId(int id)
        {
            Id = id;
        }
        public string getName()
        {
            return Name;
        }
        public int getSalary()
        {
            return salary;
        }
        public string getPhoneNumber()
        {
            return phoneNumber;
        }
        public void setName(string name)
        {
            this.Name = name;
        }
        public void setPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
        public void setSalary(int salary)
        {
            this.salary=salary;
        }

        override
            public string ToString()
        {
            return Name;
        }
    }
}

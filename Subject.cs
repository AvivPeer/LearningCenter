using System;
using System.Collections.Generic;
using System.Linq;

namespace LearningCenter
{
    public class Subject
    {
        // Properties that match MySQL table columns
        private int Id;
        private string Name;



        // Default constructor
        public Subject()
        {
            Id = 0;
            Name = "";
        }

        // Constructor with basic info
        public Subject(string name)
        {
            Id = 0;
            Name = name;
        }




        public string getName()
        {
            return Name;
        }
        public void setName(string newName)
        {
            Name = newName;
        }

        public void setId(int id)
        {
            this.Id = id;
        }
        public int getId()
        {
            return this.Id;
        }

        override
            public string ToString()
        {
            return Name;
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Student
    {
        private string name;
        private string studentID;
        private int yearOfBirth;
        private bool IsActive;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }
        public int YearOfBirth
        {
            get
            {
                return yearOfBirth;
            }
            set
            {
                if (yearOfBirth < 1995 || yearOfBirth > 2000)
                {
                    Console.WriteLine(studentID + " : error try setting invalid year-of-birth value!");
                }
                yearOfBirth = YearOfBirth;
            }
        }
        public string StudentID
        {
            get
            {
                return studentID;
            }
            set
            {
                studentID = value;
            }
        }
        public Boolean isActive
        {
            get
            {
                return IsActive;
            }
            set
            {
                IsActive = value;
            }
        }
        public Student()
        {
            this.name = "John Doe";
            this.studentID = "Unknown";
            yearOfBirth = 1995;
            IsActive = false;
        }
        public Student(string name, string studentID)
        {
            this.name = name;
            this.studentID = studentID;
            yearOfBirth = 1995;
            IsActive = true;
        }
        public Student(string name, string studentID, int yearOfBirth)
        {
            this.name = name;
            this.studentID = studentID;
            this.yearOfBirth = yearOfBirth;
            IsActive = true;
        }
        public Student(string name, string studentID, int yearOfBirth, bool IsActive)
        {
            this.name = name;
            this.studentID = studentID;
            this.yearOfBirth = yearOfBirth;
            this.IsActive = IsActive;
        }
        public int getAge()
        {
            return DateTime.Now.Year - yearOfBirth;
        }
        public override string ToString()
        {
            if (IsActive == true)
            {
                return "[Student " + name + " (" + studentID + ")" + ", age=" + getAge() + " is active student]";
            }

            return "[Student " + name + " (" + studentID + ")" + ", age=" + getAge() + " is not active student]";
        }
    }
}

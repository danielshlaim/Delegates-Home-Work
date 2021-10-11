using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Delegates_Home_Work
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
        public int NeedToPay { get; set; }
        public int Paid { get; set; }

        public Student()
        {

        }

        public Student(int iD, string firstName, string lastName, int age, int grade, int needToPay, int paid)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Grade = grade;
            NeedToPay = needToPay;
            Paid = paid;
        }
    }
}

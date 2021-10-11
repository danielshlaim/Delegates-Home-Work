using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Home_Work
{
    public delegate bool FilterDelegate(Student student);
    public delegate int SumDelegate(Student student);
    public delegate double CountDelegate(Student student);


    public class StudentList
    {
       
        public static List<Student> students = new List<Student>(); // רישמת סטודנטים

        public void Add(Student student)
        {
            students.Add(student);
        }
        public void Remove(Student student)
        {
            students.Remove(student);
        }

        public  List<Student> Filter(FilterDelegate filterDelegate)
        {
            List<Student> filteredlist = new List<Student>();
            foreach (var item in students)
            {
                if (filterDelegate(item))
                {
                    filteredlist.Add(item);
                }
            }
            return filteredlist;
        }

        public  bool Contains(FilterDelegate filterDelegate)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (filterDelegate(students[i]))
                {
                    return true;
                }
            }
                return false;
        }
       
        public static int Sum(SumDelegate sumDelegate)
        {
            int sum = 0;
            foreach (var student in students)
            {
                 sum += sumDelegate(student);
                
            }
            return sum;
        }

        public static double Average(CountDelegate countDelegate)
        {
            double sumave = 0; // סכום כל הגילאים או ציונים
            int count = 0;// מספר המשתתפים
            foreach (var student in students)
            {
                sumave += countDelegate(student);
                count++;
            }
            return sumave/count;
        } 
    }

}

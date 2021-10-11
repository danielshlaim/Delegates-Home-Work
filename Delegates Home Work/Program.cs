using System;


namespace Delegates_Home_Work
{
    delegate void MyFirstDelegate();
    delegate void Greet(string Name);
  

    public class Program
    {
        

        static void Main(string[] args)
        {
            

            MyFirstDelegate myfirst = Print;
            MyFirstDelegate mysecond = Print2;
            myfirst();
            mysecond();
            Greet mygreet = Shalom;
            mygreet("daniel");
            Greet mygreet1 = Welcome;
            mygreet1("gil");

            // אי אפשר להצביע על פרינט 2 מכיוון שאין להם את אותו המצביע ופרינט 2 לא מקבל פרמטרים

             var StudentManagement = new StudentList();
            StudentManagement.Add(new Student(474939371 ,"daniel","yoyo",24,90,0,100));
            StudentManagement.Add(new Student(775396532, "shai", "momo", 32, 75, 50, 50));
            StudentManagement.Add(new Student(582958671, "ben", "shosho",22, 80, 100, 80));
            StudentManagement.Add(new Student(281947683, "efrim", "lolo", 29, 95, 100, 0));

            var studentlist = StudentManagement.Filter(FilterStudent);
            if (StudentManagement.Contains(FilterGrade))
            {
                Console.WriteLine("We Found a Failure");
            }
            else
            {
                Console.WriteLine("We Dont Found One");
            }

            StudentManagement.Contains(FilterStudentByFullName);

            StudentList.Sum(StudentNeedToPay);
            StudentList.Sum(StudentPaid);
           
            int x = StudentList.Sum(StudentNeedToPay);
            Console.WriteLine(x);
            int y = StudentList.Sum(StudentPaid);
            Console.WriteLine(y);

            double a = StudentList.Average(StudentAge);
            Console.WriteLine(a);
            double g = StudentList.Average(StudentGrade);
            Console.WriteLine(g);
        }

        public static double StudentAge(Student student)
        {
            return student.Age;
        }

        public static double StudentGrade(Student student)
        {
            return student.Grade;
        }


        public static int StudentPaid(Student student)
        {
            return student.Paid;
        }

       

        public static int StudentNeedToPay(Student student)
        {
            return student.NeedToPay;
        }


        public static bool FilterStudentByFullName(Student student)
        {
            if (student.FirstName[0] == student.LastName[0])
            {
                return true;
            }
           return false;
            
        }

        public  static  bool FilterGrade(Student student)
        {
            if (student.Grade > 50)
            {
                return true;
            }
            return false;
        }
        public static bool FilterStudent(Student student)
        {

            foreach (var item in student.Age.ToString())
            {
                if (student.Age > 22)
                {
                    return true;
                }
            }
            return false;
        }


        public static void Print()
        {
            Console.WriteLine("shalom");
        }
        public static void Print2()
        {
            Console.WriteLine("Another function called with the same delegate");
        }
        public static void Shalom(string name)
        {
            Console.WriteLine("Shalom " + name);
        }
        public static void Welcome(string name)
        {
            Console.WriteLine("Welcome " + name);
        }
    }
}

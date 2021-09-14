using System;

namespace StudentStruct
{
    public struct Student
    {
        public string name;
        public string course;
        public int stdId;
        public int regId;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1;
            Console.WriteLine("Enter Student Details");
            Console.Write("Enter Student Name: ");
            s1.name = Console.ReadLine();
            Console.Write("Enter Course: ");
            s1.course = Console.ReadLine();
            Console.Write("Enter Student_ID: ");
            s1.stdId =Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Registration_ID: ");
            s1.regId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("The Student Details are\n");
            Console.WriteLine("\tName= {0}\n\tCourse= {1}\n\tStudentID= {2}\n\tRegistrationID= {3}\n", s1.name, s1.course, s1.stdId, s1.regId);
           // Console.WriteLine("Enter Student Details");
            /*Student s2 = s1;
            Console.Write("\tEnter Student Name: ");
            s2.name = Console.ReadLine();
            Console.Write("\tEnter Student_ID: ");
            s2.stdId = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tEnter Student Registration_ID: ");
            s2.regId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Second Student Details are\n");
            Console.WriteLine("Name= {0}\nCourse= {1}\nStudentID= {2} \nRegistrationID= {3} ", s2.name, s2.course, s2.stdId, s2.regId);*/
        }
    }
}

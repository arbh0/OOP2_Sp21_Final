using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Anik", "01", 3.21F);
            Student s2 = new Student("Zisan", "02", 3.43F);
            Student s3 = new Student("Raj", "03", 3.65F);
            Student s4 = new Student("Miahin", "04", 3.15F);
            Student s5 = new Student("Arfan", "05", 3.32F);


            Course c1 = new Course("CSC101", "C Programming");
            Course c2 = new Course("PHY101", "Phyics 1");
            Course c3 = new Course("MAT101", "Integration");
            Console.WriteLine("--------------------------------------------");
            c1.ShowCourseInfo();
            c1.AddStudent(s1, s3, s4, s5);
            c1.PrintStudent();

            Console.WriteLine("--------------------------------------------");
            c1.RemoveStudent(s5);
            s4.PrintCourse();
            c1.PrintStudent();
            Console.WriteLine("--------------------------------------------");
            s2.AddCourse(c1, c2, c3);
            s2.ShowInfo();
            s2.PrintCourse();
            Console.WriteLine("--------------------------------------------");
            s2.RemoveCourse(c2);
            s2.ShowInfo();
            s2.PrintCourse();
            Console.WriteLine("--------------------------------------------");
            c3.PrintStudent();
            Console.WriteLine("--------------------------------------------");
            Console.ReadLine();
        }
    }
}

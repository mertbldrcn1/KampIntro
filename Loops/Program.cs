using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string Course1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string Course2 = "Programlamaya Başlangıç için Temel Kurs";
            string Course3 = "Java";

            Console.WriteLine(Course1);
            Console.WriteLine(Course2);
            Console.WriteLine(Course3);


            // array

            string[] Courses = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç için Temel Kurs", "java" };

                

            for (int i = 0; i < Courses.Length; i++)
            {
                Console.WriteLine(Courses[i]);

            }

            foreach (string course in Courses)
            {
                Console.WriteLine(course);

            }

            //foreach ( var x in Courses ) 
            //{ 
            //  Console.Writeline(x);
            //}
            // Gibi yazılabilir, aynı sonucu verir. 


            Console.WriteLine("Footer");
        }
    }
}

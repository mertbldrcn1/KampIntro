using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Mert";
            int age = 23;

            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.Lecturer = "Engin Demiroğ";
            course1.Rating = 68;

            Course course2 = new Course();
            course2.CourseName = "java";
            course2.Lecturer = "Mert Bıldırcın";
            course2.Rating = 97;

            Course course3 = new Course();
            course3.CourseName = "C++";
            course3.Lecturer = "Enes Zeytin";
            course3.Rating = 63;


            Console.WriteLine(course2.CourseName + " : " + course2.Lecturer);

            Course[] courses = new Course[] { course1, course2, course3 };

            foreach (var course in courses)
            {
                
                Console.WriteLine(course.CourseName + " : " + course.Lecturer);
                 
            }


            Console.WriteLine("Hello World!");
        }
    }

    class Course
    {
        public string CourseName { get; set; }
        public string Lecturer { get; set; }
        public int Rating { get; set; }


    }
}

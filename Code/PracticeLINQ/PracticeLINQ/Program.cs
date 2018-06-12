using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLINQ
{
    class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int Age { get; set; }
        public int ID { get; set; }
        public List<int> Scores;
    }

    class Staff
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
    }


    class Course
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Semester { get; set; }
        public int Duration { get; set; }
    }

    class Room
    {
        public string Code { get; set; }
    }

    class Schedule
    {
        public string Room { get; set; }
        public string Course { get; set; }
    }


    class MainClass
    {

        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>
            {
                new Student {First="Bob", Last="Jones", ID=111, Age=15, Scores= new List<int> {69, 92, 81, 60}},
                new Student {First="Claire", Last="Simpson", ID=112, Age=17, Scores= new List<int> {75, 84, 83, 39}},
                new Student {First="John", Last="Feetham", ID=113, Age=21, Scores= new List<int> {65, 94, 65, 91}},
                new Student {First="Jonathan", Last="Potts", ID=114, Age=10, Scores= new List<int> {97, 83, 85, 62}},
                new Student {First="Pepe", Last="Garcia", ID=115, Age=20, Scores= new List<int> {35, 72, 91, 70}},
                new Student {First="Samantha", Last="Fakhouri", ID=116, Age=17, Scores= new List<int> {99, 86, 90, 54}},
                new Student {First="Roger", Last="Song", ID=117, Age=19, Scores= new List<int> {60, 72, 64, 45}},
                new Student {First="Hugo", Last="Garcia", ID=118, Age=15, Scores= new List<int> {92, 90, 83, 78}},
                new Student {First="Richard", Last="Ammerman", ID=119, Age=14, Scores= new List<int> {68, 79, 81, 92}},
                new Student {First="Kevin", Last="Adamson", ID=120, Age=11, Scores= new List<int> {68, 71, 81, 79}},
                new Student {First="Jeet", Last="Singh", ID=121, Age=12, Scores= new List<int> {96, 85, 91, 60}}
            };

            List<Staff> teacherList = new List<Staff>
            {
                new Staff {First="Jeet", Last="Singh", ID=900},
                new Staff {First="Richard", Last="Potter", ID=901},
                new Staff {First="Terry", Last="Woodward", ID=902},
                new Staff {First="Bob", Last="Feetham", ID=903},
                new Staff {First="Jane", Last="Feetham", ID=904},
                new Staff {First="Oliver", Last="Jones", ID=905},
                new Staff {First="Rafael", Last="Sacramento", ID=906},
                new Staff {First="John", Last="Smith", ID=907},
                new Staff {First="Pepe", Last="Garcia", ID=908}
            };

            List<Course> courseList = new List<Course>
            {
                new Course{Code="100AB",Name="Intro To Computers",Semester="Fall",Duration=15},
                new Course{Code="101AB",Name="Programming I",Semester="Winter",Duration=15},
                new Course{Code="102AB",Name="Programming II",Semester="Fall",Duration=15},
                new Course{Code="103AB",Name="Database I",Semester="Summer",Duration=5},
                new Course{Code="104AB",Name="Database II",Semester="Summer",Duration=5},
                new Course{Code="303ER",Name="Applied Mathematics",Semester="Summer",Duration=5},
                new Course{Code="304ER",Name="Pure Mathematics",Semester="Fall",Duration=15},
                new Course{Code="588A",Name="English Language",Semester="Winter",Duration=10},
                new Course{Code="589A",Name="English Literature",Semester="Winter",Duration=10},
                new Course{Code="588B",Name="More English Language",Semester="Fall",Duration=10},
                new Course{Code="589B",Name="More English Literatute",Semester="Fall",Duration=10},
                new Course{Code="123Z",Name="Basic Biology",Semester="Winter",Duration=15},
                new Course{Code="123Y",Name="Basic Chemistry",Semester="Fall",Duration=15},
                new Course{Code="123X",Name="Basic Physics",Semester="Summer",Duration=8}
            };


            Console.WriteLine("** Students who are under 18 years of age (in order of age) **");
            var under18 = from s in studentList where s.Age < 18orderby s.Age select s;

            foreach (Student student in under18)
            {
                Console.WriteLine("{0} {1}, {2}", student.First, student.Last, student.Age);
            }

            Console.WriteLine("\n\n** Students who are teenagers(alphabetical order by last name) **");
            var teenagers = from s1 in studentList where s1.Age > 10 && s1.Age < 20 orderby s1.Last select s1;

            foreach (Student student in teenagers)
            {
                Console.WriteLine("{0} {1}, {2}", student.First, student.Last, student.Age);
            }


            Console.WriteLine("\n\n**  Students who scored 80 or more in their last test (order by score descending) **");
            var lastScoreOver80 = from s2 in studentList where s2.Scores[3] > 80 orderby s2.Scores[3] descending select s2;

            foreach (Student student in lastScoreOver80)
            {
                Console.WriteLine("{0} {1}, {2}", student.First, student.Last, student.Scores[3]);
            }

            Console.WriteLine("\n\n**  Students who scored over 320 marks in total (across all their tests) **");
            var over320 = from s3 in studentList
                          let totalScore = s3.Scores[0] + s3.Scores[1] + s3.Scores[2] + s3.Scores[3]
                          where totalScore > 80 select s3;

            foreach (Student student in over320)
            {
                Console.WriteLine("{0} {1}, {2}", student.First, student.Last, student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]);
            }

            Console.WriteLine("\n\n**  Students who scored at least 60 in all of their tests **");
            var atleast60 = from s4 in studentList
                            where s4.Scores[0] >= 60 && s4.Scores[1] >= 60 && s4.Scores[2] >= 60 && s4.Scores[3] >= 60
                            
                          select s4;

            foreach (Student student in atleast60)
            {
                Console.WriteLine("{0} {1}", student.First, student.Last);
            }

            Console.WriteLine("\n\n**  Students grouped by first letter of their last name ");
            var groupLastName = from s5 in studentList
                                group s5 by s5.Last[0] into sGroup
                                select sGroup;

            foreach (var sGroup in groupLastName)
            {
                Console.WriteLine(sGroup.Key);
                foreach(Student student in sGroup)
                    Console.WriteLine("     {0} {1}", student.First, student.Last);
            }

            Console.WriteLine("\n\n**  Average score of each test **");
            var t1Total = from s in studentList select s.Scores[0];
            double t1Avg = t1Total.Average();

            Console.WriteLine("Average :" + t1Avg.ToString("0.00"));
            //var average = from s5 in studentList
            //              select (s5 => s5.Scores[0]).Average();
            /*
            foreach (Student student in average)
            {
                Console.WriteLine("{0} {1}, {2}", student.First, student.Last, student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]);
            }
            */
            Console.WriteLine("\n\n**   Students who are also teachers ");
            var studentTeacher = from s in studentList
                                 join t in teacherList
                                 on new { s.First, s.Last }
                                 equals new { t.First, t.Last }
                                 select s.First + " " + s.Last;

            foreach (string name in studentTeacher)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\n\n** Courses of a duration of 15 weeks   **");
            var course15weeks = from c in courseList
                                where c.Duration == 15
                                select c;
            foreach (Course course in course15weeks)
            {
                Console.WriteLine("{0} {1} {2} {3}", course.Code, course.Name, course.Semester, course.Duration);
            }

            Console.WriteLine("\n\n** Courses held in the Winter semester (order by duration) **");
            var courseWinter = from c in courseList
                                where c.Semester == "Winter"
                                select c;
            foreach (Course course in course15weeks)
            {
                Console.WriteLine("{0} {1} {2} {3}", course.Code, course.Name, course.Semester, course.Duration);
            }

            Console.WriteLine("\n\n** Courses grouped by semester  **");
            var groupSemester = from c2 in courseList
                                group c2 by c2.Semester into cGroup
                                select cGroup;

            foreach (var cGroup in groupSemester)
            {
                Console.WriteLine(cGroup.Key);
                foreach (Course course in cGroup)
                    Console.WriteLine("  {0} {1} {2} {3}", course.Code, course.Name, course.Semester, course.Duration);
            }


            Console.ReadLine();
        }

    }
}

/*
using System;
using static System.Console;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{

}

 */

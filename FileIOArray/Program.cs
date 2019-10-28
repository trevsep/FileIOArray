using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOArray
{
    class Program
    {
        static void Main(string[] args)
        {

            string dataPath = @"Data\Students.txt";

            string[] students = new string[3];
            students[0] = "Sue, Mcwaters , 46";
            students[1] = "Trevor, Sepanik, 20";
            students[2] = "Kyle, Barger, 89";

            WriteAllStudents(dataPath, students);

            students = ReadAllStudents(dataPath);

            DisplayAllStudents(students);
            
        }

        static void DisplayAllStudents(string[] students)
        {
            Console.WriteLine();
            Console.WriteLine("Student Info");
            Console.WriteLine();

            Console.WriteLine(
                 "FIRSTNAME".PadRight(15) +
                 "LASTNAME".PadRight(15) +
                 "AGE".PadRight(15)
                 );

            Console.WriteLine(
                 "------------".PadRight(15) +
                 "------------".PadRight(15) +
                 "------------".PadRight(15)
                 );



            foreach (string student in students)
            {
                string[] studentInfo = student.Split(',');
                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                string age = studentInfo[2];

              


                Console.WriteLine(
                    firstName.PadRight(15) + 
                    lastName.PadRight(15) +
                    age.PadRight(15)
                    );

            }

            Console.WriteLine();

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        static string[] ReadAllStudents(string datapath)
        {
            string[] students;

            students = File.ReadAllLines(datapath);

            return students;
        }

        static void WriteAllStudents(string datapath, string[] students)
        {
            File.WriteAllLines(datapath, students);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Петя", "Иванов", "LOG19_ag");
            student1.generatRandomRating();


            Student student2 = new Student("Таня", "Петрова", "TIT20_av");
            student2.generatRandomRating();

            Student student3 = new Student("Илон", "Маск", "TIG21_tv");
            student3.generatRandomRating();

           
            Console.WriteLine(student1.getGroupeName() + " " + student1.getFirstName() + " " + student1.getLastName() +": " + student1.showRate());
            Console.WriteLine(student2.getGroupeName() + " " + student2.getFirstName() + " " + student2.getLastName() +": " + student2.showRate());
            Console.WriteLine(student3.getGroupeName() + " " + student3.getFirstName() + " " + student3.getLastName() +": " + student3.showRate());

            checkRate(student1);
            checkRate(student2);
            checkRate(student3);

            Console.ReadKey();
        }

        private static void checkRate(Student student)
        {
            if (student.validationRate() == true)
            {
                Console.WriteLine(student.getFirstName() + " " + student.getLastName() + " - включен в приказ на стипендию.");
            }
            else
            {
                Console.WriteLine(student.getFirstName() + " " + student.getLastName() + " - степению не получают.");
            }
        }
        
    }
}

using System.Xml.Serialization;
using System.Linq;

namespace AAAPZ6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students students = new Students();
            var atestList = new List<Students>
            {
                new Students{student= "Петров", predmet = "математика", semestr = 1, ocenca = "Плохо"},
                new Students{student= "Иванов", predmet = "математика", semestr = 1, ocenca = "Хорошо"},
                new Students{student= "Сидоров", predmet = "математика", semestr = 1, ocenca = "Отлично"},
                new Students{student= "Никифоров", predmet = "математика", semestr = 1, ocenca = "Плохо"}

            };

            Console.WriteLine("Хорошие Студенты: ");
            students.PrintStud(atestList);
            Console.WriteLine("Да на кол их..: ");
            students.SavePloxieStud(atestList);
        }

        
    }
}
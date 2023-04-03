using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AAAPZ6
{
    public class Students
    {
        public string student;
        public int semestr;
        public string predmet;
        public string ocenca;

        public void PrintStud(List<Students> atestLists)
        {
            var atestStusent = atestLists.Where(at => at.ocenca == "Хорошо" || at.ocenca == "Отлично")
                                         .Select(at => at.student +" " + at.ocenca)
                                         .ToList();
            atestStusent.ForEach(at => Console.WriteLine(at));
        }

        public void SavePloxieStud(List<Students> atestLists)
        {
            var atestStusent = atestLists.Where(at => at.ocenca == "Плохо")
                             .Select(at => at.student + " " + at.ocenca)
                             .ToList();
            //atestStusent.ForEach(at => Console.WriteLine(at));
            List<string> ploxieList = atestStusent.ToList();
            ploxieList.ForEach(at => Console.WriteLine(at));

        }


    }

}

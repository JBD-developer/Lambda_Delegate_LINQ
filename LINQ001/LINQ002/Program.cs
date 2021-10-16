using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ002
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listStudent = new List<Student> 
            {
                new Student {_sName ="JEONG" , _iScore = 88},
                new Student {_sName ="PARK"  , _iScore = 100},
                new Student {_sName ="LEE"   , _iScore = 70},
                new Student {_sName ="KIM"   , _iScore = 60},
                new Student {_sName ="JEON"  , _iScore = 90},
            };

            var query = from student in listStudent
                        where student._iScore >= 80
                        orderby student._sName ascending
                        select student._sName;

            foreach (var item in query)
            {
                Console.WriteLine($"student name : {item}");
            }
            Console.ReadLine();
        }
    }
    public class Student
    {
        public string _sName { get; set; }
        public int _iScore { get; set; }
    }
}

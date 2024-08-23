using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructers
{

    public class Program
    {
        static void Main(string[] args)
        {   

            var studentList = new List<Student>()
            {
                new Student(10,"Tuncay","Celikkanat",true),
                new Student(11,"Mustafa","Celikkanat",true),
                new Student(13, "Aysel", "Ay"),
                new Student(12 ,"Zeynep", "Bayraktar", false)
            };

            studentList.ForEach(s => Console.WriteLine(s));

            //value type or reference type
            var s1 = new Student(11, "Tuncii", "Cek");
            var s2 = new Student();
            s2 = s1;
            s1.changeName("Tuncayoski");

            Console.WriteLine(s1.Name);
            Console.WriteLine(s2.Name);

            //foreach (var student in studentList) {
            //    Console.WriteLine(student);
            //}

            //shortcut -> ctrl + shift + v , possible items on board
            Console.ReadLine();
        }

        private static void lowerUpperLimits()
        {
            //8-bit interger

            Console.WriteLine(nameof(SByte));
            Console.WriteLine($"Lower limit     : {SByte.MinValue,10}");
            Console.WriteLine($"Upper limit     : {SByte.MaxValue,10}");
            Console.WriteLine($"Size            : {sizeof(SByte),10}");
            Console.WriteLine(new string('-', 30));

            //Unsigned 8-bit integer
            Console.WriteLine(nameof(Byte));
            Console.WriteLine($"Lower limit     : {Byte.MinValue,10}");
            Console.WriteLine($"Upper limit     : {Byte.MaxValue,10}");
            Console.WriteLine($"Size            : {sizeof(Byte),10}");
            Console.WriteLine(new string('-', 30));

            //16-bit integer
            Console.WriteLine(nameof(Int16));
            Console.WriteLine($"Lower limit     : {Int16.MinValue,10}");
            Console.WriteLine($"Upper limit     : {Int16.MaxValue,10}");
            Console.WriteLine($"Size            : {sizeof(Int16),10}");
            Console.WriteLine(new string('-', 30));

            //Unsigned 16-bit integer
            Console.WriteLine(nameof(UInt16));
            Console.WriteLine($"Lower limit     : {UInt16.MinValue,10}");
            Console.WriteLine($"Upper limit     : {UInt16.MaxValue,10}");
            Console.WriteLine($"Size            : {sizeof(UInt16),10}");
            Console.WriteLine(new string('-', 30));

            //32-bit integer
            Console.WriteLine(nameof(Int32));
            Console.WriteLine($"Lower limit     : {Int32.MinValue,12}");
            Console.WriteLine($"Upper limit     : {Int32.MaxValue,12}");
            Console.WriteLine($"Size            : {sizeof(Int32),12}");
            Console.WriteLine(new string('-', 30));

            //float (Single)
            Console.WriteLine(nameof(Single));
            Console.WriteLine($"Lower limit     : {Single.MinValue,13}");
            Console.WriteLine($"Upper limit     : {Single.MaxValue,13}");
            Console.WriteLine($"Size            : {sizeof(Single),13}");
            Console.WriteLine(new string('-', 40));

            //double
            Console.WriteLine(nameof(Double));
            Console.WriteLine($"Lower limit     : {Double.MinValue,23}");
            Console.WriteLine($"Upper limit     : {Double.MaxValue,23}");
            Console.WriteLine($"Size            : {sizeof(Double),23}");
            Console.WriteLine(new string('-', 45));

            Console.ReadLine();
        }
    }
}

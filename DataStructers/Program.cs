using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataStructers
{

    public class Program
    {
        static void Main(string[] args)
        {
            
            S


            //shortcut -> ctrl + shift + v , possible items on board
            Console.ReadLine();
        }

        private static void HashtableApp()
        {
            //HASTABLE APP
            //Read title
            Console.WriteLine("Enter a title:");
            string title = Console.ReadLine().ToLower();//all of lower cases

            //hashtable
            var charSet = new Hashtable()
            {
                {'ç','c'},
                {'ğ','g'},
                {'ı','i'},
                {'ö','o'},
                {'ş','s'},
                {'ü','u'},
                {' ','-'},
                {'\'','-'},
                {'.','-'}
            };

            foreach (DictionaryEntry item in charSet)
            {
                title = title.Replace((char)item.Key, (char)item.Value);
            }

            Console.WriteLine(title);
        }

        private static void HashtableIntro()
        {
            /* Hashtable
                         * System.Collection
                         * non-generic -> object -> boxing/unboxing
                         * indexing is not excist
                         * key-value pairs
                         * key-value -> ICollection Interface
                         * ConteinKey
                         * ConteinValue
                         */

            var cities = new Hashtable();
            cities.Add(06, "Ankara");
            cities.Add(38, "Kayseri");
            cities.Add(34, "İstanbul");
            cities.Add(55, "Elazığ");

            foreach (DictionaryEntry c in cities)
                Console.WriteLine($"{c.Key,-5} - {c.Value,10}");


            //Access the keys
            Console.WriteLine("\nKeys:");
            var keys = cities.Keys;
            foreach (var key in keys)
                Console.WriteLine(key);

            Console.WriteLine("\nValues:");
            ICollection values = cities.Values;

            foreach (var value in values)
                Console.WriteLine(value);

            //Access to any specific item
            Console.WriteLine("\nAccess to any specific item:");
            Console.WriteLine(cities[55]);

            //Remove item
            Console.WriteLine("\nRemoving");
            cities.Remove(55);
            foreach (DictionaryEntry c in cities)
                Console.WriteLine($"{c.Key,-5} - {c.Value,10}");
        }

        private static void Teachers()
        {
            Teachers t1 = new Teachers(1234567, "Atıl", "Samancıoğlu", true);
            Teachers t2 = new Teachers(12347, "Tuncay", "Çelikkanat", true);
            Teachers t3 = new Teachers(123, "Tunci", "Çelikkanat", true);
            Teachers t4 = new Teachers(12, "Tunkey", "Çelikkanat", true);

            List<Teachers> teacherList = new List<Teachers>() { t1, t2, t3, t4 };
            Console.WriteLine("List 1:");
            teacherList.ForEach(t => Console.WriteLine(t));
            Console.WriteLine(new String('-', 30));

            Console.WriteLine("List 2:");
            var teacherList2 = teacherList;
            teacherList2.ForEach(t => Console.WriteLine(t));
            Console.WriteLine(new String('-', 30));

            //value type or reference type => referance type
            teacherList2.Add(new Teachers(431, "New", "Item", false));
            Console.WriteLine("\nNew Item added teacherList2:");

            Console.WriteLine("List 1:");
            teacherList.ForEach(t => Console.WriteLine(t));
            Console.WriteLine(new String('-', 30));

            Console.WriteLine("List 2:");
            teacherList2.ForEach(t => Console.WriteLine(t));
        }

        private static void students()
        {
            var studentList = new List<Student>()
            {
                new Student(10,"Tuncay","Celikkanat",true),
                new Student(11,"Mustafa","Celikkanat",true),
                new Student(13, "Aysel", "Ay"),
                new Student(12 ,"Zeynep", "Bayraktar", false)
            };

            studentList.ForEach(s => Console.WriteLine(s));

            //value type or reference type => value type
            var s1 = new Student(11, "Tuncii", "Cek");
            var s2 = new Student();
            s2 = s1;
            s1.changeName("Tuncayoski");

            Console.WriteLine(s1.Name);
            Console.WriteLine(s2.Name);

            //foreach (var student in studentList) {
            //    Console.WriteLine(student);
            //}
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

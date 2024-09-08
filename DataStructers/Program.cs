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
    public class City : IComparable<City>
    {
        public City(int plakaNo, string cityName)
        {
            PlakaNo = plakaNo;
            this.cityName = cityName;
        }

        public int PlakaNo { get; set; }
        public string cityName { get; set; }

        public int CompareTo(City other)
        {
            if (this.PlakaNo < other.PlakaNo) return -1;
            else if (this.PlakaNo == other.PlakaNo) return 0;
            else return 1;
        }

        public override string ToString()
        {
            return $"{PlakaNo, -5} {cityName,-5}";
        }

        
    }
    public class Personel
    {
        public Personel(string name, string surname, decimal salary)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
        }

        public int SicilNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"{Name,-8} {Surname,-12} {Salary,-5}";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {


            //shortcut -> ctrl + shift + v , possible items on board
            Console.ReadLine();
        }

        private static void SortedSetApp2()
        {
            // SortedSet set operations
            //var A = new SortedSet<int>() { 1,2,3,4};
            var A = new SortedSet<int>(randomBullshitGo(4));
            //var B = new SortedSet<int>() { 1,2,5,6};
            var B = new SortedSet<int>(randomBullshitGo(7));


            #region print
            Console.WriteLine("Set A:");
            foreach (var a in A) Console.Write($"{a,5}");

            Console.WriteLine("\nSet B:");
            foreach (var b in B) Console.Write($"{b,5}");
            Console.WriteLine();
            #endregion

            #region Union
            /*
            A.UnionWith(B); //-> Set A = A.UnionWith(B) its mean that set a is changed with union of a and b
            Console.WriteLine("Union of A and B.");
            foreach (var a in A) Console.Write($"{a,5}");
            Console.WriteLine("\nNumber of items: {0}", A.Count);
            */
            #endregion

            #region Intersection
            /*
            A.IntersectWith(B);
            Console.WriteLine("Intersection of A and B.");
            foreach (var a in A) Console.Write($"{a,5}");
            Console.WriteLine("\nNumber of items: {0}", A.Count);
            */
            #endregion

            #region ExceptWith
            /*
            A.ExceptWith(B);
            Console.WriteLine("Only A:");
            foreach (var a in A) Console.Write($"{a,5}");
            Console.WriteLine("\nNumber of items: {0}", A.Count);
            */
            #endregion

            #region Symmetric Exception
            /*
            A.SymmetricExceptWith(B);
            Console.WriteLine("Symmetric exception of A and B.");
            foreach (var a in A) Console.Write($"{a,5}");
            Console.WriteLine("\nNumber of items: {0}", A.Count);
            */
            #endregion

            Console.WriteLine("\nA is subset of B?" +
                "\n{0}", A.IsSubsetOf(B));

            Console.WriteLine("\nB is subset of A?" +
                "\n{0}", B.IsSubsetOf(A));
        }

        static List<int> randomBullshitGo(int n)
        {
            var list = new List<int>();
            var r = new Random();
            for (int i = 0; i < n; i++)
                list.Add(r.Next(0,10));
            return list;
        }

        private static void SortedSetApp()
        {
            var numbers = new List<int>();
            var r = new Random();

            for (int i = 0; i <= 100; i++)
            {
                numbers.Add(r.Next(0, 10));
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();

            //Finding unique items
            var uniqueItemsList = new SortedSet<int>(numbers);
            Console.WriteLine("\nUnique items list.\n");

            foreach (int item in uniqueItemsList)
            {
                Console.Write($"{item,-3}");
            }
            Console.WriteLine("\nThere are {0} unique items.", uniqueItemsList.Count);
        }

        private static void SortedSetIntro()
        {
                         /*SortedSet<T>
                         * System.Collection.Generic
                         * T -> Type
                         * items must be unique
                         * sorting on addition
                         * Add() -> boolean
                         * if added item already in list, it returns false; otherways it returns true.
                         * Remove(), RemoveWhere( predicate ) -> if
                         * Dynamic capasity
                         * it is a set and it can be union, intersection, exception, subset...
                         * A.UnionWith(B) -> A u B
                         * A.SymetricExceptWith(B) -> get the only A and only B
                         * A.ExceptWith(B) -> A\B
                         * A.IntersectWith(B) -> get the intersection
                         */

            var nameList = new SortedSet<string>()
            {
                "Zeynep",
                "Dila",
                "Kerem",
                "Sena",
                "Senanın arkadaşı"
            };

            if (nameList.Add("Tuncay"))
            {
                Console.WriteLine("Tuncay added.");
            }

            Console.WriteLine("\n{0}", nameList.Add("Zeynep") == true ?
                "Zeynep added." : "Addition fail.");

            nameList.Remove("Kerem");
            nameList.RemoveWhere(value => value.Contains("S")); //starWith ...there are another methods like these.

            Console.WriteLine("\nName List\n");
            foreach (string name in nameList)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"Items: {nameList.Count,-3}");
        }

        private static void SortedDirectoryApp()
        {
            /*SortedDirectory<TKey, TValue>
             * whole methods in Directory
             * TKey - TValue
             * Less optimize than Directory because of sorting
             * sort by TKey
             */

            var bookIndex = new SortedDictionary<string, List<int>>()
            {
                {"FTP", new List<int>{3,5,7 } },
                {"ASP.NET", new List<int>{50,60 } },
                {"HTML", new List<int>{8,10,12} },
                {"CSS", new List<int>{70,80,90} },
                {"jQuery", new List<int>{3,5,15} },
                {"SQL", new List<int>{70,80} },
            };

            foreach (var book in bookIndex)
            {
                Console.Write($"{book.Key,-8},");
                foreach (int v in book.Value)
                {
                    Console.Write($" {v}.");
                }
                Console.WriteLine();
            }
        }
        
        private static void DictionaryApp()
        {
            var personelList = new Dictionary<int, Personel>()
            {
                {110, new Personel("Tuncay", "Çelikkanat", 41_000) },
                {120, new Personel("Sena", "Yiğit", 35_000) }
            };

            personelList.Add(100, new Personel("Zeynep", "Bayraktar", 40_000));

            foreach (var p in personelList) Console.WriteLine(p);
        }

        private static void DictionaryIntro()
        {
                        /* Dictionary<TKey, TValue>
                         * System.Collections.Generic
                         * T -> Type
                         * TKey -> unique
                         * TValue -> anything
                         * More performans than HashTable
                         */

            var phoneCodes = new Dictionary<int, string>()
            {
                {332,"Konya" },
                {424,"Elazığ" },
                {466,"Art" }
            };
            phoneCodes.Add(322, "Adana");
            phoneCodes.Add(212, "Istanbul");

            //Access
            phoneCodes[466] = "Artvin";

            //ConteinsKey
            if (!phoneCodes.ContainsKey(312))
            {
                Console.WriteLine("\aCod info is invalid.");
                phoneCodes.Add(312, "Ankara");
                Console.WriteLine("Ankara added with 312 code.");
            }

            //ConteinsValue
            Console.WriteLine(phoneCodes.ContainsValue("Malatya"));

            //Removing
            phoneCodes.Remove(322);

            foreach (var item in phoneCodes) Console.WriteLine(item);
        }

        private static void LinkedListApp()
        {
                        /*LinkedList<T>
                         * System.Collections.Generic
                         * T -> Type
                         * non-sorted
                         * Next - Previous -> pointers
                         * First - Last
                         * AddFirst - AddLast
                         * Remove, RemoveFirst, RemoveLast
                         * AddBefore - AddAfter
                         */

            var cities = new LinkedList<string>();
            // i'm in a travel and i will start with Ordu
            cities.AddFirst("Ordu");

            // i diceded to go first Trabzon,in this case, Ordu is not the first city.
            cities.AddFirst("Trabzon");

            // Istanbul is the last city i went
            cities.AddLast("Istanbul");

            // Trabzon -> Ordu -> Istanbul
            //But i forget to write that i went Kayseri after Ordu.
            cities.AddAfter(cities.Find("Ordu"), "Kayseri");

            /* additionaly i added Ankara befor Kayseri but using another methot
                Trabzon -> Ordu -> Kayseri -> Istanbul
                    i will use .AddBefore(), i need a pointer that point Kayseri for this
                cities.First.Next.Next <- that is the point i need 
                ------------ ---- -----
                  Trabzon    Ordu Kayseri    
             */
            cities.AddBefore(cities.First.Next.Next, "Ankara");

            /*Trabzon -> Ordu -> Ankara -> Kayseri -> Istanbul
                    i will add Sivas after Kayseri
                for this i have more options like cities.Last.Previous
                that points Kayseri
             */
            cities.AddAfter(cities.Last.Previous, "Sivas");

            /* Trabzon -> Ordu -> Ankara -> Kayseri -> Sivas -> Istanbul
             * i will add Antalya after Sivas */
            cities.AddAfter(cities.Find("Sivas"), "Antalya");

            //int i = 1;
            //foreach (string c in cities) {
            //    Console.WriteLine($"{i}. {c}");
            //    i++;
            //}

            var item = cities.First;
            Console.WriteLine("It's the going way:");
            while (item != null)
            {
                Console.WriteLine(item.Value);
                item = item.Next;
            }

            var item2 = cities.Last;
            Console.WriteLine("\nIt's the returning way:");
            while (item2 != null)
            {
                Console.WriteLine(item2.Value);
                item2 = item2.Previous;
            }
        }

        private static void QueueApp()
        {
            var vowelLetter = new List<char>()
            {
                'a','e','ı','i','u','ü','o','ö'
            };

            ConsoleKeyInfo choice;
            var queue = new Queue<char>();

            foreach (char ch in vowelLetter)
            {
                Console.WriteLine($"Add \"{ch}\" to queue? [y/n] ");
                choice = Console.ReadKey();
                Console.WriteLine();

                if (choice.Key == ConsoleKey.Y)
                {
                    queue.Enqueue(ch);
                    Console.WriteLine($"\n\"{ch}\" added to queue.");
                    Console.WriteLine($"Number of items on queue: {queue.Count}\n");
                }
                else if (choice.Key == ConsoleKey.N)
                {
                    Console.WriteLine($"\n\"{ch}\" did not added to queue.");
                    Console.WriteLine($"Number of items on queue: {queue.Count}\n");
                }
            }

            Console.WriteLine("\nAdding to queue is completed.");
            Console.WriteLine("If you want to delete any item in queue, " +
                "\nplease enter Esc.");
            choice = Console.ReadKey(true);

            if (choice.Key == ConsoleKey.Escape)
            {
                while (queue.Count > 0)
                {
                    Console.WriteLine($"\n\"{queue.Dequeue()}\" is removed from queue.");
                    Console.WriteLine($"Number of items on queue: {queue.Count}\n");
                }
                Console.WriteLine("\nRemoving to queue is completed.");
            }
            Console.WriteLine("\nProgram ended.");
        }

        private static void QueueIntro()
        {
                         /*Queue
                         * System.Collection.Generic
                         * T -> Type
                         * First-In First-Out -> FIFO
                         * Enqueu (adding items)
                         * Dequeu (removing items)
                         * Peek(), Count(), Clear()
                         */

            var charQue = new Queue<char>();
            charQue.Enqueue('a');
            charQue.Enqueue('e');
            charQue.Enqueue('i');
            charQue.Enqueue('o');
            charQue.Enqueue('u');

            foreach (char c in charQue)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine($"\nNumbers of items in queue: {charQue.Count}");

            var array = charQue.ToArray(); //char[2]

            Console.WriteLine($"Removed item: {charQue.Dequeue()}\n");
            //charQue.Dequeue();  //return a char

            foreach (char c in charQue)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine($"First item after removing: {charQue.Peek()}");
            Console.WriteLine($"Numbers of items in queue: {charQue.Count}");
        }

        private static void StackExample2()
        {
            Console.WriteLine("Enter a integer number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            var numberStack = new Stack<int>();

            while (number > 0)
            {
                int k = number % 10;
                numberStack.Push(k);
                number = number / 10;
            }

            int i = 0;
            int n = numberStack.Count - 1;
            foreach (var s in numberStack)
            {
                Console.WriteLine($"{s} x " +
                    $"{Math.Pow(10, n - i),7} = " +
                    $"{s * Math.Pow(10, n - i),7}");
                i++;
            }
        }

        private static void StackExample1()
        {
            var charStack2 = new Stack<char>();
            for (int i = 65; i < 91; i++)
            {
                charStack2.Push((char)i);
                Console.WriteLine($"{charStack2.Peek()} added to stack2.");
                Console.WriteLine($"Count: {charStack2.Count}");
            }
            Console.WriteLine(new string('-', 30));

            while (charStack2.Count > 0)
            {
                Console.WriteLine($"{charStack2.Pop()} removed from stack2.");
                Console.WriteLine($"Count: {charStack2.Count}");
            }

            //Additional info
            var array = charStack2.ToArray();
        }

        private static void stackIntro()
        {
                         /*Stack <T>
                         * System.Collection.Generic
                         * T -> Type -> Stack<int>, Stack<string>
                         * Last-In First-Out -> LIFO
                         * push()
                         * pop()
                         * peek()
                         * clear()
                         * count()
                         * toArray()
                         * Calling func, recurtive
                         * Example: last used apps
                         */

            var charStack = new Stack<char>();
            //Add item
            charStack.Push('A');
            Console.WriteLine(charStack.Peek());
            charStack.Push('B');
            Console.WriteLine(charStack.Peek());
            charStack.Push('C');
            Console.WriteLine(charStack.Peek());

            //Remove
            Console.WriteLine(charStack.Pop() + " popped on stack.");
            Console.WriteLine(charStack.Pop() + " popped on stack.");
            Console.WriteLine(charStack.Pop() + " popped on stack.");
        }

        private static void ListIntro()
        {
                         /* List<T>
                         * System.Collection.Generic
                         * Array -> ArrayList(object) -> List<T> -> Type
                         * Add(), AddRange(), Count(), Capacity(), Remove()...
                         * Interface -> Inheritance
                         * C# -> class(inheritance)
                         *    -> interface inheritance
                         */

            var numbers = new List<int>() { 100, 53, 12, 24, 45, 56, 67, 78, 89 };
            numbers.Sort();
            numbers.ForEach(n => Console.WriteLine(n));
            Console.WriteLine();

            var cities = new List<City>()
            {
                new City(38,"Kayseri"),
                new City(6,"Ankara"),
                new City(34,"Istanbul"),
                new City(44,"Malatya")
            };
            cities.Sort();
            cities.ForEach(c => Console.WriteLine(c));
        }

        private static void SortedListApp()
        {
            //Sortedlist App
            var bookContent = new SortedList()
            {
                {1,"Preface" },
                {50,"OOP" },
                {40,"Loops" },
                {35,"Math" },
                {60,"Martix" }
            };
            Console.WriteLine("Contents");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"{"Contents",-20} {"Pages",5}\n");

            foreach (DictionaryEntry book in bookContent)
                Console.WriteLine($"{book.Value,-20} {book.Key,5}");
        }

        private static void SortedListIntro()
        {
                        /* SORTEDLIST
                         * System.Collection
                         * non-generic(object)
                         * key-value pairs
                         * keys sorteable
                         * indexing is exist
                         * IndexOfKey - IndexOfValue 
                         * getKey - getValue - getByIndex 
                         * DictionaryEntry
                         * ICompareable
                         */

            var list = new SortedList()
            {
                {1,"One"},
                {3,"Three" },
                {8,"Eight" },
                {4,"Four" },
                {6,"Six" },
                {7,"Seven" },
                {5,"Five" }
            };
            list.Add(2, "Two");

            foreach (DictionaryEntry item in list)
                Console.WriteLine($"{item.Key,3}, {item.Value,5}");

            Console.WriteLine("Features:");
            Console.WriteLine("Length of list   : {0}", list.Count);
            Console.WriteLine("Capacity of list : {0}", list.Capacity);
            list.TrimToSize();
            Console.WriteLine("Capacity of list : {0}", list.Capacity);
            Console.WriteLine(new string('-', 25));

            //Access with key
            Console.WriteLine(list[4]);
            //with index
            Console.WriteLine(list.GetByIndex(0));
            //get key
            Console.WriteLine(list.GetKey(0)); //0th index
            //last item value
            Console.WriteLine(list.GetByIndex(list.Count - 1));

            var keys = list.Keys;
            Console.WriteLine("\nKeys:");
            foreach (var key in keys)
                Console.WriteLine(key);

            var values = list.Values;
            Console.WriteLine("\nValues:");
            foreach (var value in values)
                Console.WriteLine(value);

            if (list.Contains(1))
                list[1] = "Bir";
            list.Remove(4);

            foreach (DictionaryEntry item in list)
                Console.WriteLine($"{item.Key,3}, {item.Value,5}");
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

using System.Xml.Serialization;

namespace DataStructers
{
    public struct Student
    {
        //Constructor
        public Student(int number, string name, string surname, bool gender = true)
        {
            Number = number;
            Name = name;
            Surname = surname;
            Gender = gender;
        }

        public int Number { get; set; } // Property
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Gender { get; set; }

        //Override

        public override string ToString()
        {
            return $"Name      : {this.Name,12}\n" +
                $"Surname   : {this.Surname,12}\n" +           
                $"Number    : {this.Number,12}\n" +
                string.Format("Gender    : {0,12}\n", Gender == true? "Mr": "Ms");
        }

        public void changeName(string newName)
        {
            Name = newName;
        }
    }
}

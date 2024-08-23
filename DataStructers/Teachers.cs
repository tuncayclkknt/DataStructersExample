using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructers
{
    public class Teachers
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Gender { get; set; }

        
        public Teachers(int id, string name, string surname, bool gender)
        {
            this.id = id;
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
        }

        public override string ToString()
        {
            return $"Name      : {this.Name,12}\n" +
                $"Surname   : {this.Surname,12}\n" +
                $"ID        : {this.id,12}\n" +
                string.Format("Gender    : {0,12}\n", Gender == true ? "Mr" : "Ms");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NttData.FileManagement.Common.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthay { get; set; }
        public int Age { get; set; }



        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   Id == student.Id &&
                   Name == student.Name &&
                   Surname == student.Surname &&
                   Birthay == student.Birthay &&
                   Age == student.Age; 
        }

        public override int GetHashCode()
        {
            int hashCode = -965624652;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + Birthay.GetHashCode();
            hashCode = hashCode * -1521134295 + Age.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Surname + ", " + Birthay.ToString("dd,MM,yyyy") + "," + Age;
        }



    }
}

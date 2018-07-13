using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        private string Name;
        private string LastName;
        private string Adress;
        private string Passport;
        private int Age;
        private string Telephone;
        private int Rating;

        public Student()
        {
            lastname = "unknown";
            adress = "unknown";
            passport = "unknown";
            telephone = "unknown";
            name = "unknown";
            age = 0;
            rating = 0;
        }

        public string name
        {
            set
            {
                Name = value;
            }
            get
            {
                return Name;
            }
        }
        public string lastname
        {
            set
            {
                LastName = value;
            }
            get
            {
                return LastName;
            }
        }
        public string adress
        {
            set
            {
                Adress = value;
            }
            get
            {
                return Adress;
            }
        }
        public string passport
        {
            set
            {
                Passport = value;
            }
            get
            {
                return Passport;
            }
        }
        public int age
        {
            set
            {
                Age = value;
            }
            get
            {
                return Age;

            }

        }
        public string telephone
        {
            set
            {
                Telephone = value;
            }
            get
            {
                return Telephone;
            }
        }
        public int rating
        {
            set
            {
                Rating = value;
            }
            get
            {
                return Rating;
            }
        }

        public void StudentRating(int R)
        {
            rating = R;
        }
   }
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student();
            Console.WriteLine(a.name);
            Console.WriteLine(a.lastname);
        }
    }
}

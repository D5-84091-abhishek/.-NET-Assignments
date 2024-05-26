using assignment07;
using Microsoft.VisualBasic;
using System.Net.Mail;
using System.Threading;

namespace assignment07
{

        public class Person
        {

            public string Name { get; set; }
            public string Gender { get; set; }
            public DateTime Birth { get; set; }
            public string Address { get; set; }


            public int Age
            {
                get
                {
                    return CalculateAge(Birth);
                }
            }

            public Person()
            {
            }

            public Person(string name, string gender, DateTime birth, string address)
            {
                Name = name;
                Gender = gender;
                Birth = birth;
                Address = address;
            }

            public void Accept()
            {
                Console.Write("Enter Name: ");
                Name = Console.ReadLine();

                Console.Write("Enter Gender: ");
                Gender = Console.ReadLine();

                Console.Write("Enter Birth Date (yyyy-mm-dd): ");
                Birth = DateTime.Parse(Console.ReadLine());

                Console.Write("Enter Address: ");
                Address = Console.ReadLine();
            }

            public void Print()
            {
                Console.WriteLine(ToString());
            }


            public override string ToString()
            {
                return $"Name: {Name}, Gender: {Gender}, Birth Date: {Birth.ToShortDateString()}, Address: {Address}, Age: {Age}";
            }

            private static int CalculateAge(DateTime birthDate)
            {
                int age = DateTime.Now.Year - birthDate.Year;
                if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
                {
                    age--;
                }
                return age;
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Person person1 = new Person();
                person1.Accept();
                person1.Print();

                Person person2 = new Person("Manisha", "Female", new DateTime(1990, 5, 15), "--");
                person2.Print();
            }
        }
    }
   


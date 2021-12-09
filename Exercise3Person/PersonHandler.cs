using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3Person
{
    public class PersonHandler
    {
        public List<Person> People;
        public PersonHandler()
        {
            People = new List<Person>();
        }
        public void SetAge(Person pers, int age) // Question 3.1.2
        {
            pers.Age = age;
        }
        public Person CreatePerson(int age, string fname, string lname, double height, double weight) // Question 3.1.3
        {
            Person person = new Person(age, fname, lname, height, weight);
            return person;
        }
        public void AddPerson()
        {
            Person per = new Person();
            Console.WriteLine("Ener Age :");
            int _Age = int.Parse(Console.ReadLine());
            per.Age = _Age;
            Console.WriteLine("Enter the First Name :");
            string _Fname = Console.ReadLine();
            per.Fname = _Fname;
            Console.WriteLine("Enter the Last Name :");
            string _Lname = Console.ReadLine();
            per.Lname = _Lname;
            Console.WriteLine("Enter the Height :");
            double _Height = double.Parse(Console.ReadLine());
            per.Height = _Height;
            Console.WriteLine("Enter the Weight :");
            double _Weight = double.Parse(Console.ReadLine());
            per.Weight = _Weight;
            People.Add(per);
        }
        public List<Person> GetPerson()
        {
            return People.ToList();
        }
    }
}

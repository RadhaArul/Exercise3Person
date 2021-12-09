using System;

namespace Exercise3Person
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instansiera en person i Program.cs, kommer du direkt åt variablerna?
            //I Can't directly access the private variables but by providing
            //public set and get methods through properties, i can access the private variables.
            try
            {
                //PersonHandler pers = new PersonHandler();
                //Person person = new Person(23,"Hans","Hågren",170,80); // Question 3.1.1
                //pers.SetAge(person, 31); // Question 3.1.2
                //person = pers.CreatePerson(1, "Sandra", "Höberg", 160, 55); // Question 3.1.3
                PersonHandler people = new PersonHandler();
                people.AddPerson();
                people.AddPerson();

                // Display all persons in the List
                var peoples = people.GetPerson();
                foreach (var p in peoples)
                {
                   Console.WriteLine(p.ToString());
                }
            }
            catch (ArgumentException e)
            {
                    Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}

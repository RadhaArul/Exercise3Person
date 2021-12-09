using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3Person
{
    public class Person
    {
        int age;
        string fName;
        string lName;
        double height;
        double weight;

        public int Age // Question 3.1.1
        {
            get => age;
            set => age = (value > 0) ? value : throw new ArgumentException("Invalid Age : Age should be greater than 0");
        }
        public string Fname
        {
            get { return fName; }
            set
            {
                if ((string.IsNullOrEmpty(value)) || (string.IsNullOrWhiteSpace(value)))
                    throw new ArgumentException("Invalid First Name : First Name should not be Empty");
                else if (value.Length < 2)
                    throw new ArgumentException("InValid First Name : sharacter's should be more than 2 characters");
                else if (value.Length > 10)
                    throw new ArgumentException("InValid First Name : character's should be less than 10 characters");
                else
                    fName = value;
            }
        }
        public string Lname
        {
            get => lName;
            set
            {
                if ((string.IsNullOrEmpty(value)) || (string.IsNullOrWhiteSpace(value)))
                    throw new ArgumentException("Invalid Last Name : Last Name should not be Empty");
                else if (value.Length < 3)
                    throw new ArgumentException("Invalid Last Name : character's should be more than 3 characters");
                else if (value.Length > 15)
                    throw new ArgumentException("In valid Last Name : character's should be less than 15 characters");
                else
                    lName = value;
            }
        }

        public double Height
        {
            get => height;
            set => height = value;
        }
        public double Weight
        { get => weight; set => weight = value; }

        public Person() { }

        public Person(int Age, string Fname, string Lname, double Height, double Weight)
        {
            this.Age = Age;
            this.Fname = Fname;
            this.Lname = Lname;
            this.Height = Height;
            this.Weight = Weight;
        }
        public override string ToString()
        {
            return $"Age :{age} FName : {fName} Lname : {lName} Height : {height} Weight : {weight}";
        }
    }
}

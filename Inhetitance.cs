using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPs__Concepts
{
    public class Person
    {
        private DateTime idtDOB;

        protected string istrGender;

        internal string istrMobile;

        public string istrFirstName;
        public string istrLastName;
        public string istrEmail;


        virtual public void show()
        {
            Console.WriteLine("i am inside of show method of class Person");
        }
    }
    public class student : Person 
    {
        public override void show()
        {
            Console.WriteLine("i am inside of show method of class Student");
        }
    }
    public class OutSideStudent : Person
    {
        
        public  override void show()
        {
            Console.WriteLine("i am inside of show method of class OutSideStudent");
        }
    }
    public class Staff : Person
    {
        public override void show()
        {
            Console.WriteLine("i am inside the show method of class Staff");
        }
    }
}

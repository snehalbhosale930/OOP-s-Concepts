using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPs__Concepts
{
    public class Static
    {
        public String istrname;
        public int  iintId;
        
        public Static()
        {
            Console.WriteLine("It is default constructor");
        }
        public Static(string astrname, int aintId)
        {
            Console.WriteLine("This is Parameterized Constructor");

            istrname = astrname;
            iintId = aintId;
            Console.WriteLine(istrname+" "+iintId);
        }
        static void display()
        {
            Console.WriteLine("This is static method");
            Console.WriteLine("**********");
        }
        static Static()
        {
            Console.WriteLine("It is static Constructor");
        }
    }
    static class static123
    {
        public static int Number;

        public static void show()
        {
            Console.WriteLine("It is static class");

            Number = 30;
            Console.WriteLine("Number = " + Number);
        }
        static static123()
        {
            Console.WriteLine("It is static constructor of Static123 class");
        }
    }
}

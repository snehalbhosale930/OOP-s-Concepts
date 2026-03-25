using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPs__Concepts
{
    internal class constructor
    {
        public int iintId;
        public string istrName;
        public string istrEmail;
        public static int sintobjectcount = 0;

        public constructor()  //This is default Constructor
        {
            istrName = "undefined";
            istrEmail = "undefined";
            Console.WriteLine("It is default constructor");
            sintobjectcount++;
            Console.WriteLine("Total object created : " + sintobjectcount);
        }

        public constructor(int aintId, string astrName, string astrEmail=null) //This is Parameterized constructor
        {
            iintId = aintId;
            istrName = astrName;
            istrEmail = astrEmail;
            Console.WriteLine("It is parameterized constructor");

            sintobjectcount++;
            Console.WriteLine("Total object created:" + sintobjectcount);
        }

        public void printvalues()
        {
            Console.WriteLine(iintId + "" + istrName + "" + istrEmail);
        }

        ~constructor()  //This is Destructor
        {
            Console.WriteLine("*******It is destructor");
            sintobjectcount--;
        }
    }
}

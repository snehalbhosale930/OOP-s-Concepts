using System;


namespace OOPs__Concepts
{
    internal class Program
    {
       // static Notification lobjNotification = new Email();
        static void Main(string[] args)
        {
            Student lobj = new Student();
            OutSideStudent lobj2 = new OutSideStudent();
            Staff lobj3 = new Staff();

            //lobjNotification.SendNotification();
            //lobjNotification.SendNotification();

            //Student();
            //constructordestructor();
            //TestGC();
            //new Static();
            //Static obj = new Static();
            //Static obj2 = new Static();
            //static123.show();
               
            Console.ReadLine();
        }

        public static void Student()
        {
            Console.WriteLine("This is simple class and object Program");

            Student lobj = new Student();
            lobj.getvalue(1, "ABC");
            lobj.printvalues();

            Student lobj2 = lobj;
            lobj.getvalue(2, "PQR", "pqr@gmail.com");
            lobj.printvalues();

        }
        public static void constructordestructor()
        {
            Console.WriteLine("This is Constructor and Destructor Program");
            constructor lobj = new constructor();

            constructor lobj2 = new constructor(1,"Sweety", "sweety123@gmail.com");
            lobj2.printvalues();

            constructor lobj3 = new constructor(2, "Ritu", "ritu456@gmail.com");
            lobj2.printvalues();
        }

        private static void TestGC()
        {
           
            for (int i = 0;i<1000; i++)
            {
                if(i % 100==0)
                {
                    GC.Collect();
                }
            }
        }

    }
}

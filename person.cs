using System;

namespace InClass3
{
    class person
    {

        int x, y;

        public person(int x)
        {
            this.x = x;


        }
        string firstName = " Dhruv";
        string lastName = " Dua ";
        string streetAddress = "Kirti Nagar";
        string city = "Delhi";
        string zipCode = "110015";
        double contactNo = 9503868855;


        static void Main(string[] args)
        {
           
            person p = new person(10);
            
            person p1 = new person(20);
           
            p = p1;
            person p2 = new person(100);
            Console.WriteLine(p.x);
            Console.WriteLine(p1.x);
            Console.WriteLine(p2.x);
            Console.ReadLine();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace InClass3
{
    class Banker : person
    {

        public Banker(int i) : base(i)
        {
            Console.WriteLine("Banker");
        }
        person brk = new person(12);
    }
}

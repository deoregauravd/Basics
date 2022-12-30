using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    internal class Arrays
    {
        public void Getoutput()
        {
            //string[] Car = new string[3]("baleno", "swift", "maruti");

            string[] Cars = new string[3] { "beleno", "swift", "maruti" };

            foreach (string car in Cars)
            {
                Console.WriteLine(car);
                // Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}

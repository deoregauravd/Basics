using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    internal class List
    {
        static void Main(string[] args)
        {
            List<string> vehicle = new List<string>(); //List<datatype> nameofdata = new List<int>()
            vehicle.Add("car");
            vehicle.Add("bike");
            vehicle.Add("bike");
          
/*
            foreach (var item in vehicle)
            {
                Console.WriteLine(item);
                //Console.ReadLine();
            }*/

            for(int i=0; i<=2; i++) // i<vehicle.Count; i++)
            {
                Console.WriteLine(vehicle[i]);
            }
            Console.ReadLine();

        }
        

    }
}

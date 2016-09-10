using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {


            Buildings.Controller.CityOperations cityOps = new Buildings.Controller.CityOperations();
            var saveResult = cityOps.AddCity("Buffalo", "New York");
            
            var result = cityOps.GetCity("Lincoln", "Nebraska");

              Console.Read();
            
        }
    }
}

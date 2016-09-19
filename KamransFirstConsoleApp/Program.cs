using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KamransFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(AddInts(5, 4));

            Console.WriteLine(AddInts(232, 553));
                 
            Console.ReadLine();

            //SimpleSquare.SimpleSquare s = new SimpleSquare.SimpleSquare();
            //s.GO(); 
        }
        public static int AddInts(int a,int b)
        {
            return a + b;
        }
        
    }
}

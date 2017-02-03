using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {

            Ano(7, 8);
            Console.ReadLine();




        }
        public static void  Ano(int a,int b)
        {
            if (a > b)
                Console.WriteLine(a); 
            else
                Console.WriteLine(b); ;
             

        }
    }
}

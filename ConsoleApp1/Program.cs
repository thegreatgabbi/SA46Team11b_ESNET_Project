using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime firstdate = Convert.ToDateTime("29/07/2018 18:00PM");
            TimeSpan ts = new TimeSpan(22, 00, 00);
            firstdate = firstdate.Date + ts;
            Console.WriteLine(firstdate);
            Console.ReadLine();
            
        }
    }
}

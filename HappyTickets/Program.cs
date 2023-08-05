using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTickets
{
    internal class Program
    {
        static string HappyTicket(string ticket) 
        {
            int ticket1 = Int32.Parse(ticket);
            int ticket0 = ticket1 - 1;
            int a = ticket0 % 10;
            int b = ticket0 / 10 % 10;
            int c = ticket0 / 100 % 10;
            int d = ticket0 / 1000 % 10;
            int e = ticket0 / 10000 % 10;
            int f = ticket0 / 100000;
            int g = a + b + c;
            int h = f + d + e;
            int i = g - h;
            int ticket01 = ticket1 + 1;
            int a1 = ticket01 % 10;
            int b1 = ticket01 / 10 % 10;
            int c1 = ticket01 / 100 % 10;
            int d1 = ticket01 / 1000 % 10;
            int e1 = ticket01 / 10000 % 10;
            int f1 = ticket01 / 100000;
            int g1 = a1 + b1 + c1;
            int h1 = f1 + d1 + e1;
            int i1 = g1 - h1;
            if ((i == 0) || (i1 == 0))
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
        static void Main(string[] args)
        {
            string ticket = HappyTicket("172542");
            Console.WriteLine(ticket);
            Console.ReadKey();
        }
    }
}

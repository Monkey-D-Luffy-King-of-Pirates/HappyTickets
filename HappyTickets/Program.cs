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
            int j = h - g;
            if ((i == 1) || (j == 1))
            {
                return "This ticket is happy";
            }
            else
            {
                return "This ticket is unhappy";
            }
        }
        static string HappyTicket0(string ticket)
        {
            int ticket1 = Int32.Parse(ticket);
            int ticket0 = ticket1 + 1;
            int a1 = ticket0 % 10;
            int b1 = ticket0 / 10 % 10;
            int c1 = ticket0 / 100 % 10 ;
            int d1 = ticket0 / 1000 % 10;
            int e1 = ticket0 / 10000 % 10;
            int f1 = ticket0 / 100000;
            int g1 = a1 + b1 + c1;
            int h1 = f1 + d1 + e1;
            int i1 = g1 - h1;
            int j1 = h1 - g1;
            if ((i1 == 1) || (j1 == 1))
            {
                return "This ticket is happy";
            }
            else
            {
                return "This ticket is unhappy";
            }
        }
        static void Main(string[] args)
        {
            string ticket = HappyTicket("666664");
            string ticket0 = HappyTicket0("666664");
            Console.WriteLine(ticket);
            Console.WriteLine(ticket0);
            Console.ReadKey();
        }
    }
}

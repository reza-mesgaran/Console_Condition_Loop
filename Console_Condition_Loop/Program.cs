using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Condition_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            ////------------ Dead Loop
            //while(true)
            //{
            //    Console.WriteLine("Dead Loop");
            //}
            
            //------------ Prefix-increment operator  (First Compare then Increase)
            //int x = 0;
            //while (x++<10)
            //{
            //    Console.WriteLine(x);
            //}
            ////------------ Postfix-increment operator (First Increase Then Compare)
            //int y = 0;
            //while(++y<10)
            //{
            //    Console.WriteLine(y);
            //}
            
            //------------ For-Loop (Syntax)
            for(int x=0; x<10;x++)
            {
                Console.WriteLine(x);
            }
            //------------ For-Loop (semicolons are mandatory)
            int y = 0;
            for(;y<10;)
            {
                Console.WriteLine(y);
                y = y + 1;
            }
            Console.ReadKey();
            //------------
        }
    }
}

using System;

namespace Console_Condition_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------ Prefix-increment operator  (First Compare then Increase)
            int x = 0;
            while (x++ < 10)
            {
                Console.WriteLine(x);
            }

            //------------ Postfix-increment operator (First Increase Then Compare)
            int y = 0;
            while (++y < 10)
            {
                Console.WriteLine(y);
            }

            //------------ For-Loop (Syntax)
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine(x);
            }

            //------------ For-Loop (semicolons are mandatory)
            int y = 0;
            for (; y < 10;)
            {
                Console.WriteLine(y);
                y = y + 1;
            }

            //------------ Break (Jump-Out the Loops)
            int x = 0;
            while (x < 10)
            {
                if (x == 5)
                {
                    break;  // When x=5 => Exit from While-Loop 
                }
                Console.WriteLine(x);
                x++;
            }

            //------------ Continue (Just skips the remaining statements of that iteration of the loop.)
            Console.WriteLine("-------------------------------");
            int y = 0;
            while (y < 10)
            {
                y++;
                if (y == 5)
                {
                    continue;  // When Y=5 => leave current iteration and Go for next iteration
                }
                Console.WriteLine(y);
            }
            
            //------------ The conditional operator :?
            int z = 10;
            string Message = (z > 5) ? "Bigger" : "Smaller";
            Console.WriteLine(Message);
            Console.ReadKey();
            
            //------------ Infinite Loop
            while (true)
            {
                Console.WriteLine("Dead Loop");
            }
        }
    }
}

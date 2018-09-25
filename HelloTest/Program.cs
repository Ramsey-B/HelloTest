using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int RandNum = GenerateRandNum();
            Boolean playing = true;

            Console.WriteLine("Pick a number between 1 and 10");

            while(playing)
            {
                string usersGuess = Console.ReadLine();
                
                if(usersGuess == "end")
                {
                    playing = false;
                } 
                else
                {
                    int usersNum;
                    int.TryParse(usersGuess, out usersNum);
                    ValidateGuess(usersNum, RandNum);
                }
            }
        }

        private static int GenerateRandNum()
        {
            Random rnd = new Random();
            return rnd.Next(1, 11);
        }

        private static void ValidateGuess(int usersNum, int RandNum)
        {
            if (usersNum == RandNum)
            {
                Console.WriteLine("Good Guess!!!");
            }
            else if (usersNum > 10 || usersNum < 1)
            {
                Console.WriteLine("invalid guess...");
            }
            else if (usersNum > RandNum)
            {
                Console.WriteLine("Too High!");
            }
            else if (usersNum < RandNum)
            {
                Console.WriteLine("Too Low!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Player p2 = new RandomPlayer();//to call the diffrent players add there name after new
            HangmanGame hg = new HangmanGame(p2);
            Console.WriteLine();
        }
    }
}

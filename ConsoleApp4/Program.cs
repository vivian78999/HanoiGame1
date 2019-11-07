using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4 
{
   public class program    
    {
        static void Main(string[] args)
        {  
            HanoiGame game = new HanoiGame();
            game.Setup();
            game.Play();

            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            string[] players = new string[5]; // it stores 5 values

            Console.WriteLine(luckyNumbers[0]);

            luckyNumbers[1] = 900;

            Console.WriteLine(luckyNumbers[1]);

            //Populate array

            players[0] = "Ronaldo";
            players[1] = "Messi";
            players[2] = "Mbappe";
            players[3] = "Neymar";
            players[4] = "Bruno Fernandes";

            Console.WriteLine(players[4]);

            Console.ReadLine();
        }
    }
}

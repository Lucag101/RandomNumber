using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Hi! Bienvenidos al juego de los dados (dice game) \n");
            Console.Write("Please enter the number of times you want me to roll the dice: ");
            int diceNum = int.Parse(Console.ReadLine());
            Random r = new Random();
            
            int[] rollTotals = new int[12];

            for (int i = 0; i < diceNum; i++)
            {
                int roll1 = r.Next(1,7);
                int roll2 = r.Next(1, 7);
                int addRolls = roll1 + roll2 -1;
                
                rollTotals[addRolls]++;
            }
          
            for (int counter = 0; counter < 12; counter++)
            {
                int dicePerc = (rollTotals[counter] * 100)/diceNum;
                string asterick = "";

                for (int i = 0; i < dicePerc; i++)
                {
                    asterick = asterick + '*';
                }

                Console.WriteLine(counter+1 + ": " + asterick);
            }

            Console.WriteLine("Gracias por su participation");

        }
    }
}

using System;

namespace ticcyToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = {"1" , "2", "3", "4", "5", "6", "7", "8", "9"};
            string[] xOrO = {"O","X"};

            for (int i=0; i<10; i++)
            {
                string temp = xOrO[0];
                xOrO[0] = xOrO[1];
                xOrO [1] = temp;

                Console.WriteLine("Which spot would you like to mark, {0}?",xOrO[0]);
                string chosenSpot;
                chosenSpot = Console.ReadLine();

                if (chosenSpot == "X")
                {
                    Console.WriteLine("That spot is already taken!");
                }
                else
                {
                    array[chosenSpot] = xOrO[0];
                }
            }

        }
    }
}

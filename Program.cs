using System;

namespace ticcyToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] board = {"1" , "2", "3", "4", "5", "6", "7", "8", "9"};
            string[] xOrO = {"O","X"};

            for (int i=0; i<9; i++)
            {
                string temp = xOrO[0];
                xOrO[0] = xOrO[1];
                xOrO [1] = temp;

                
                Console.WriteLine("Which spot would you like to mark, {0}?",xOrO[0]);
                string chosenSpot;
                chosenSpot = Console.ReadLine();

                if (board[Convert.ToInt32(chosenSpot)] == "X" || board[Convert.ToInt32(chosenSpot)] == "O")
                {
                    Console.WriteLine("That spot is already taken!");
                    notMain(board, xOrO);
                }
                else
                {
                    board[Convert.ToInt32(chosenSpot)] = xOrO[0];
                }
            }

        }
        static void notMain(string[] board,string[] xOrO)
        {
            Console.WriteLine("Which spot would you like to mark, {0}?",xOrO[0]);
                string chosenSpot;
                chosenSpot = Console.ReadLine();

                if (board[Convert.ToInt32(chosenSpot)] == "X" || board[Convert.ToInt32(chosenSpot)] == "O")
                {
                    Console.WriteLine("That spot is already taken!");
                }
        }
    }
}

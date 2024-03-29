using System;

namespace ticcyToe
{
    class Program
    {
        
         //draw board method
         static void DrawBoard(string[] args){
           
           char[,] drawBoard = new char [3,3];
           drawBoard[0,0]= 'X';
           drawBoard[2,2]= 'O';

           for(int row=0; row<3; row++){
               Console.Write("| ");
               for(int col= 0; col<3; col++)
               {
                   Console.Write(drawBoard[row, col]);
                   Console.Write(" | ");
               }
               Console.WriteLine();
           }
        }

        //check spot
        static void CheckSpot(string[] board,string[] xOrO){
            Console.WriteLine("Which spot would you like to mark, {0}?",xOrO[0]);
                string chosenSpot;
                chosenSpot = Console.ReadLine();

                if (board[Convert.ToInt32(chosenSpot)] == "X" || board[Convert.ToInt32(chosenSpot)] == "O"){
                    Console.WriteLine("That spot is already taken!");
                }
        }

        //////check win methods

        //HorWin
        //win = true;

        //VerWin
        //win =true;

        //DiWin
        //win = true;


        //main method
        static void Main(string[] args){

            //intro
            Console.WriteLine("You will play a game of ticcy toe with a partner. X goes first");
         
            //defining things
            string[] board = {"1" , "2", "3", "4", "5", "6", "7", "8", "9"};
            string[] xOrO = {"O","X"};
            

            //turns
            for (int i=0; i<9; i++){
                string temp = xOrO[0];
                xOrO[0] = xOrO[1];
                xOrO [1] = temp;
            
            //take sport
            Console.WriteLine("Which spot would you like to mark, {0}?",xOrO[0]);
            string chosenSpot = Console.ReadLine();

            if (board[Convert.ToInt32(chosenSpot)] == "X" || board[Convert.ToInt32(chosenSpot)] == "O")
                {
                    Console.WriteLine("That spot is already taken!");
                    CheckSpot(board, xOrO);
                }
                else
                {
                    board[Convert.ToInt32(chosenSpot)] = xOrO[0];
                }


            }
        

        }
    }
}

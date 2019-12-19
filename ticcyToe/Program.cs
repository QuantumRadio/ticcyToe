using System;

namespace ticcyToe
{
    class Program
    {
        
        //draw board method
        static void DrawBoard(string[] board){  
            string[,] drawBoard = new string[3,3];
            drawBoard[0,0] = board[0];
            drawBoard[0,1] = board[1];
            drawBoard[0,2] = board[2];
            drawBoard[1,0] = board[3];
            drawBoard[1,1] = board[4];
            drawBoard[1,2] = board[5];
            drawBoard[2,0] = board[6];
            drawBoard[2,1] = board[7];
            drawBoard[2,2] = board[8];

            for(int row=0; row<3; row++)
            {
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
        static void CheckSpot(string[] board, string[] xOrO){
            Console.WriteLine("Which spot would you like to mark, {0}?", xOrO[0]);
            string chosenSpot;
            chosenSpot = Console.ReadLine();

            if (board[Convert.ToInt32(chosenSpot)] == "X" || board[Convert.ToInt32(chosenSpot)] == "O"){
                Console.WriteLine("That spot is already taken!");
            }

        }

        //check win methods
        static void Wins(string[] board, string[] xOrO)
        {
        
        //horizontal win
        if ((String.Equals(board[0], board[1]) && String.Equals(board[1], board[2])) ||
            (String.Equals(board[3], board[4]) && String.Equals(board[4], board[5])) ||
            (String.Equals(board[6], board[7]) && String.Equals(board[7], board[8])))
            {
                Console.WriteLine("Congratulations! Player {0} wins!", xOrO[1]); 
            }


        //vertical win
        else if ((String.Equals(board[0], board[3]) && String.Equals(board[3], board[6])) ||
                 (String.Equals(board[1], board[4]) && String.Equals(board[4], board[7])) ||
                 (String.Equals(board[2], board[5]) && String.Equals(board[5], board[8])))
            {
                Console.WriteLine("Congratulations! Player {0} wins!", xOrO[1]); 
            }

        //diagonal win
        else if ((String.Equals(board[0], board[4]) && String.Equals(board[4], board[8])) ||
                 (String.Equals(board[2], board[4]) && String.Equals(board[4], board[6])))
            {
                Console.WriteLine("Congratulations! Player {0} wins!", xOrO[1]); 
            }
        }
        
        static void Main(string[] args){

            //intro
            Console.WriteLine("You will play a game of ticcy toe with a partner. X goes first");
            
            //defining things
            string[] board = new string[9];
            for (int i=0; i<9;i++)
            {
                board[i] = Convert.ToString(i+1);
            }
            string[] xOrO = {"O","X"};
            

            //turns
            for (int i=0; i<9; i++){

                Wins();
                string temp = xOrO[0];
                xOrO[0] = xOrO[1];
                xOrO[1] = temp;

                DrawBoard();
            
                //take spot
                Console.WriteLine("Which spot would you like to mark, {0}?", xOrO[0]);
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

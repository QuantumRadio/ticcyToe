using System;

namespace ticcyToe
{
    class Program
    {
        
         static void drawBoard(string[] args){
           
           char[,] board = new char [3,3];
           board[0,0]= 'X';
           board[2,2]= 'O';

           for(int row=0; row<3; row++){
               Console.Write("| ");
               for(int col= 0; col<3; col++)
               {
                   Console.Write(board[row, col]);
                   Console.Write(" | ");
               }
               Console.WriteLine();
           }
        }

        
        
        
    }
}

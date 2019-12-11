using System;

namespace ticcyToe
{
    class Program
    {
        
         //draw board method
         static void DrawBoard(string[] args){
           
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

        //////check win methods

        //HorWin
        //win = true;

        //VerWin
        //win =true;

        //DiWin
        //win = true;


        //main method
        static void Main(string[] args){

            Console.WriteLine("You will play a game of ticcy toe with a partner. X goes first");

            bool win=false;

            if(win==false){

                //keep playing
                 for(int i=0; i<10; i++){
                    //ask the player for spot
                    Console.WriteLine("Which spot would you like to mark?");
                    string chosenSpot = Console.ReadLine();

                    //user_proof
                    if(chosenSpot != "1" || chosenSpot!= "2"||chosenSpot!="3"||chosenSpot!="4"||chosenSpot!="5"||chosenSpot!="6"||chosenSpot!="7"||chosenSpot!="8"||chosenSpot!="9"){
                   Console.WriteLine("Please choose only from numbers 1 to 9");
                   }

                    //check if spot is not taken

                }

            }
            
           
            /* string array[] = {'1' , '2', '3', '4', '5', '6', '7', '8', '9'};
            string[] xOrO = [O,X]; */

            drawBoard(args);

            /* for (int i=0; i<10; i++)
            {
                string temp = xOrO[0];
                xOrO[0] = xOrO[1];
                xOrO [1] = temp;

                Console.Writeline("Which spot would you like to mark, {0}?",xOrO[0]);
                int chosenSpot= 0;
                chosenSpot = Console.ReadLine();
                array[chosenSpot] = xOrO;
            } */

        }
    }
}

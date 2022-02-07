using System;
using System.Collections.Generic;
using System.Text;

namespace TicTackToe
{
    class Board
    {
        public static string[,] board =
            {
            {"1","2","3"},
            {"4","5","6"},
            {"7","8","9"}
            };

        public static bool winningStatus;
        public static bool gameContinues = true;
        public static string winner;

        public static void ShowBoard()
        {
            // first row displayed

            Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write("|");
            Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write("|");
            Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write("\n");

            Console.Write(" "); Console.Write(" "); Console.Write(board[0, 0]); Console.Write(" "); Console.Write(" "); Console.Write("|");
            Console.Write(" "); Console.Write(" "); Console.Write(board[0, 1]); Console.Write(" "); Console.Write(" "); Console.Write("|");
            Console.Write(" "); Console.Write(" "); Console.Write(board[0, 2]); Console.Write(" "); Console.Write(" "); Console.Write("\n");

            Console.Write("_"); Console.Write("_"); Console.Write("_"); Console.Write("_"); Console.Write("_"); Console.Write("|");
            Console.Write("_"); Console.Write("_"); Console.Write("_"); Console.Write("_"); Console.Write("_"); Console.Write("|");
            Console.Write("_"); Console.Write("_"); Console.Write("_"); Console.Write("_"); Console.Write("_"); Console.Write("\n");

            // second row displayed

            Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write("|");
            Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write("|");
            Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write(" \n");

            Console.Write(" "); Console.Write(" "); Console.Write(board[1, 0]); Console.Write(" "); Console.Write(" "); Console.Write("|");
            Console.Write(" "); Console.Write(" "); Console.Write(board[1, 1]); Console.Write(" "); Console.Write(" "); Console.Write("|");
            Console.Write(" "); Console.Write(" "); Console.Write(board[1, 2]); Console.Write(" "); Console.Write(" "); Console.Write(" \n");

            Console.Write("_"); Console.Write("_"); Console.Write("_"); Console.Write("_"); Console.Write("_"); Console.Write("|");
            Console.Write("_"); Console.Write("_"); Console.Write("_"); Console.Write("_"); Console.Write("_"); Console.Write("|");
            Console.Write("_"); Console.Write("_"); Console.Write("_"); Console.Write("_"); Console.Write("_"); Console.Write(" \n");

            // third row displayed

            Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write("|");
            Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write("|");
            Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write(" \n");

            Console.Write(" "); Console.Write(" "); Console.Write(board[2, 0]); Console.Write(" "); Console.Write(" "); Console.Write("|");
            Console.Write(" "); Console.Write(" "); Console.Write(board[2, 1]); Console.Write(" "); Console.Write(" "); Console.Write("|");
            Console.Write(" "); Console.Write(" "); Console.Write(board[2, 2]); Console.Write(" "); Console.Write(" "); Console.Write("  \n");

            Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write("|");
            Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write("|");
            Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write(" "); Console.Write(" \n");
        }

        public static void BoardCheck()
        {
            if (
                board[0, 0] == "X" && board[0, 1] == "X" && board[0, 2] == "X" ||
                board[1, 0] == "X" && board[1, 1] == "X" && board[1, 2] == "X" ||
                board[2, 0] == "X" && board[2, 1] == "X" && board[2, 2] == "X" ||
                board[0, 0] == "X" && board[1, 0] == "X" && board[2, 0] == "X" ||
                board[0, 1] == "X" && board[1, 1] == "X" && board[2, 1] == "X" ||
                board[0, 2] == "X" && board[1, 2] == "X" && board[2, 2] == "X" ||
                board[0, 0] == "X" && board[1, 1] == "X" && board[2, 2] == "X" ||
                board[0, 2] == "X" && board[1, 1] == "X" && board[2, 0] == "X"

                )
            {
                
                winningStatus = true;
                gameContinues = false;
                winner = "Player One";

            }
            else if (

                board[0, 0] == "O" && board[0, 1] == "O" && board[0, 2] == "O" ||
                board[1, 0] == "O" && board[1, 1] == "O" && board[1, 2] == "O" ||
                board[2, 0] == "O" && board[2, 1] == "O" && board[2, 2] == "O" ||
                board[0, 0] == "O" && board[1, 0] == "O" && board[2, 0] == "O" ||
                board[0, 1] == "O" && board[1, 1] == "O" && board[2, 1] == "O" ||
                board[0, 2] == "O" && board[1, 2] == "O" && board[2, 2] == "O" ||
                board[0, 0] == "O" && board[1, 1] == "O" && board[2, 2] == "O" ||
                board[0, 2] == "O" && board[1, 1] == "O" && board[2, 0] == "O"

                )
            {
                
                winningStatus = true;
                gameContinues = false;
                winner = "Player Two";

            }
            else if (Program.roundCount > 9 || Program.roundCount == 9)
            {
                gameContinues = false;
                winner = "Stalemate!";
                
                
                
            }




            
                
        }
    }
}

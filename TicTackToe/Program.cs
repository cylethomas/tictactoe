using System;

namespace TicTackToe
{
    class Program
    {
        public static string player;
        public static int roundCount = 0;

        static void Main(string[] args)
        {
            
            int playerOneRound = 0;
            int playerTwoRound = 0;
            

            while(Board.gameContinues)
            {
                // this needs to be edited to stop when someone wins
                // this needs to be edited to stop at 9 goes?
                Console.WriteLine("Let's Play!!! Tic Tac Toe!!!");
                Console.WriteLine();
                Board.ShowBoard();
                
                player = "playerOne";
                Program.roundCount = Program.roundCount + 1;
                playerOneRound = playerOneRound + 1;
                

                
                MenuChoiceOne();

                Board.BoardCheck();

                



                Console.Clear();

                if (roundCount > 9 || roundCount == 9 || Board.gameContinues == false)
                {
                    break;
                }








                Console.WriteLine("Let's Play!!! Tic Tac Toe!!!");
                Console.WriteLine();
                Board.ShowBoard();

                player = "playerTwo";
                // displays menu, and prompts a choice
                Program.roundCount = Program.roundCount + 1;
                playerTwoRound = playerTwoRound + 1;
                Board.BoardCheck();

                
                
                MenuChoiceTwo();

                Board.BoardCheck();

                

                Console.Clear();


                
                

                






            }

            Console.Clear();
            
            Console.WriteLine("Thank you for playing Cyle's Tic Tac Toe!");
            Board.ShowBoard();
            
            if(Board.winner == "Stalemate!")
            {
                Console.WriteLine("Draw! This game ends in a stalemate! Good luck nextime players!");
            }
            else
            {
                Console.WriteLine("Congratulations {0}, you win!", Board.winner);
            }
            

            if(Board.winner == "Player One")
            {
                Console.WriteLine("It took {0} {1} moves to win.", player, playerOneRound);
                Console.WriteLine("It took {0} rounds for the game to end.", roundCount);
            }
            else if (Board.winner == "Player Two")
            {
                Console.WriteLine("It took {0} {1} moves to win.", player, playerTwoRound);
                Console.WriteLine("It took {0} rounds for the game to end.", roundCount);
            }
            else
            {
                Console.WriteLine("It took {0} rounds for the game to end.", roundCount);
            }
                
            
                        

            void MenuChoiceOne()
            {

                string menuChoice;

                Board.BoardCheck();
                


                Console.WriteLine();
                    Console.Write("Player1. Please choose a position to place your X : ");
                    menuChoice = Console.ReadLine();

                    if(menuChoice == "1" || 
                       menuChoice == "2" ||
                       menuChoice == "3" ||
                       menuChoice == "4" ||
                       menuChoice == "5" ||
                       menuChoice == "6" ||
                       menuChoice == "7" ||
                       menuChoice == "8" ||
                       menuChoice == "9" 
                       )
                    {

                    // position check
                        switch (menuChoice)
                        {
                            case "1":
                            if(Board.board[0, 0] == "X" || Board.board[0, 0] == "O")
                            {
                                positionCheckOne();
                            }
                            else
                            {
                                Board.board[0, 0] = "X";
                            }
                                
                                break;

                            case "2":
                            if (Board.board[0, 1] == "X" || Board.board[0, 1] == "O")
                            {
                                positionCheckOne();
                            }
                            else
                            {
                                Board.board[0, 1] = "X";
                            }
                            
                                break;

                            case "3":
                            if (Board.board[0, 2] == "X" || Board.board[0, 2] == "O")
                            {
                                positionCheckOne();
                            }
                            else
                            {
                                Board.board[0, 2] = "X";
                            }
                            
                                break;
                            
                        case "4":
                            if (Board.board[1, 0] == "X" || Board.board[1, 0] == "O")
                            {
                                positionCheckOne();
                            }
                            else
                            {
                                Board.board[1, 0] = "X";
                            }
                            
                                break;

                            case "5":
                            if (Board.board[1, 1] == "X" || Board.board[1, 1] == "O")
                            {
                                positionCheckOne();
                            }
                            else
                            {
                                Board.board[1, 1] = "X";
                            }
                            
                                break;

                            case "6":
                            if (Board.board[1, 2] == "X" || Board.board[1, 2] == "O")
                            {
                                positionCheckOne();
                            }
                            else
                            {
                                Board.board[1, 2] = "X";
                            }
                           
                                break;

                            case "7":
                            if (Board.board[2, 0] == "X" || Board.board[2, 0] == "O")
                            {
                                positionCheckOne();
                            }
                            else
                            {
                                Board.board[2, 0] = "X";
                            }
                           
                                break;

                            case "8":
                            if (Board.board[2, 1] == "X" || Board.board[2, 1] == "O")
                            {
                                positionCheckOne();
                            }
                            else
                            {
                                Board.board[2, 1] = "X";
                            }
                            
                                break;

                            case "9":
                            if (Board.board[2, 2] == "X" || Board.board[2, 2] == "O")
                            {
                                positionCheckOne();
                            }
                            else
                            {
                                Board.board[2, 2] = "X";
                            }
                            
                                break;
                            default:
                                break;
                        }
                    }else
                    {
                    Console.Clear();
                    Console.WriteLine("Let's Play!!! Tic Tac Toe!!!");
                    Console.WriteLine();
                    Board.ShowBoard();
                    Console.WriteLine("Please choose a number between 1-9");
                    MenuChoiceOne();
                    }

                    
            }

            void MenuChoiceTwo()
            {

                string menuChoice;

                Board.BoardCheck();

                Console.WriteLine();
                    Console.Write("Player2. Please choose a position to place your O : ");
                    menuChoice = Console.ReadLine();

                if (menuChoice == "1" ||
                   menuChoice == "2" ||
                   menuChoice == "3" ||
                   menuChoice == "4" ||
                   menuChoice == "5" ||
                   menuChoice == "6" ||
                   menuChoice == "7" ||
                   menuChoice == "8" ||
                   menuChoice == "9"
                   )
                {

                    switch (menuChoice)
                    {
                        case "1":
                            if (Board.board[0, 0] == "X" || Board.board[0, 0] == "O")
                            {
                                positionCheckTwo();
                            }
                            else
                            {
                                Board.board[0, 0] = "O";
                            }

                            break;

                        case "2":
                            if (Board.board[0, 1] == "X" || Board.board[0, 1] == "O")
                            {
                                positionCheckTwo();
                            }
                            else
                            {
                                Board.board[0, 1] = "O";
                            }

                            break;

                        case "3":
                            if (Board.board[0, 2] == "X" || Board.board[0, 2] == "O")
                            {
                                positionCheckTwo();
                            }
                            else
                            {
                                Board.board[0, 2] = "O";
                            }

                            break;

                        case "4":
                            if (Board.board[1, 0] == "X" || Board.board[1, 0] == "O")
                            {
                                positionCheckTwo();
                            }
                            else
                            {
                                Board.board[1, 0] = "O";
                            }

                            break;

                        case "5":
                            if (Board.board[1, 1] == "X" || Board.board[1, 1] == "O")
                            {
                                positionCheckTwo();
                            }
                            else
                            {
                                Board.board[1, 1] = "O";
                            }

                            break;

                        case "6":
                            if (Board.board[1, 2] == "X" || Board.board[1, 2] == "O")
                            {
                                positionCheckTwo();
                            }
                            else
                            {
                                Board.board[1, 2] = "O";
                            }

                            break;

                        case "7":
                            if (Board.board[2, 0] == "X" || Board.board[2, 0] == "O")
                            {
                                positionCheckTwo();
                            }
                            else
                            {
                                Board.board[2, 0] = "O";
                            }

                            break;

                        case "8":
                            if (Board.board[2, 1] == "X" || Board.board[2, 1] == "O")
                            {
                                positionCheckTwo();
                            }
                            else
                            {
                                Board.board[2, 1] = "O";
                            }

                            break;

                        case "9":
                            if (Board.board[2, 2] == "X" || Board.board[2, 2] == "O")
                            {
                                positionCheckTwo();
                            }
                            else
                            {
                                Board.board[2, 2] = "O";
                            }

                            break;
                        default:
                            break;

                    }

                }else
                {
                    Console.Clear();
                    Console.WriteLine("Let's Play!!! Tic Tac Toe!!!");
                    Console.WriteLine();
                    Board.ShowBoard();
                    Console.WriteLine("Please choose a number between 1-9");
                    MenuChoiceTwo();
                }

            }

            void positionCheckOne()
            {
                Console.Clear();
                Console.WriteLine("Let's Play!!! Tic Tac Toe!!!");
                Console.WriteLine();
                Board.ShowBoard();
                Console.WriteLine("That positon is already taken! Choose another positon between 1-9");
                MenuChoiceOne();
            }

            void positionCheckTwo()
            {
                Console.Clear();
                Console.WriteLine("Let's Play!!! Tic Tac Toe!!!");
                Console.WriteLine();
                Board.ShowBoard();
                Console.WriteLine("That positon is already taken! Choose another positon between 1-9");
                MenuChoiceTwo();
            }
        }
        









        
    }
}

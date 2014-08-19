using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.RV.LIB;
namespace day1
{
    class TicTacToe
    {
        char[] players=new char[]{'O','X'};
        static bool win = false;
        static char[,] board = new char[3, 3]{{' ',' ',' '},{' ',' ',' '},{' ',' ',' '}};
        static void Main(string[] args)
        {
            char player = 'O';
            while (!isBoardFull() && win == false)
            {
                displayBoard();
                enterPosition(player);
                checkWinning();

                if (player == 'X')
                {
                    player = 'O';
                }
                else
                {
                    player = 'X';
                }
                
            }
            displayBoard();
            if (isBoardFull())
            {
                System.Console.WriteLine("Board is full");
            }            
        }

        static void displayBoard()
        {
            Console.WriteLine("  A B C");
            int m = 1;
            for (int i = 0; i < 3; i++)
            {
                Console.Write(m+++" ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j] + "|");
                }
                Console.WriteLine("\n----------");

            }
        }

        static void enterPosition(char side)
        {
            bool valid = false;
            int i=0,j=0;
            do
            {
                bool input_invalid = false;
                Console.Write(side + " your turn:");
                string move = ISSConsole.ReadString();

                switch (move)
                {
                    case "A1":
                        i = 0;
                        j = 0;
                        break;
                    case "A2":
                        i = 1;
                        j = 0;
                        break;
                    case "A3":
                        i = 2;
                        j = 0;
                        break;
                    case "B1":
                        i = 0;
                        j = 1;
                        break;
                    case "B2":
                        i = 1; 
                        j = 1;
                        break;
                    case "B3":
                        i = 2;
                        j = 1;
                        break;
                    case "C1":
                        i = 0;
                        j = 2;
                        break;
                    case "C2":
                        i = 1;
                        j = 2;
                        break;
                    case "C3":
                        i = 2;
                        j = 2;
                        break;
                    default:
                        input_invalid = true;
                        Console.WriteLine("Please enter a valid input");
                        break;
                }
                if (input_invalid == false)
                {
                    if (board[i, j] != ' ')
                    {
                        Console.WriteLine("That position is not empty. enter again");
                    }
                    else
                    {
                        board[i, j] = side;
                        valid = true;
                    }
                }
            } while (valid == false);
        }

        static bool isBoardFull()
        {
            bool boardFull = false;
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] != ' ')
                    {
                        ++count;
                    }
                }
            }
            if(count==9)
            {
                boardFull = true;
            }
            return boardFull;
        }

        static void checkWinning()
        {
            char[] players = new char[] { 'O', 'X' };
            int count;

            for (int p = 0; p < players.Length; p++)
            {
                for (int i = 0; i < 3; i++)
                {
                    count = 0;
                    for (int j = 0; j < 3; j++)
                    {
                        if (players[p] == board[i, j])
                        {
                            ++count;
                        }
                    }
                    if (count == 3)
                    {
                        Console.WriteLine("Game " + players[p]);
                        win = true;
                        return;
                    }
                }

                for (int k = 0; k < 3; k++)
                {
                    count = 0;
                    for (int m = 0; m < 3; m++)
                    {
                        if (players[p] == board[m, k])
                        {
                            ++count;
                        }
                    }
                    if (count == 3)
                    {
                        Console.WriteLine("Game " + players[p]);
                        win = true;
                        return;
                    }
                }

                count = 0;
                for (int n = 0; n < 3; n++)
                {
                    if (players[p] == board[n, n])
                    {
                        ++count;
                    }
                }

                if (count == 3)
                {
                    Console.WriteLine("Game " + players[p]);
                    win = true;
                    return;
                }

                count = 0;
                int x=0;
                for (int y = 2; y >= 0; y--)
                {
                    if (players[p] == board[x++, y])
                    {
                        ++count;
                    }
                }
                if (count == 3)
                {
                    Console.WriteLine("Game " + players[p]);
                    win = true;
                    return;
                }
            }
        }
    }
}

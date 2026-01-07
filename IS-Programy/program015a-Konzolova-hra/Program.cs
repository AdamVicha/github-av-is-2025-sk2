using System;

namespace TicTacToe
{
    class Program
    {
        static char[,] board = new char[9, 9];
        static char playerX = 'X';
        static char playerO = 'O';
        static char currentPlayer = playerX;

        static void Main(string[] args)
        {
            InitializeBoard();

            while (true)
            {
                DrawBoard();
                Console.WriteLine($"Hraje hráč {currentPlayer}, napiš svůj tah (řádek sloupec):");
                string input = Console.ReadLine();
                string[] coordinates = input.Split(' ');

                int row = int.Parse(coordinates[0]);
                int col = int.Parse(coordinates[1]);

                if (MakeMove(row, col))
                {
                    if (CheckWin())
                    {
                        DrawBoard();
                        Console.WriteLine($"Hráč {currentPlayer} vyhrál!");
                        break;
                    }
                    else if (CheckTie())
                    {
                        DrawBoard();
                        Console.WriteLine("Remíza!");
                        break;
                    }
                    else
                    {
                        currentPlayer = (currentPlayer == playerX) ? playerO : playerX;
                    }
                }
                else
                {
                    Console.WriteLine("Špatný tah, zkus to znova.");
                }
            }
            Console.WriteLine("Pro ukončení stiskněte jakékoli tlačítko...");
            Console.ReadKey();
        }

        static void InitializeBoard()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    board[row, col] = '-';
                }
            }
        }

        static void DrawBoard()
        {
            Console.Clear();
            Console.WriteLine("  0 1 2 3 4 5 6 7 8");
            for (int row = 0; row < 9; row++)
            {
                Console.Write($"{row} ");
                for (int col = 0; col < 9; col++)
                {
                    Console.Write($"{board[row, col]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static bool MakeMove(int row, int col)
        {
            if (row < 0 || row > 8 || col < 0 || col > 8)
            {
                return false;
            }
            if (board[row, col] != '-')
            {
                return false;
            }

            board[row, col] = currentPlayer;
            return true;
        }

        static bool CheckWin()
        {
            for (int i = 0; i < 4; i++)
            {
                // řádek
                if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
                {
                    return true;
                }

                // sloupec
                if (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer)
                {
                    return true;
                }
            }

            // diagonálně
            if (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer)
            {
                return true;
            }
            if (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer)
            {
                return true;
            }

            return false;
        }

        static bool CheckTie()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (board[row, col] == '-')
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
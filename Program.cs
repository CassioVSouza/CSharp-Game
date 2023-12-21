using __Game;

namespace CSharpGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Board bBoard = new Board();
            Console.WriteLine("Welcome to Tic Tac Toe Game!");
            {
                do
                {
                    bBoard.ShowBoard(bBoard);

                    PlayerPlay(bBoard);

                    if (CheckWinner(bBoard)) 
                    {
                        break; 
                    }
                    if (CheckTie(bBoard)) 
                    {
                        Console.WriteLine("It's a tie!");
                        break; 
                    }
                    ComputerPlay(bBoard); 
                    if (CheckWinner(bBoard)) 
                    {
                        break; 
                    }
                    CheckTie(bBoard);

                } while (true);
            }

            bBoard.ShowBoard(bBoard);
            }

            // Save player's input and check if space is already filled
            static void PlayerPlay(Board bBoard)
            {
                while (true)
                {
                    Console.Write("Make your move (1-9): ");

                    // Tries to capture exceptions before parsing 
                    try
                    {
                        int Choice = Convert.ToInt32(Console.ReadLine());
                        if (bBoard.Space1[Choice - 1] == " ")
                        {
                            bBoard.Space1[Choice - 1] = "X";
                            break;
                        }  
                    } 
                    
                    catch (FormatException)
                    {
                        Console.WriteLine("Please, enter only valid digits. Try again");
                    }
                }
            }

            static Random random = new Random();

            // Allows to fill a random space in the board
            static void ComputerPlay(Board bBoard)
            {
                while (true) 
                {
                    int number = random.Next(0, 8);
                    if (bBoard.Space1[number] == " ")
                    {
                        bBoard.Space1[number] = "O";
                        break;
                    }
                }
            }

            // Checks who filled 3 spaces in a row first.
            static bool CheckWinner(Board bBoard)
            {
                var winningConditions = new List<int[]>
                {
                    new[] { 0, 1, 2 }, new[] { 3, 4, 5 }, new[] { 6, 7, 8 }, // Rows
                    new[] { 0, 3, 6 }, new[] { 1, 4, 7 }, new[] { 2, 5, 8 }, // Columns
                    new[] { 0, 4, 8 }, new[] { 2, 4, 6 } //Diagonal
                };
                foreach(var condition  in winningConditions)
                {
                    if (bBoard.Space1[condition[0]] == bBoard.Space1[condition[1]] &&
                        bBoard.Space1[condition[1]] == bBoard.Space1[condition[2]] &&
                        bBoard.Space1[condition[0]] != " ")
                {
                    string result = bBoard.Space1[condition[0]] == "X" ? "Player wins!" : "Computer Wins!";
                    Console.WriteLine(result);
                    return true;
                }
            }
            return false;
            }

            // Checks if all the spaces are filled, AKA tie.
            static bool CheckTie(Board bBoard)
            {
                int countingOccupiedSpaces = 0;
                for (int i = 0; i < bBoard.Space1.Length; i++)
                {
                    if (bBoard.Space1[i] != " ")
                    {
                        countingOccupiedSpaces++;
                    }
                    if (countingOccupiedSpaces == 9)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }

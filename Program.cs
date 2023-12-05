using __Game;

namespace CSharpGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Board bBoard = new Board();//Create an object of the board, that is used to keep the positions and the board
            Console.WriteLine("Welcome to Tic Tac Toe Game!");
            {
                do //Start the game
                {
                    bBoard.ShowBoard(bBoard); //Show board that it is on Board.cs

                    PlayerPlay(bBoard); //Player play

                    if (CheckWinner(bBoard)) //Check if the player won
                    {
                        break; //if yes, loop stop
                    }
                    if (CheckTie(bBoard)) //Check if it's a tie
                    {
                        Console.WriteLine("It's a tie!");
                        break; //if yes, loop stop
                    }
                    ComputerPlay(bBoard); //Computer Play
                    if (CheckWinner(bBoard)) //Check if the Computer won
                    {
                        break; //if yes, loop stop
                    }
                    CheckTie(bBoard);

                } while (true);
            }

            bBoard.ShowBoard(bBoard); //Shows one last time the board
            }

            static void PlayerPlay(Board bBoard) //Player Plays
            {
                while (true) //Create a loop that ask for an input, just stop when the input is valid
                {
                    Console.Write("Make your move (1-9): ");
                    int Choice = Convert.ToInt32(Console.ReadLine());
                    if (bBoard.Space1[Choice - 1] == " ") //Check if the position mentioned by the player is empty
                    {
                        bBoard.Space1[Choice - 1] = "X";
                        break;
                    }
                }
            }

            static Random random = new Random();
            static void ComputerPlay(Board bBoard) //Computer plays
            {
                while (true) //Create a loop that generate a random position and just stop when the computer is allowed to write that
                {
                    int number = random.Next(0, 8);
                    if (bBoard.Space1[number] == " ") //Verify if the position is already ocuppied
                    {
                        bBoard.Space1[number] = "O";
                        break;
                    }
                }
            }
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

            static bool CheckTie(Board bBoard) //Check if it's a tie!
            {
                int countingOccupiedSpaces = 0; //Count the number of occupied positions on the board
                for (int i = 0; i < bBoard.Space1.Length; i++)
                {
                    if (bBoard.Space1[i] != " ")
                    {
                        countingOccupiedSpaces++;
                    }
                    if (countingOccupiedSpaces == 9) //If the 9 positions are occupied, it's a tie! The winner check is made before the Tie Check
                    {
                        return true; //return true for the main method loop stop
                    }
                }
                return false; //return false for the main method loop continues
            }
        }
    }

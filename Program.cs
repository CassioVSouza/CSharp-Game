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
                    if (CheckTie(bBoard)) //Check if it's a tie
                    {
                        Console.WriteLine("It's a tie!");
                        break; //if yes, loop stop
                    }
                    CheckTie(bBoard);

                } while(!CheckWinner(bBoard));

                bBoard.ShowBoard(bBoard); //Shows one last time the board
            }

            static void PlayerPlay(Board bBoard) //Player Plays
            {
                while(true) //Create a loop that ask for an input, just stop when the input is valid
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

            static void ComputerPlay(Board bBoard) //Computer plays
            {
                while (true) //Create a loop that generate a random position and just stop when the computer is allowed to write that
                {
                    Random random = new Random();
                    int number = random.Next(0, 8);
                    if (bBoard.Space1[number] == " ") //Verify if the position is already ocuppied
                    {
                        bBoard.Space1[number] = "O";
                        break;
                    }
                }
            }
            static bool CheckWinner(Board bBoard) //Check if the player or computer won
            {
                if (bBoard.Space1[0] == bBoard.Space1[1] && bBoard.Space1[1] == bBoard.Space1[2] && bBoard.Space1[0] != " ") //All the possibilites of win
                {
                    string result = bBoard.Space1[0] == "X" ? "Player wins!" : "Computer Wins!"; //Check who won
                    Console.WriteLine(result);
                    return true; //Return true to stop the loop in main method
                }
                else if (bBoard.Space1[3] == bBoard.Space1[4] && bBoard.Space1[4] == bBoard.Space1[5] && bBoard.Space1[3] != " ")
                {
                    string result = bBoard.Space1[3] == "X" ? "Player wins!" : "Computer Wins!";
                    Console.WriteLine(result);
                    return true;
                }
                else if (bBoard.Space1[6] == bBoard.Space1[7] && bBoard.Space1[7] == bBoard.Space1[8] && bBoard.Space1[6] != " ")
                {
                    string result = bBoard.Space1[6] == "X" ? "Player wins!" : "Computer Wins!";
                    Console.WriteLine(result);
                    return true;
                }
                else if (bBoard.Space1[0] == bBoard.Space1[3] && bBoard.Space1[3] == bBoard.Space1[6] && bBoard.Space1[0] != " ")
                {
                    string result = bBoard.Space1[0] == "X" ? "Player wins!" : "Computer Wins!";
                    Console.WriteLine(result);
                    return true;
                }
                else if (bBoard.Space1[1] == bBoard.Space1[4] && bBoard.Space1[4] == bBoard.Space1[7] && bBoard.Space1[1] != " ")
                {
                    string result = bBoard.Space1[1] == "X" ? "Player wins!" : "Computer Wins!";
                    Console.WriteLine(result);
                    return true;
                }
                else if (bBoard.Space1[2] == bBoard.Space1[5] && bBoard.Space1[5] == bBoard.Space1[8] && bBoard.Space1[2] != " ")
                {
                    string result = bBoard.Space1[2] == "X" ? "Player wins!" : "Computer Wins!";
                    Console.WriteLine(result);
                    return true;
                }
                else if (bBoard.Space1[0] == bBoard.Space1[4] && bBoard.Space1[4] == bBoard.Space1[8] && bBoard.Space1[0] != " ")
                {
                    string result = bBoard.Space1[0] == "X" ? "Player wins!" : "Computer Wins!";
                    Console.WriteLine(result);
                    return true;
                }
                else if (bBoard.Space1[2] == bBoard.Space1[4] && bBoard.Space1[4] == bBoard.Space1[6] && bBoard.Space1[2] != " ")
                {
                    string result = bBoard.Space1[2] == "X" ? "Player wins!" : "Computer Wins!";
                    Console.WriteLine(result);
                    return true;
                }
                return false; //Return false for the loop continues in main method
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
}
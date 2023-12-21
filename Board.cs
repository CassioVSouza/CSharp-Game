namespace __Game
{
    internal class Board
    {
        public string[] Space1 = {" ", " ", " ", " ", " ", " ", " ", " ", " " }; //Keep the positions

        // The board draw on console.
        public void ShowBoard(Board bBoard)
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + bBoard.Space1[0] + "  |  " + bBoard.Space1[1] + "  |  " + bBoard.Space1[2] + "  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + bBoard.Space1[3] + "  |  " + bBoard.Space1[4] + "  |  " + bBoard.Space1[5] + "  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + bBoard.Space1[6] + "  |  " + bBoard.Space1[7] + "  |  " + bBoard.Space1[8] + "  ");
            Console.WriteLine("     |     |     ");
        }
    }
}
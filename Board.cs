using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Game
{
    internal class Board
    {
        public string[] Space1 = {" ", " ", " ", " ", " ", " ", " ", " ", " " }; //Keep the positions

        public void ShowBoard(Board bBoard) //The draw of the board in console
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

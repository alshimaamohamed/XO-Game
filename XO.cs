using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryxo
{
   public class XO
    {
        public bool turn;
        public String[,] position;
        public XO()
        {
            turn = false; position = new String[3, 3];
        }
        public bool IsWin()
        {
            if ((position[0, 0] == "X" && position[0, 1] == "X" && position[0, 2] == "X") || position[0, 0] == "O" && position[0, 1] == "O" && position[0, 2] == "O")
                return true;
            //    return position[0, 2];
            else if ((position[1, 0] == "X" && position[1, 1] == "X" && position[1, 2] == "X") || (position[1, 0] == "O" && position[1, 1] == "O" && position[1, 2] == "O"))
                return true;
            //  return position[1, 1];
            else if ((position[2, 0] == "X" && position[2, 1] == "X" && position[2, 2] == "X") || (position[2, 0] == "O" && position[2, 1] == "O" && position[2, 2] == "O"))
                return true;
            // return position[2, 2];
            else if ((position[0, 0] == "X" && position[1, 0] == "X" && position[2, 0] == "X") || (position[0, 0] == "O" && position[1, 0] == "O" && position[2, 0] == "O"))
                return true;
            //  return position[1, 0];
            else if ((position[0, 1] == "X" && position[1, 1] == "X" && position[2, 1] == "X") || (position[0, 1] == "O" && position[1, 1] == "O" && position[2, 1] == "O"))
                return true;
            //return position[0, 1];
            else if ((position[0, 2] == "X" && position[1, 2] == "X" && position[2, 2] == "X") || (position[0, 2] == "O" && position[1, 2] == "O" && position[2, 2] == "O"))
                return true;
            // return position[1, 2];
            else if ((position[0, 2] == "X" && position[1, 1] == "X" && position[2, 0] == "X") || (position[0, 2] == "O" && position[1, 1] == "O" && position[2, 0] == "O"))
                return true;
            // return position[2, 0];
            else if ((position[0, 0] == "X" && position[1, 1] == "X" && position[2, 2] == "X") || (position[0, 0] == "O" && position[1, 1] == "O" && position[2, 2] == "O"))
                return true;
            // return position[0, 0];
            else
                return false;
        }
    }
}

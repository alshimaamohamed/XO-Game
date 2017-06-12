using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryxo
{
  public  class hard : XO
    {

        public int index;

        public hard()
        {
            index = 0;
        }
        public void computer_make_move()
        {

            bool move = false;



            move = look_for_win_or_block("O");
            if (move == false)
            {
                move = look_for_win_or_block("X");
                if (move == false)
                {
                    move = look_for_corner();
                   
                }

            }

        }

        public bool look_for_corner()
        {

            if (position[0, 0] == "O")
            {
                if (position[0, 2] == "")
                {
                    index = 3;
                    return true;
                }
                if (position[2, 2] == "")
                {
                    index = 9;
                    return true;
                }
                if (position[2, 0] == "")
                {
                    index = 7;
                    return true;
                }
            }

            if (position[0, 2] == "O")
            {
                if (position[0, 0] == "")
                {
                    index = 1;
                    return true;
                }
                if (position[2, 2] == "")
                {

                    index = 9;
                    return true;
                }
                if (position[2, 0] == "")
                {
                    index = 7;
                    return true;
                }
            }

            if (position[2, 2] == "O")
            {
                if (position[0, 0] == "")
                {
                    index = 3;
                    return true;
                }
                if (position[0, 2] == "")
                {
                    index = 3;
                    return true;
                }
                if (position[2, 0] == "")
                {
                    index = 7;
                    return true;
                }
            }

            if (position[2, 0] == "O")
            {
                if (position[0, 0] == "")
                {
                    index = 3;
                    return true;
                }

                if (position[2, 0] == "")
                {
                    index = 3;
                    return true;
                }

                if (position[2, 2] == "")
                {
                    index = 9;
                    return true;
                }
            }

            if (position[0, 0] == "")
            {
                index = 1;
                return true;
            }
            if (position[0, 2] == "")
            {
                index = 3;
                return true;
            }

            if (position[2, 0] == "")
            {
                index = 7;
                return true;
            }

            if (position[2, 2] == "")
            {
                index = 9;
                return true;
            }
            return false;
        }

        public virtual bool look_for_win_or_block(string mark)
        {



            //HORIZONTAL TESTS
            if ((position[0, 0] == mark) && (position[0, 1] == mark) && (position[0, 2] == ""))
            {
                index = 3;
                return true;
            }

            if ((position[0, 1] == mark) && (position[0, 2] == mark) && (position[0, 0] == ""))
            {
                index = 1;
                return true;
            }
            if ((position[0, 0] == mark) && (position[0, 2] == mark) && (position[0, 1] == ""))
            {
                index = 2;
                return true;
            }

            if ((position[1, 0] == mark) && (position[1, 1] == mark) && (position[1, 2] == ""))
            {
                index = 6;
                return true;
            }
            if ((position[1, 1] == mark) && (position[1, 2] == mark) && (position[1, 0] == ""))
            {
                index = 4;
                return true;
            }
            if ((position[1, 0] == mark) && (position[1, 2] == mark) && (position[1, 1] == ""))
            {
                index = 5;
                return true;
            }

            if ((position[2, 0] == mark) && (position[2, 1] == mark) && (position[2, 2] == ""))
            {
                index = 9;
                return true;
            }
            if ((position[2, 1] == mark) && (position[2, 2] == mark) && (position[2, 0] == ""))
            {
                index = 7;
                return true;
            }
            if ((position[2, 0] == mark) && (position[2, 2] == mark) && (position[2, 1] == ""))
            {
                index = 8;
                return true;
            }

            //VERTICAL TESTS
            if ((position[0, 0] == mark) && (position[1, 0] == mark) && (position[2, 0] == ""))
            {
                index = 7;
                return true;
            }
            if ((position[1, 0] == mark) && (position[2, 0] == mark) && (position[0, 0] == ""))
            {
                index = 1;
                return true;
            }
            if ((position[0, 0] == mark) && (position[2, 0] == mark) && (position[1, 0] == ""))
            {
                index = 4;
                return true;
            }

            if ((position[0, 1] == mark) && (position[1, 1] == mark) && (position[2, 1] == ""))
            {
                index = 8;
                return true;
            }
            if ((position[1, 1] == mark) && (position[2, 1] == mark) && (position[0, 1] == ""))
            {
                index = 2;
                return true;
            }
            if ((position[0, 1] == mark) && (position[2, 1] == mark) && (position[1, 1] == ""))
            {
                index = 5;
                return true;
            }

            if ((position[0, 2] == mark) && (position[1, 2] == mark) && (position[2, 2] == ""))
            {
                index = 9;
                return true;
            }
            if ((position[1, 2] == mark) && (position[2, 2] == mark) && (position[0, 2] == ""))
            {
                index = 3;
                return true;
            }
            if ((position[0, 2] == mark) && (position[2, 2] == mark) && (position[1, 2] == ""))
            {
                index = 6;
                return true;
            }

            //DIAGONAL TESTS
            if ((position[0, 0] == mark) && (position[1, 1] == mark) && (position[2, 2] == ""))
            {
                index = 9;
                return true;
            }
            if ((position[1, 1] == mark) && (position[2, 2] == mark) && (position[0, 0] == ""))
            {
                index = 1;
                return true;
            }
            if ((position[0, 0] == mark) && (position[2, 2] == mark) && (position[1, 1] == ""))
            {
                index = 5;
                return true;
            }

            if ((position[0, 2] == mark) && (position[1, 1] == mark) && (position[2, 0] == ""))
            {
                index = 7;
                return true;
            }
            if ((position[1, 1] == mark) && (position[2, 0] == mark) && (position[0, 2] == ""))
            {
                index = 3;
                return true;
            }
            if ((position[0, 2] == mark) && (position[2, 0] == mark) && (position[1, 1] == ""))
            {
                index = 5;
                return true;
            }

            return false;
        }
    
    }
}

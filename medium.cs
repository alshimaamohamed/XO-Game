using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryxo
{
    class medium:hard
    {
      public  medium ()
        {

        }
        public override bool look_for_win_or_block(string mark)
        {



            //HORIZONTAL TESTS

            // condition of row 1
            if ((position[0, 0] == mark) && (position[0, 1] == mark) && (position[0, 2] == ""))
            {
                index = 3;
                return true;
            }

            if ((position[0, 1] == mark) && (position[0, 2] == mark) && (position[0, 0] == ""))
            {
                for (int i = 1; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        if (position[i, j] == "")
                        {
                            index = (i * 3) + j + 1;
                            return true;
                        }
            }
            if ((position[0, 0] == mark) && (position[0, 2] == mark) && (position[0, 1] == ""))
            {
                index = 2;
                return true;
            }

            // condition of row 2
            if ((position[1, 0] == mark) && (position[1, 1] == mark) && (position[1, 2] == ""))
            {
                for (int i = 0; i < 3; i += 2)
                    for (int j = 0; j < 3; j++)
                        if (position[i, j] == "")
                        {
                            index = (i * 3) + j + 1;
                            return true;
                        }
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

            // condition of row 3
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
                for (int i = 0; i < 2; i++)
                    for (int j = 0; j < 3; j++)
                        if (position[i, j] == "")
                        {
                            index = (i * 3) + j + 1;
                            return true;
                        }
            }

            //VERTICAL TESTS

            // condition of column 1
            if ((position[0, 0] == mark) && (position[1, 0] == mark) && (position[2, 0] == ""))
            {
                index = 7;
                return true;
            }
            if ((position[1, 0] == mark) && (position[2, 0] == mark) && (position[0, 0] == ""))
            {
                for (int i = 0; i < 3; i++)
                    for (int j = 1; j < 3; j++)
                        if (position[i, j] == "")
                        {
                            index = (i * 3) + j + 1;
                            return true;
                        }
            }
            if ((position[0, 0] == mark) && (position[2, 0] == mark) && (position[1, 0] == ""))
            {
                index = 4;
                return true;
            }

            // condition of column 2
            if ((position[0, 1] == mark) && (position[1, 1] == mark) && (position[2, 1] == ""))
            {
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j += 2)
                        if (position[i, j] == "")
                        {
                            index = (i * 3) + j + 1;
                            return true;
                        }
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

            // condition of column 3
            if ((position[0, 2] == mark) && (position[1, 2] == mark) && (position[2, 2] == ""))
            {
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 2; j++)
                        if (position[i, j] == "")
                        {
                            index = (i * 3) + j + 1;
                            return true;
                        }
            }
            if ((position[1, 2] == mark) && (position[2, 2] == mark) && (position[0, 2] == ""))
            {
                index = 3;
                return true;
            }
            if ((position[0, 2] == mark) && (position[2, 2] == mark) && (position[1, 2] == ""))
            {
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 2; j++)
                        if (position[i, j] == "")
                        {
                            index = (i * 3) + j + 1;
                            return true;
                        }
            }

            //DIAGONAL TESTS
            if ((position[0, 0] == mark) && (position[1, 1] == mark) && (position[2, 2] == ""))
            {
                index = 9;
                return true;
            }
            if ((position[1, 1] == mark) && (position[2, 2] == mark) && (position[0, 0] == ""))
            {
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        if (position[i, j] == "")
                        {
                            index = (i * 3) + j + 1;
                            return true;
                        }
            }
            if ((position[0, 0] == mark) && (position[2, 2] == mark) && (position[1, 1] == ""))
            {
                index = 5;
                return true;
            }

            if ((position[0, 2] == mark) && (position[1, 1] == mark) && (position[2, 0] == ""))
            {
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        if (position[i, j] == "")
                        {
                            index = (i * 3) + j + 1;
                            return true;
                        }
            }
            if ((position[1, 1] == mark) && (position[2, 0] == mark) && (position[0, 2] == ""))
            {
                index = 3;
                return true;
            }
            if ((position[0, 2] == mark) && (position[2, 0] == mark) && (position[1, 1] == ""))
            {
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        if (position[i, j] == "")
                        {
                            index = (i * 3) + j + 1;
                            return true;
                        }
            }

            return false;
        }
    }
}

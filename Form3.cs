using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tryxo
{
    public  partial class Form3 : Form
    {
        hard com = new hard();
   
        int cnt = 0;
        int X_cnt, O_cnt,Draw_cnt;
        public Form3()
        {
            InitializeComponent();
            reset();
        }
        private enum GameType { X, O };
        private GameType current_gt = GameType.X;
        public void switchGame()
        {
            if (current_gt == GameType.X)
                current_gt = GameType.O;
            else
                current_gt = GameType.X;
        }
       
        public void newGame()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++) { com.position[i, j] = ""; }
            }
            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    c.ResetText();
                }
            }
            label1.Text = "";
            cnt = 0;
           
            label15.Text = "Draw";
                      x.Text = X_cnt.ToString();
            o.Text = O_cnt.ToString();
            draw.Text = Draw_cnt.ToString();


        
        }
        public void reset()
        {
           
            newGame();
            X_cnt = 0;
            O_cnt = 0;
            Draw_cnt = 0;
           p1.Text = "";
            label15.Text = "Drow";
          p2.Text = "";
            x.Text = X_cnt.ToString();
            o.Text = O_cnt.ToString();
            draw.Text = Draw_cnt.ToString();
          /*  vsComputerToolStripMenuItem.Checked = false;
            vsPlayerToolStripMenuItem.Checked = false;
            hardToolStripMenuItem.Checked = false;
            easyToolStripMenuItem.Checked = false;
            mediumToolStripMenuItem.Checked = false;*/
        }
        void play(int l, int m)
        {


            if (com.position[l, m] != "")
                return;
            if (com.position[l, m] == "")
            {
                Label ctrl = link(l, m);

                ctrl.Text = current_gt.ToString();
                com.position[l, m] = ctrl.Text;
                cnt++;
                if (com.IsWin())
                {
                 
                  
                    if (current_gt.ToString() == "X")
                    {
                        MessageBox.Show("Congratulation " + p1.Text.ToString()+ " won ^_^");
                        X_cnt++;
                        x.Text = X_cnt.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Congratulation " + p2.Text.ToString() + " won ^_^");
                        O_cnt++;
                        o.Text = O_cnt.ToString();
                    }
                    newGame();
                }
                else if (cnt == 9)
                {
                    MessageBox.Show("Draw");
                    Draw_cnt++;
                    draw.Text = Draw_cnt.ToString();
                    newGame();
                }
                switchGame();
            }
            if (com.turn)
            {
                com.computer_make_move();
                if (com.index != 0)
                {
                    int[] arr = new int[2];
                    arr = index_computer();

                    Label c = link(arr[0], arr[1]);
                    if (com.position[arr[0], arr[1]] == "")
                    {
                        c.Text = current_gt.ToString();
                        com.position[arr[0], arr[1]] = c.Text;
                        cnt++;
                    }
                    else
                        return;
                    if (com.IsWin())
                    {
                     

                        if (current_gt.ToString() == "X")
                        {
                            MessageBox.Show("Congratulation " + p1.Text + " won ^_^");
                      
                            X_cnt++;
                            x.Text = X_cnt.ToString();
                        }
                        else
                        { 
                            O_cnt++;
                            o.Text = O_cnt.ToString();
                            MessageBox.Show(p2.Text+" won !!");
                        }
                        newGame();
                    }
                    else if (cnt == 9)
                    {
                        MessageBox.Show("Draw");
                        Draw_cnt++;
                        draw.Text = Draw_cnt.ToString();
                        newGame();
                    }
                    switchGame();

                }
            }
        }
        Label link(int l, int m)
        {
            if (l == 0)
            {
                if (m == 0)
                    return label1;
                if (m == 1)
                    return label2;
                if (m == 2)
                    return label3;
            }
            if (l == 1)
            {
                if (m == 0)
                    return label4;
                if (m == 1)
                    return label5;
                if (m == 2)
                    return label6;
            }
            if (l == 2)
            {
                if (m == 0)
                    return label7;
                if (m == 1)
                    return label8;
                if (m == 2)
                    return label9;
            }
            return null;
        }
        int[] index_computer()
        {
            int[] a = new int[2];
            if (com.index == 1)
            {
                a[0] = 0;
                a[1] = 0;
            }
            else if (com.index == 2)
            {
                a[0] = 0;
                a[1] = 1;
            }

            else if (com.index == 3)
            {
                a[0] = 0;
                a[1] = 2;
            }
            else if (com.index == 4)
            {
                a[0] = 1;
                a[1] = 0;
            }
            else if (com.index == 5)
            {
                a[0] = 1;
                a[1] = 1;
            }
            else if (com.index == 6)
            {
                a[0] = 1;
                a[1] = 2;
            }
            else if (com.index == 7)
            {
                a[0] = 2;
                a[1] = 0;
            }
            else if (com.index == 8)
            {
                a[0] = 2;
                a[1] = 1;
            }
            else if (com.index == 9)
            {
                a[0] = 2;
                a[1] = 2;
            }
            return a;
        }
        bool check_name()
        {
            if (com.turn && (p1.Text == ""))
            {
                MessageBox.Show("Please enter the name of the player before starting the game");
                return true;
            }
            else if (com.turn == false && p1.Text == "" && p2.Text == "")
            {
                MessageBox.Show("Please enter the name of player1 and player2 before starting the game");
                return true;
            }
            else if (com.turn == false && p1.Text == "")
            {
                MessageBox.Show("Please enter the name of player1 before starting the game");
                return true;
            }
            else if (com.turn == false && p2.Text == "")
            {
                MessageBox.Show("Please enter the name of player2 before starting the game");
                return true;
            }
            else
                return false;

        }
      
       void label1_Click(object sender, EventArgs e)
        {
           if(!check_name())

            play(0, 0);
        }

         void label2_Click(object sender, EventArgs e)
        {
            if (!check_name())
            play(0, 1);
        }

       void label3_Click(object sender, EventArgs e)
        {
            if (!check_name())
            play(0, 2);
        }

       void label4_Click(object sender, EventArgs e)
        {
            if (!check_name())
            play(1, 0);
        }

        void label5_Click(object sender, EventArgs e)
        {
            if (!check_name())
            play(1, 1);
        }

        void label6_Click(object sender, EventArgs e)
        {
            if (!check_name())
            play(1, 2);
        }

       void label7_Click(object sender, EventArgs e)
        {
            if (!check_name())
            play(2, 0);
        }

         void label8_Click(object sender, EventArgs e)
        {
            if (!check_name())
            play(2, 1);
        }

        void label9_Click(object sender, EventArgs e)
        {
            if (!check_name())
            play(2, 2);
        }

        void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
            com.turn = true;
        }

       

     
       

       

        private void vsPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vsComputerToolStripMenuItem.Checked = false;
            vsPlayerToolStripMenuItem.Checked = true;
            reset();
            com.turn = false;
        }

        private void vsComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
            vsComputerToolStripMenuItem.Checked = true;
            vsPlayerToolStripMenuItem.Checked = false;
            p2.Text = "Computer";
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to exit ?? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
        private void hardToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            vsComputerToolStripMenuItem.Checked = true;
            vsPlayerToolStripMenuItem.Checked = false;
            hardToolStripMenuItem.Checked = true;
            easyToolStripMenuItem.Checked = false;
            mediumToolStripMenuItem.Checked = false;
            newGame();
            com.turn = true;
        }

      

       

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            com = new easy();
            vsComputerToolStripMenuItem.Checked = true;
            vsPlayerToolStripMenuItem.Checked = false;
            hardToolStripMenuItem.Checked = false;
            easyToolStripMenuItem.Checked = true;
            mediumToolStripMenuItem.Checked = false;
            newGame();
            com.turn = true;
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            com = new medium();
            vsComputerToolStripMenuItem.Checked = true;
            vsPlayerToolStripMenuItem.Checked = false;
            hardToolStripMenuItem.Checked = false;
            easyToolStripMenuItem.Checked = false;
            mediumToolStripMenuItem.Checked = true;
            newGame();
            com.turn = true;

        }


     
       

      
       

        

      

       

    }
}

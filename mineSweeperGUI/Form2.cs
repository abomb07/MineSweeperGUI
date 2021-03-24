using mineClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mineSweeperGUI
{
    public partial class Form2 : Form
    {
        private MyButton[,] btnGrid;
        public Board b;
        int hour, min, sec, ms;
        int currentDifficulty;
        
        public Form2(int d)
        {
            currentDifficulty = d;

            //setup 3 difficulties
            if (d == 0)
            {
                b = new Board(6);
                btnGrid = new MyButton[b.size, b.size];
                b.setupLiveNeighbors(0);
            }
            if (d == 1)
            {
                b = new Board(10);
                btnGrid = new MyButton[b.size, b.size];
                b.setupLiveNeighbors(1);
            }
            if (d == 2)
            {
                b = new Board(14);
                btnGrid = new MyButton[b.size, b.size];
                b.setupLiveNeighbors(2);
            }

            InitializeComponent();
            populateGrid();

            b.calculateLiveNeighbors();
        }

        public void populateGrid()
        {
            //dont start timer until first button is clicked
            timer1.Stop();

            int buttonSize = pnl_grid.Width / b.size;

            //make panel a square
            pnl_grid.Width = pnl_grid.Height;

            //place buttons
            for (int r = 0; r < b.size; r++)
            {
                for (int c = 0; c < b.size; c++)
                {
                    btnGrid[r, c] = new MyButton(r, c);
                    btnGrid[r, c].Height = buttonSize;
                    btnGrid[r, c].Width = buttonSize;

                    //method for button click
                    btnGrid[r, c].MouseUp += gridbutton_Click;

                    //add button and set location
                    pnl_grid.Controls.Add(btnGrid[r, c]);
                    btnGrid[r, c].Location = new Point(r * buttonSize, c * buttonSize);
                }
            }
        }

        private void gridbutton_Click(object sender, MouseEventArgs e)
        {
            //start timer
            timer1.Start();

            //button object
            MyButton btn = (MyButton)sender;

            //place flag if right clicked
            if(e.Button == MouseButtons.Right)
            {
                btn.BackgroundImage = mineSweeperGUI.Properties.Resources.mineFlag;
                btn.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                //flood fill
                b.floodFill(btn.row, btn.col);

                //update board
                updateBoard(b);

                //if bomb is clicked, game over
                if(b.Grid[btn.row, btn.col].live)
                {
                    lostGame();
                    this.Close();
                }

                //if board is cleared, win game
                if(b.boardIsClear())
                {
                    winGame();
                }
            }
        }

        private void winGame()
        {
            //stop time
            timer1.Stop();

            //place flags where bombs were
            for (int r = 0; r < b.size; r++)
            {
                for (int c = 0; c < b.size; c++)
                {
                    if (b.Grid[r, c].live)
                    {
                        btnGrid[r, c].BackgroundImage = mineSweeperGUI.Properties.Resources.mineFlag;
                        btnGrid[r, c].BackgroundImageLayout = ImageLayout.Zoom;
                    }
                    //disable all buttons
                    btnGrid[r, c].Enabled = false;
                }
            }

            //HIGH SCORE FORM
            MessageBox.Show("YOU HAVE WON IN " + hour + "hr " + min + "min " + sec + "sec");

            if(sec < 10)
            {
                Form3 win = new Form3(currentDifficulty, hour.ToString() + ":" + min.ToString() + ":0" + sec.ToString());
                win.Show();
            }
            else
            {
                Form3 win = new Form3(currentDifficulty, hour.ToString() + ":" + min.ToString() + ":" + sec.ToString());
                win.Show();
            }
            
            //reset
            this.Close();
        }

        private void lostGame()
        {
            //stop time
            timer1.Stop();

            //show where bombs are
            for (int r = 0; r < b.size; r++)
            {
                for (int c = 0; c < b.size; c++)
                {
                    if(b.Grid[r,c].live)
                    {
                        btnGrid[r, c].BackgroundImage = mineSweeperGUI.Properties.Resources.mine;
                        btnGrid[r, c].BackgroundImageLayout = ImageLayout.Zoom;
                    }
                    //disable all buttons
                    btnGrid[r, c].Enabled = false;
                }
            }

            //game over message box
            MessageBox.Show("GAME OVER");

            //reset
            this.Close();
        }

        private void updateBoard(Board b)
        {
            for (int r = 0; r < b.size; r++)
            {
                for (int c = 0; c < b.size; c++)
                {
                    Cell cell = b.Grid[r, c];

                    //no image if cell has been visited
                    if (cell.visited == true)
                    {
                        btnGrid[r, c].BackColor = Color.White;

                        //no text if no live neighborhoods
                        if(cell.liveNeighbors == 0)
                        {
                            btnGrid[r, c].Text = "";
                        }

                        //print number of live neighbors on button
                        else
                        {
                            btnGrid[r, c].Text = b.Grid[r, c].liveNeighbors.ToString();
                        }                    
                    }
                    else
                    {
                        btnGrid[r, c].Text = "";
                    }

                    if(b.Grid[r,c].live)
                    {
                        btnGrid[r, c].Text = " ";
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = hour + ":" + min + ":" + sec;

            ms++;
            if(ms > 10)
            {
                sec++;
                ms = 0;
            }
            if(sec > 60)
            {
                min++;
                sec = 0;
            }
            if(min > 60)
            {
                hour++;
                min = 0;
            }
        }
    }
}

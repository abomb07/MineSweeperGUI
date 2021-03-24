using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mineClass;

namespace mineSweeperGUI
{
    public partial class Form1 : Form
    {
        int difficulty = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_game_Click(object sender, EventArgs e)
        {
            //set difficulty based on radiobutton selection
            if (rbtn_easy.Checked)
            {
                difficulty = 0;

                //show easy board 6x6
                Form2 Board = new Form2(difficulty);
                Board.Show();
            }
            if (rbtn_medium.Checked)
            {
                difficulty = 1;

                //show medium board 10x10
                Form2 Board = new Form2(difficulty);
                Board.Show();
            }
            if (rbtn_hard.Checked)
            {
                difficulty = 2;

                //show hard board 14x14
                Form2 Board = new Form2(difficulty);
                Board.Show();
            }

        }

        private void haldleClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

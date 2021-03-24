using mineClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mineSweeperGUI
{
    public partial class Form3 : Form
    {
        List<string> lines = new List<string>();
        List<PlayerStats> theScores = new List<PlayerStats>();

        string filePath = @"C:\demo\scores.txt";

        public Form3(int d, string t)
        {
            InitializeComponent();

            //load from file
            lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                PlayerStats ps = new PlayerStats(items[0], Convert.ToInt32(items[1]), items[2]);
                theScores.Add(ps);
            }

            //setup 3 difficulties
            if (d == 0)
            {
                //show label
                lbl_level.Text = "Easy";

                //add score to list
                PlayerStats p = new PlayerStats("A.R.B.", 0, t);
                theScores.Add(p);

                //display top 5 scores in listbox
                var fiveScores =
                    (from s in theScores
                     where s.level == 0
                     orderby s ascending
                     select s).Take(5);

                foreach(var l in fiveScores)
                {
                    lb_scores.Items.Add(l.ToString());
                }
            }
            if (d == 1)
            {
                //show label
                lbl_level.Text = "Medium";

                PlayerStats p = new PlayerStats("A.R.B.", 1, t);
                theScores.Add(p);

                //display top 5 scores in listbox
                var fiveScores =
                    (from s in theScores
                     where s.level == 1
                     orderby s ascending
                     select s).Take(5);

                foreach (var l in fiveScores)
                {
                    lb_scores.Items.Add(l.ToString());
                }
            }
            if (d == 2)
            {
                //show label
                lbl_level.Text = "Hard";

                PlayerStats p = new PlayerStats("A.R.B.", 2, t);
                theScores.Add(p);

                //display top 5 scores in listbox
                var fiveScores =
                    (from s in theScores
                     where s.level == 2
                     orderby s ascending
                     select s).Take(5);

                foreach (var l in fiveScores)
                {
                    lb_scores.Items.Add(l.ToString());
                }
            }

            //save to file
            List<string> outContents = new List<string>();

            foreach (PlayerStats ps in theScores)
            {
                outContents.Add(ps.initials + "," + ps.level.ToString() + "," + ps.timeScore);
            }

            File.WriteAllLines(filePath, outContents);
        }
    }
}

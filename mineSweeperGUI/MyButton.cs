using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mineSweeperGUI
{
    class MyButton : Button
    {
        public int row { get; set; }
        public int col { get; set; }

        public MyButton(int r, int c)
        {
            row = r;
            col = c;
        }
    }
}

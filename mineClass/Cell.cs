using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mineClass
{
    public class Cell
    {
        public int row { get; set; }
        public int column { get; set; }
        public Boolean visited { get; set; }
        public Boolean live { get; set; }
        public int liveNeighbors { get; set; }

        public Cell(int r, int c)
        {
            row = r;
            column = c;
        }
    }
}

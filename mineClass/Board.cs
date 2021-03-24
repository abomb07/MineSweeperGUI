using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mineClass
{
    public class Board
    {
        public int size { get; set; }
        public Cell[,] Grid;
        public int difficulty { get; set; }
        public int theBombs { get; set; }

        public Board(int s)
        {
            size = s;
            //initialize 2d array grid
            Grid = new Cell[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Grid[i, j] = new Cell(i, j);
                }
            }
        }

        //randomly assign live cells with 3 difficulties
        public void setupLiveNeighbors(int d)
        {
            difficulty = d;
            Random random = new Random();
            int numOfBombs = 0;

            if (difficulty == 0)
            {
                numOfBombs = 0;
                theBombs = 4;

                //this while loop ensures there are 18 bombs placed in 18 different places
                while(numOfBombs < theBombs)
                {
                    int randRow = random.Next(0, size - 1);
                    int randCol = random.Next(0, size - 1);
                    if (Grid[randRow, randCol].live == true)
                    {

                    }
                    else
                    {
                        Grid[randRow, randCol].live = true;
                        numOfBombs++;
                    }
                }
            }
            else if(difficulty == 1)
            {
                numOfBombs = 0;
                theBombs = 16;

                while (numOfBombs < theBombs)
                {
                    int randRow = random.Next(0, size - 1);
                    int randCol = random.Next(0, size - 1);
                    if (Grid[randRow, randCol].live == true)
                    {

                    }
                    else
                    {
                        Grid[randRow, randCol].live = true;
                        numOfBombs++;
                    }
                }
            }
            else if(difficulty == 2)
            {
                numOfBombs = 0;
                theBombs = 30;

                while (numOfBombs < theBombs)
                {
                    int randRow = random.Next(0, size - 1);
                    int randCol = random.Next(0, size - 1);
                    if (Grid[randRow, randCol].live == true)
                    {

                    }
                    else
                    {
                        Grid[randRow, randCol].live = true;
                        numOfBombs++;
                    }
                }
            }
        }

        //check if surrounding cell is in the array
        //if it is check if its live and increase the count
        public void calculateLiveNeighbors()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int count = 0;
                    if (Grid[i, j].live == true)
                    {
                        Grid[i, j].liveNeighbors = 9;
                    }
                    if(isSafe(i - 1, j - 1))
                    {
                        if(Grid[i - 1, j - 1].live == true)
                        {
                            count++;
                        }
                    }
                    if (isSafe(i - 1, j + 1))
                    {
                        if (Grid[i - 1, j + 1].live == true)
                        {
                            count++;
                        }
                    }
                    if (isSafe(i + 1, j + 1))
                    {
                        if (Grid[i + 1, j + 1].live == true)
                        {
                            count++;
                        }
                    }
                    if (isSafe(i + 1, j - 1))
                    {
                        if (Grid[i + 1, j - 1].live == true)
                        {
                            count++;
                        }
                    }
                    if (isSafe(i - 1, j))
                    {
                        if (Grid[i - 1, j].live == true)
                        {
                            count++;
                        }
                    }
                    if (isSafe(i + 1, j))
                    {
                        if (Grid[i + 1, j].live == true)
                        {
                            count++;
                        }
                    }
                    if (isSafe(i, j - 1))
                    {
                        if (Grid[i, j - 1].live == true)
                        {
                            count++;
                        }
                    }
                    if (isSafe(i, j + 1))
                    {
                        if (Grid[i, j + 1].live == true)
                        {
                            count++;
                        }
                    }

                    Grid[i, j].liveNeighbors = count;
                }
            }
            
        }

        //check if surrounding cells exist and if they have 0 live neighbors, reveal their neighbors
        public void floodFill(int r, int c)
        {
            Grid[r, c].visited = true;

            if(Grid[r, c].liveNeighbors == 0 && isSafe(r,c) == true)
            {
                if(isSafe(r - 1, c - 1) && Grid[r-1,c-1].visited == false)
                {
                    floodFill(r - 1, c - 1);
                }
                
                if(isSafe(r-1, c + 1) && Grid[r - 1, c + 1].visited == false)
                {
                    floodFill(r - 1, c + 1);
                }
                if(isSafe(r+1, c + 1) && Grid[r + 1, c + 1].visited == false)
                {
                    floodFill(r + 1, c + 1);
                }
                if(isSafe(r+1, c - 1) && Grid[r + 1, c - 1].visited == false)
                {
                    floodFill(r + 1, c - 1);
                }
                if(isSafe(r, c - 1) && Grid[r, c - 1].visited == false)
                {
                    floodFill(r, c - 1);
                }
                if(isSafe(r, c + 1) && Grid[r, c + 1].visited == false)
                {
                    floodFill(r, c + 1);
                }
                if(isSafe(r-1, c) && Grid[r - 1, c].visited == false)
                {
                    floodFill(r - 1, c);
                }
                if(isSafe(r+1, c) && Grid[r + 1, c].visited == false)
                {
                    floodFill(r + 1, c);
                }
            }
        }

        //check if board is cleared
        public bool boardIsClear()
        {
            int countV = 0;
            int countL = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (Grid[i, j].visited == true)
                    {
                        countV++;
                    }
                    if (Grid[i, j].live == true)
                    {
                        countL++;
                    }
                    if (countL + countV == Math.Pow(size, 2))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //check if cell being referenced is in the grid
        public bool isSafe(int x, int y)
        {
            if (x < 0 || x > size - 1 || y < 0 || y > size - 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

using System.Collections;

namespace _695._Max_Area_of_Island
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] a = new int[8][];
            a[0]=new int[13] { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 };
            a[1]=new int[13] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 };
            a[2]=new int[13] { 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 };
            a[3]=new int[13] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0 };
            a[4]=new int[13] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0 };
            a[5]=new int[13] { 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0 };
            a[6]=new int[13] { 0, 0, 0, 0, 1, 0, 0, 1, 1, 1, 0, 0, 0 };
            a[7]=new int[13] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 };

            Solution solution = new Solution();
            Console.WriteLine(solution.MaxAreaOfIsland(a));
        }
    }

    public class Solution
    {
        Hashtable globalVisited = new Hashtable();
        int[][] _grid;
        public int MaxAreaOfIsland(int[][] grid)
        {
            _grid = grid;
            int maxArea = 0;
            for (int i = 0; i < _grid.Length; i++)
            {
                for (int j = 0; j < _grid[i].Length; j++)
                {
                    if (_grid[i][j]==1)
                    {
                        if (!globalVisited.ContainsKey((i,j)))
                        {
                            int areValue = GetArea(i, j);
                            if (areValue>maxArea)
                            {
                                maxArea=areValue;
                            }
                        }
                    }
                }
            }
            return maxArea;
        }

        public int GetArea(int i, int j)
        {
            Hashtable localVisited = new Hashtable();
            Stack<(int i, int j)> stack = new Stack<(int i, int j)>();
            stack.Push((i, j));

            while (stack.Count > 0)
            {
                var index = stack.Pop();
                if (!localVisited.ContainsKey(index))
                {
                    localVisited.Add(index, 0);
                    globalVisited.Add(index, 0);
                }
               

                //Вверх
                if (index.i > 0)
                {
                    if ((!globalVisited.ContainsKey((index.i - 1, index.j)) && (_grid[index.i - 1][index.j] == 1)))
                    {
                        stack.Push((index.i - 1, index.j));
                    }
                }
                //Вниз
                if (index.i < _grid.Length - 1)
                {
                    if ((!globalVisited.ContainsKey((index.i + 1, index.j)) && (_grid[index.i + 1][index.j] == 1)))
                    {
                        stack.Push((index.i + 1, index.j));
                    }
                }
                //Влево
                if (index.j > 0)
                {
                    if ((!globalVisited.ContainsKey((index.i, index.j - 1)) && (_grid[index.i][index.j - 1] == 1)))
                    {
                        stack.Push((index.i, index.j - 1));
                    }
                }
                //Вправо
                if (index.j < _grid[index.i].Length - 1)
                {
                    if ((!globalVisited.ContainsKey((index.i, index.j + 1)) && (_grid[index.i][index.j + 1] == 1)))
                    {
                        stack.Push((index.i, index.j + 1));
                    }
                }
            }
            return localVisited.Count;
        }
    }
}
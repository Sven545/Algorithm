using System.Collections;

namespace _733._Flood_Fill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] a = new int[3][];
            a[0] = new int[3] { 1, 1, 1 };
            a[1] = new int[3] { 1, 1, 0 };
            a[2] = new int[3] { 1, 0, 1 };


            int[][] c = new int[2][];
            c[0] = new int[3] { 0, 0, 0 };
            c[1] = new int[3] { 0, 0, 0 };

            Solution solution = new Solution();
            var b = solution.FloodFill(c,0,0,0);
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < b[i].Length; j++)
                {
                    Console.Write(b[i][j]);
                }
                Console.WriteLine("");
            }
        }
    }

    public class Solution
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            if (image[sr][sc] == color)
            {
                return image;
            }
            int oldColor = image[sr][sc];
            Hashtable visited = new Hashtable();
            Stack<(int i, int j)> stack = new Stack<(int i, int j)>();

            stack.Push((sr, sc));
            while (stack.Count > 0)
            {
                var index = stack.Pop();
                image[index.i][index.j] = color;

                if (!visited.ContainsKey((index.i, index.j)))
                {
                    visited.Add((index.i, index.j), 0);

                }

                if (index.i > 0)
                {
                    if (image[index.i - 1][index.j] == oldColor)
                    {
                        if (!visited.ContainsKey((index.i - 1, index.j)))
                        {
                            stack.Push((index.i - 1, index.j));

                        }
                    }
                }
                if (index.i < image.Length-1)
                {
                    if (image[index.i + 1][index.j] == oldColor)
                    {
                        if (!visited.ContainsKey((index.i + 1, index.j)))
                        {
                            stack.Push((index.i + 1, index.j));

                        }
                    }
                }
                if (index.j > 0)
                {
                    if (image[index.i][index.j - 1] == oldColor)
                    {
                        if (!visited.ContainsKey((index.i, index.j - 1)))
                        {
                            stack.Push((index.i, index.j - 1));

                        }
                    }
                }
                if (index.j < image[index.i].Length-1)
                {
                    if (image[index.i][index.j + 1] == oldColor)
                    {
                        if (!visited.ContainsKey((index.i, index.j + 1)))
                        {
                            stack.Push((index.i, index.j + 1));

                        }
                    }
                }
            }
            return image;
        }
    }
}
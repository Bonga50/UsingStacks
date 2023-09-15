using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UsingStacks.BackTracking
{
    internal class Tester
    {
        static int[,] maze = new int[,] {
                { 1,0,0,0 },
                { 1,1,0,0 },
                { 0,1,0,1 },
                { 0,1,1,1 } };
        static int[,] path = new int[maze.GetLength(0), maze.GetLength(1)];
        static void Main(string[] args)
        {
            Console.WriteLine(  "Path");
            SolveMaze(0,0);
            display();
            Console.ReadLine(  );
        }
        public static void display() {
            if (SolveMaze(0,0)==false)
            {
                Console.WriteLine("No Path");
            }
            for (int i = 0; i < path.GetLength(0); i++)
            {
                for (int j = 0; j < path.GetLength(1); j++)
                {
                    if (path[i,j]==1)
                    {
                        Console.WriteLine($"({i} {j})");
                    }
                }
            }
        }
        public static bool checkPath(int row,int col) {
           
            return (row >= 0 && row < maze.GetLength(0) )
                && (col >= 0 && col < maze.GetLength(1))
                && maze[row, col] == 1;
        
        }

        public static bool SolveMaze(int row,int col) {
            if (row <= maze.GetLength(0)&& col == maze.GetLength(1)-1 )
            {
                path[row, col] = 1;
                return true;
            }
            if (checkPath(row,col))
            {
                path[row, col] = 1;

                if (SolveMaze(row, col + 1) == true) return true;
                if (SolveMaze(row + 1, col) == true) return true;
                path[row, col] = 0;
                return false;

            }
          
            return false;
        }


    }
}

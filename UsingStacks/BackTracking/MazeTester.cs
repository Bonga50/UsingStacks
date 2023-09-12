using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingStacks.BackTracking
{
    internal class MazeTester
    {
        static int[,] maze = new int[,] {
                { 1, 1,0,0 },
                { 1, 0,0,0 },
                { 1, 1,1,0 },
                { 0,1,1,1 } };
        static int[,] path = new int[maze.GetLength(0), maze.GetLength(1)];

        static void Main(string[] args)
        {
            FindPath(0, 0, maze.GetLength(0));
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                Console.WriteLine( "");
                for (int j = 0; j < maze.GetLength(1) ; j++)
                {
                    Console.Write(path[i, j]);
                }
            }
            Console.ReadLine(  );
        }

        public static int FindPath(int row, int col,int size) {
            if (row==(size-1) && col== (size))
            {
                return 1;
            }

            if (maze[row,col]==1)
            {
                path[row,col] = 1;
                if (FindPath(row,col+1,size)==1)return 1;
                if(FindPath(row+1,col,size)==1)return 1;
                path[row,col] = 0;
            }
            return 0;
        }
    }
}

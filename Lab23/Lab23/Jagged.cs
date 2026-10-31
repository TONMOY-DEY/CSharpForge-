using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23
{
    internal class Jagged
    {
        public void Run()
        {
            int[][] marks = new int[3][];
            marks[0] = new int[] { 80, 90 };
            marks[1] = new int[] { 80, 90, 100 };
            marks[2] = new int[] { 80, 90, 100, 110 };

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Student" + (i + 1) + ":");

            
                for (int j = 0; j < marks[i].Length; j++)
                {
                Console.WriteLine(marks[i][j]);
                }
            }
        }
    }
}

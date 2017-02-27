using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class SudokuGraund
    {
        public int[,] graund = new int[9, 9];

        public SudokuGraund()
        {
            int x = 0;
            for (int i = 0; i < 9; ++i)
            {
                if (i % 3 == 0) ++x;
                for (int j = 0; j < 9; ++j)
                {
                    graund[i, j] = (j + x + i * 3)%9 ;
                    if (graund[i, j] == 0) graund[i, j] = 9;
                }
            }
        }
    }
}

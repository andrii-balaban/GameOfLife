using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Core.DomainObjects
{
    public class Cell
    {
        private int _cellSize;

        public Cell(int cellSize = 2)
        {
            _cellSize = cellSize;
        }
    }
}

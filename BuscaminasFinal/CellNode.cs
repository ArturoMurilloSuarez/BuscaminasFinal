using System;
using System.Collections.Generic;
using System.Text;

namespace BuscaminasFinal
{
    class CellNode
    {
        public ICell cell;
        public CellNode(ICell pCell)
        {
            this.cell = pCell;
        }
    }
}
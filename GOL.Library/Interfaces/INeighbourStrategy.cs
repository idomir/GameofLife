﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GOL.Library.Interfaces
{
    public interface INeighbourStrategy
    {
        int GetCountofCellNeighbours(Cell _cell);
    }
}

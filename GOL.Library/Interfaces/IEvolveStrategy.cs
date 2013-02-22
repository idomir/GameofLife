using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GOL.Library.Interfaces
{
    public interface IEvolveStrategy
    {
        void EvolveStrategy(Cell _cell, bool _isalive);
        void UpgradeGrid();
    }
}

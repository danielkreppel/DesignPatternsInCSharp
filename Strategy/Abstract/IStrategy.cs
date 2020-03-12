using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Abstract
{
    public interface IStrategy
    {
        void ExecuteAlgorithm(string someInput);
    }
}
    
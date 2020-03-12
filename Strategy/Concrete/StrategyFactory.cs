using StrategyPattern.Abstract;
using StrategyPattern.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Concrete
{
    public class StrategyFactory
    {
        public IStrategy GetStrategy(StrategyEnum.Algorithms algorithm)
        {
            switch (algorithm)
            {
                case StrategyEnum.Algorithms.Algorithm1:
                    return new Algorithm1();
                case StrategyEnum.Algorithms.Algorithm2:
                    return new Algorithm2();
                default:
                    return new Algorithm1();
            }
        }
    }
}

using StrategyPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Concrete
{
    public class Algorithm1 : IStrategy
    {
        public void ExecuteAlgorithm(string someInput) =>
            Console.WriteLine($"Executing Algorithm 1 for input: {someInput}");
    }
}

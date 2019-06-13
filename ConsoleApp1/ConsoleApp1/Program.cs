using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
  
        }
        public double CaclMean(List<double> values)
        {
            return values.Sum() / values.Count;
        }
        public double CaclMedian(List<double> values)
        {
            var sortedVals = values.Sort((x) => { x > x }).ToList();
            return sortedVals;
        }


    }
}

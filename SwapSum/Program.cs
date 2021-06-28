using System;
using System.Collections.Generic;
using System.Linq;

namespace SwapSum
{
    class SwapSum
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 7,1,8 };
            PairWise(list);
        }
        static void PairWise(List<int> list)
        {
            List<int> result = new List<int>();
          
            List<int> pair;

            if (list.Count == 1)
            {

                result.Add(list[0]);
            }
            else if (list.Count == 2)
            {
               
                result.Add(list[0] + list[1]);
            }
            else
            {
                for (int i = 0; i <= list.Count - 3; i++)
                {

                    pair = new List<int> { list[i], list[i + 1], list[i + 2] };

                    var maxSum = MaxSum(pair);
                    result.Add(maxSum);
                }
               
            }
            var maximixedPair = result.Sum();
            Console.WriteLine("total sum should be maximized:" + maximixedPair);
        }

        static int MaxSum(List<int> list)
        {
            List<int> allSums = new List<int>();
            int sumDefault = SumOfPair(list);
            allSums.Add(sumDefault);

            List<int> tempList = new List<int>(list);
            var temp = list[1];
            tempList[1] = tempList[0];
            tempList[0] = temp;

            var sumFirst = SumOfPair(tempList);
            allSums.Add(sumFirst);

            tempList = new List<int>(list);
            tempList[1] = tempList[2];
            tempList[2] = temp;

            var sumSecond = SumOfPair(tempList);
            allSums.Add(sumSecond);

            return allSums.Max();
        }

        static int SumOfPair(List<int> list)
        {
            var first = list[0] + list[1];
            var second = list[1] + list[2];
            return first + second;
        }
    }
}

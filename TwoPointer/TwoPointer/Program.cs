using System;

namespace TwoPointer // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] result = TestMethod(new int[] {1,2,3,4,6}, 6);

            for(int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        private static int[] TestMethod(int[] intArr, int target)
        {
            int endPoint = intArr.Length - 1;
            int startPoint = 0;

            while(intArr[startPoint] + intArr[endPoint] != target)
            {
                if (intArr[startPoint] + intArr[endPoint] > target)
                {
                    --endPoint;
                }
                else
                {
                    ++startPoint;
                }
            }

            return new int[] { startPoint, endPoint };

        }
    }
}

using System;
using System.Collections.Generic;

namespace TwoPointer // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] result = RemoveUnsortedKey.GetUnsortedKey(new int[] {2, 11, 2, 2, 1}, 2);

            for(int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        private static int[] TestMethod(int[] intArr, int target)
        {
            Dictionary<int, int> hashMap = new();

            for(int i = 0; i < intArr.Length; i++)
            {
                if (hashMap.ContainsKey(target - intArr[i]))
                {
                    return new int[] { hashMap[target - intArr[i]], intArr[i] };
                }
                else
                {
                    hashMap.Add(intArr[i], intArr[i]);
                }
               
            }
            //Pair not found
            return new int[] { -1, -1 };

        }
    }
}

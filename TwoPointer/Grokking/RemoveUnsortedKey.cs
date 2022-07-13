using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPointer
{
    internal class RemoveUnsortedKey
    {
        public static int[] GetUnsortedKey(int[] items, int targetKey)
        {
            int nextNonKey = 0;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != targetKey)
                {
                    items[nextNonKey] = items[i];
                    nextNonKey++;
                }

            }

            return items;
        }
    }
}

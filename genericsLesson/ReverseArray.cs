using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericsLesson
{
    public class ReverseArray<T>
    {
        public static T[] ReverseArrayFunc(T[] array)
        {
            T[] reversedArray = new T[array.Length];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversedArray[array.Length - 1 - i] = array[i];
            }
            return reversedArray;
        }
    }
}

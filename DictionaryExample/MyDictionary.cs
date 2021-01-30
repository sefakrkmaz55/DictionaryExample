using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T, V>

    {
        T[] keyArray;
        V[] valueArray;

        public MyDictionary()
        {
            keyArray = new T[0];
            valueArray = new V[0];
        }


        public void Add(T key, V value)
        {

            T[] tempKey = keyArray;
            V[] tempValue = valueArray;

            keyArray = new T[keyArray.Length + 1];

            valueArray = new V[valueArray.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)

            {
                keyArray[i] = tempKey[i];

            }

            for (int i = 0; i < tempValue.Length; i++)
            {
                valueArray[i] = tempValue[i];
            }

            keyArray[keyArray.Length - 1] = key;

            valueArray[valueArray.Length - 1] = value;

            Console.WriteLine(key + " Model araba : " + " " + value+" aittir");
        }


    }


}
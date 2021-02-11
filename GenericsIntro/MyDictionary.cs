using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyDictionary<int32, T>
    {
        //Fields
        int[] _value;
        int[] _tempValue;

        T[] _key;
        T[] _tempKey;

        //Constructor
        public MyDictionary()
        {
            _value = new int[0];
            _key = new T[0];
        }

        //Method
        public void Add(int value, T key)
        {
            _tempValue = _value;
            _tempKey = _key;

            _value = new int[_value.Length + 1];
            _key = new T[_key.Length + 1];

            for (int i = 0; i < _tempValue.Length; i++)
            {
                _value[i] = _tempValue[i];
                _key[i] = _tempKey[i];

            }
            _value[_value.Length - 1] = value;
            _key[_key.Length - 1] = key;

        }
        public int Count { get { return _value.Length; } }

        public void Show()
        {
            for (int i = 0; i < _value.Length; i++)
            {
                Console.WriteLine("ID: " + _value[i] + " Name: " + _key[i]);

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class MyStack
    {
        private object?[] arrStack;
        private int _size;

        public int Size 
        {
            get { return _size; }
        }


        private const int _defaultCapacity = 10;

        MyStack()
        {
            arrStack = new object[_defaultCapacity];
            _size = -1;
        }

     
        MyStack(int capacity)
        {
            arrStack = new object[capacity];
            _size = -1;
        }
        private bool IsFull()
        {
            return _size == arrStack.Length - 1;
        }
        private bool IsEmpty()
        {
            return _size == -1;
        }

        public object Push(object value)
        {
            if(IsFull())
            {
               throw new Exception($"Stack limit {Size} - size exception");
            }
            ++_size;
            arrStack[_size] = value;
            return arrStack[_size];
        }

        public object Pop(object value)
        {
            int a = 0;
            if (IsEmpty())
            {
                throw new Exception($"An Object not created , null exception");
            }

            object poppedValue = arrStack[_size];
            arrStack[_size] = null;
            _size--;

            return poppedValue;
        }

    }
}

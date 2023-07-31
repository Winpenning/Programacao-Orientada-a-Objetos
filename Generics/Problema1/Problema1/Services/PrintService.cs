using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1.Services
{
    public class PrintService
    {
        private int[] Array = new int[10];
        private int _Count = 0;
        public void AddValue(int value)
        {
            if (_Count == 10)
            {
                throw new InvalidOperationException("EXCEPTION! PrintService is full!");
            }
            else
            {
                Array[_Count] = value;
                _Count++;
            }
        }
        public int First()
        {
            if (_Count == 0)
            {
                throw new IndexOutOfRangeException("EXCEPTION! PrintService is empty!");
            }
            else
            {
                return Array[0];
            }
        }
        public void Print()
        {
            if (_Count == 0)
            {
                throw new IndexOutOfRangeException("EXCEPTION! PrintService is empty!");
            }
            else
            {
                Console.Write("[");
                for (int i = 0; i < _Count - 1; i++)
                {
                    Console.Write(Array[i] + ", ");
                }
                Console.Write(Array[_Count - 1]);
                Console.Write("]");
            }
        }
    }
}

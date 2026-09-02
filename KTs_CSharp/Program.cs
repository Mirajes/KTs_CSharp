using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTs_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class IntArrayList
    {
        private int[] _buffer;
        private int _capacity;
        private int _count;

        private readonly int _default_capacity = 2;

        public int Capacity => _capacity;
        public int Count => _count;

        // indexator?

        public IntArrayList()
        {
            _buffer = new int[_default_capacity];
        }

        public IntArrayList(int capacity)
        {
            _buffer = new int[capacity];
        }

        public void PushBack(int value)
        {
            if (_count >= _capacity)
            {
                _capacity *= 2;
                int[] bufferBuffer = new int[_capacity];
                for (int i = 0; i <= _buffer.Length; i++)
                {
                    bufferBuffer[i] = _buffer[i];
                }
                _buffer[_count++] = value;
                _count += 1;
            }
            else
            {
                _buffer[_count++] = value;
                _count += 1;
            }
        }

        public void PopBack()
        {
            //
        }
    }
}

//https://newlxp.ru/education/0cb66444-773b-4b66-a9e4-60508ea6ea6c/disciplines/b6cfb8ab-bd6e-462a-9d01-2822fd4c5c46/topics/64724cb6-a32a-4d30-855c-85b8ce2feee5

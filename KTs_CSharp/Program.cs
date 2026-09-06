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
                _count++;
            }
            else
            {
                _buffer[_count++] = value;
                _count++;
            }
        }

        public void PopBack()
        {
            if (_count == 0)
            {
                return;
            }
            else
            {
                _buffer[_count - 1] = 0;
                _count--;
            }
        }

        public bool TryInsert(int index, int value)
        {
            if (index == _count - 1)
            {
                PushBack(value);
                return true;
            }
            else if (index < _count - 1)
            {
                int[] afterBuffer = new int[_count];
                for (int i = index; i < _count - 1; i++)
                {
                    afterBuffer[i] = _buffer[i];
                }

                _buffer[index] = value;
                for (int i = index + 1; i < afterBuffer.Length; i++)
                {
                    _buffer[i] = afterBuffer[i];
                }

                _count++;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TryErase(int index)
        {
            if (index > _count - 1)
            {
                return false;
            }
            else
            {
                // ?
                _buffer[index] = 0;
                _count--;
                return true;
            }
        }

        public bool TryGetAt(int index, out int result)
        {
            result = 0;

            if (index < 0 || index > _count)
            {
                return false;
            }

            // ?
        }

        public void Clear()
        {
            for (int i = 0; i < _count; i++)
            {
                _buffer[i] = 0;
            }
        }

        public bool TryForceCapacity(int newCapacity)
        {
            if (newCapacity < 0)
            {
                return false;
            }
            else if ()
        }

        public int Find(int value)
        {
            int index = -1;

            foreach (int i in _buffer)
                if (value == _buffer[i])
                    return i;

            return index;
        }

        public void Print()
        {
            Console.WriteLine($"Capacity is {_capacity}");
            for (int index = 0; index < _count; index++)
            {
                if (_buffer[index] == 0)
                    continue;

                Console.WriteLine($"[{index}] - {_buffer[index]}");
            }
        }
    }
}

//https://newlxp.ru/education/0cb66444-773b-4b66-a9e4-60508ea6ea6c/disciplines/b6cfb8ab-bd6e-462a-9d01-2822fd4c5c46/topics/64724cb6-a32a-4d30-855c-85b8ce2feee5

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
            IntArrayList newList = new IntArrayList();

            newList.PushBack(1);
            newList.PushBack(2);
            newList.Print();
            newList.TryInsert(0, 3);
            newList[0] = 67;
            newList.Print();
            newList.PushBack(52);
            newList[3] = 2;
            newList.PushBack(7);
            newList.Print();
        }
    }

    public class IntArrayList // = List
    {
        private int[] _array; // buffer
        private int _capacity; // only size
        private int _count; // usefull ints

        private readonly int _ROnly_capacity = 2;

        public int Capacity => _capacity;
        public int Count => _count;

        public int this[int index]
        {
            get => _array[index];
            set
            {
                if (_array[index] == 0)
                {
                    _array[index] = value;
                    _count += 1;
                }
                else
                {
                    _array[index] = value;
                }
            }
        }

        public IntArrayList()
        {
            _array = new int[_ROnly_capacity];
            _capacity = _ROnly_capacity;
        }

        public IntArrayList(int capacity)
        {
            _array = new int[capacity];
            _capacity = capacity;
        }

        public void PushBack(int value)
        {
            if (_count >= _capacity)
            {
                _capacity *= 2;
                int[] newArray = new int[_capacity];
                for (int i = 0; i < _count; i++)
                {
                    newArray[i] = _array[i];
                }

                _array = newArray;
                _array[_count] = value;
                _count += 1;
            }
            else
            {
                _array[_count] = value;
                _count += 1;
            }
        }

        public void PopBack()
        {
            if (_count == 0) return;

            _array[_count - 1] = 0;
            _count -= 1;
        }

        public bool TryInsert(int index, int value)
        {
            if (index < 0 || index >= _capacity) return false;

            if (index == _count)
            {
                PushBack(value);
                return true;
            }

            int[] newArray = new int[_capacity];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }

            newArray[index] = value;
            for (int i = index + 1; i < _count; i++)
            {
                newArray[i] = _array[i];
            }

            _array = newArray;

            _count += 1;
            return true;
        }

        public bool TryErase(int index)
        {
            if (index < 0 || index > _count - 1) return false;

            _array[index] = 0;
            _count -= 1;
            return true;
        }

        public bool TryGetAt(int index, out int result)
        {
            if (index < 0 || index > _count - 1)
            {
                result = 0;
                return false;
            }

            result = _array[index];
            return true;
        }

        public void Clear()
        {
            for (int i = 0; i < _count; i++)
            {
                _array[i] = 0;
            }

            _count = 0;
        }

        public bool TryForceCapacity(int newCapacity)
        {
            if (newCapacity < 0) return false;

            int[] newArray = new int[newCapacity];

            if (newCapacity > _capacity)
            {
                for (int i = 0; i < _count; i++)
                {
                    newArray[i] = _array[i];
                }
            }
            else
            {
                for (int i = 0; i < newCapacity; i++)
                {
                    newArray[i] = _array[i];
                }
            }

            _array = newArray;
            return true;
        }

        public int Find(int value)
        {
            int index = -1;

            foreach (int i in _array)
            {
                if (value == _array[i])
                {
                    return i;
                }
            }

            return index;
        }

        public void Print()
        {
            Console.WriteLine($"\nCapacity is {_capacity}");
            for (int index = 0; index < _count; index++)
            {
                if (_array[index] == 0)
                    continue;

                Console.WriteLine($"[{index}] - {_array[index]}");
            }
        }
    }
}

//https://newlxp.ru/education/0cb66444-773b-4b66-a9e4-60508ea6ea6c/disciplines/b6cfb8ab-bd6e-462a-9d01-2822fd4c5c46/topics/64724cb6-a32a-4d30-855c-85b8ce2feee5

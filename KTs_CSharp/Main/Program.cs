using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            newList.TryInsert(1, 3);
            newList[0] = 67;
            newList.Print();
            newList.PushBack(52);
            newList[3] = 10;
            newList.PushBack(7);
            newList.Print();

            newList.Clear();
            newList.Print();
        }
    }
    // generic class
    public class Book<Id>
    {
        private string _name;
        private int _pagesCount;
        private string _author;
        private Id _id;

        public override string ToString()
        {
            // ??
            return base.ToString();
        }

        // ??
    }

    // default values
    public class Class<T>
    {
        private T _value;
        public T Value => _value;

        public Class(T value)
        {
            _value = value;
        }

        public void Reset()
        {
            _value = default(T);
        }
    }

    // generic method
    public class Figure
    {
        private float _center; // ?

    }

    public class Circle<T> : Figure
    {
        public T Radius => _radius;
        private T _radius;

        public Circle(T radius)
        {
            _radius = radius;
        }

        public void SetRadius(T radius)
        {
            _radius = radius;
        }
        // ??
    }
}

//https://newlxp.ru/education/0cb66444-773b-4b66-a9e4-60508ea6ea6c/disciplines/b6cfb8ab-bd6e-462a-9d01-2822fd4c5c46/topics/64724cb6-a32a-4d30-855c-85b8ce2feee5

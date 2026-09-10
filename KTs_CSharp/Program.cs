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
            newList.TryInsert(1, 3);
            newList[0] = 67;
            newList.Print();
            newList.PushBack(52);
            newList[3] = 10;
            newList.PushBack(7);
            newList.Print();

            newList.Clear();
            newList.Print();

            //Product wow = new Product("wow1", 123, 1);
            //wow.Change(new Product("im new", 666, 3));
        }
    }
}

//https://newlxp.ru/education/0cb66444-773b-4b66-a9e4-60508ea6ea6c/disciplines/b6cfb8ab-bd6e-462a-9d01-2822fd4c5c46/topics/64724cb6-a32a-4d30-855c-85b8ce2feee5

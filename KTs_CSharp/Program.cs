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
}

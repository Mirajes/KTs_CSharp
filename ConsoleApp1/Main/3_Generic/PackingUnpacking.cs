using System.Collections.Generic;

namespace KTs_CSharp
{
    public class PackingUnpacking
    {
        public void Calculate()
        {
            List<object> objectList = new List<object> { 5, 3f, 23, 2.345f, 10.2f, 32 };
            float summResult = 0;
            // method CountDown
            foreach (object obj in objectList)
            {
                summResult += (float)obj;
            }
        }
    }
}

//https://newlxp.ru/education/0cb66444-773b-4b66-a9e4-60508ea6ea6c/disciplines/b6cfb8ab-bd6e-462a-9d01-2822fd4c5c46/topics/64724cb6-a32a-4d30-855c-85b8ce2feee5

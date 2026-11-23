namespace KTs_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Helper.CreateAnIdentation("KT CHECKER");
                Console.Write("SELECT KT:" +
                    "\n[1] - IntArrayList (repeating OOP + Arrays)" +
                    "\n[2] - CatFramework (Libraries)" +
                    "\n[4] - TaxPayer (Polymorphic Type Hierarchies)");
                Helper.GetAnswer();

                switch (Helper.Answer)
                {
                    case "1":
                        KT1_IntArrayList kt1 = new();
                        kt1.Enter();
                        break;
                    case "2":
                        KT2_LibraryOfCats kt2 = new();
                        kt2.Enter();
                        break;
                    case "4":
                        RealKT1_TaxPayer realkt1 = new();
                        realkt1.Enter();
                        break;
                }
            }
        }
    }
}

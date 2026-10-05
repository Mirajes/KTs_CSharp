namespace KTs_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helper helper = new Helper();

            while (true)
            {
                helper.CreateAnIdentation("KT CHECKER");
                Console.Write("SELECT KT:" +
                    "\n[1] - IntArrayList (repeating OOP + Arrays)" +
                    "\n[2] - CatFramework (Libraries)");
                helper.MakeNewAnswer();

                switch (helper.Answer)
                {
                    case "1":
                        KT1_IntArrayList kt1 = new();
                        kt1.Enter();
                        break;
                    case "2":
                        break;
                }
            }
        }
    }

    public abstract class A_KT
    {
        public abstract void Enter();
    }
}

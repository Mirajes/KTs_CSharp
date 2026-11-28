namespace KTs_CSharp
{
    public class PrototypeProgram
    {
        public List<A_Prototype> Prototypes { get; private set; } = new();

        public enum ProtorypeType
        {
            Cube,
            Sphere
        }

        public void Enter()
        {
            while (true)
            {
                Console.WriteLine("A_Prototype Program -> Select Action:" +
                    "\n[1] - lazy");

                Helper.GetAnswer();

                switch (Helper.Answer)
                {
                    case "1":
                        Cube cube1 = new Cube();
                        cube1.Clone(out IObject cubeClone);


                        break;
                    case "exit":
                        return;
                }
            }
        }
    }
}

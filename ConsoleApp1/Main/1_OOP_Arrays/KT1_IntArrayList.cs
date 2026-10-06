namespace KTs_CSharp
{
    public class KT1_IntArrayList : A_KT
    {
        public override void Enter()
        {
            while (true)
            {
                Helper.CreateAnIdentation("KT1_IntArrayList");
                Console.WriteLine("[1] - lazy debug" +
                    "\n[nonlazy] - debug" +
                    "\n[exit] - to exit");

                Helper.GetAnswer();

                IntArrayList newList = new();
                switch (Helper.Answer)
                {
                    case "1":
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
                        Console.WriteLine();
                        break;
                    case "nonlazy":
                        newList = new();
                        while (true)
                        {
                            newList.PrintInARow();
                            Console.WriteLine("[recreate] - Create new List with your capacity" +
                                "\n[push] - Push back new Int" +
                                "\n[pop] - Pop last Int" +
                                "\n[insert] - Try Insert new Int" +
                                "\n[erase] - Try erase Int" +
                                "\n[get] - Try get an Int => bool + out Int" +
                                "\n[clear] - Clear" +
                                "\n[force] - Recreate List with your capacity => bool" +
                                "\n[find] - Find => Int index" +
                                "\n[print] - Print Ints, Capacity and Count of List (no 0)" +
                                "\n[printAll] - Print everything");

                            Helper.GetAnswer();
                            switch (Helper.Answer)
                            {
                                case "recreate":
                                    Console.Write(" newCapacity is >> ");
                                    if (!IntChecker(Console.ReadLine(), out int newCapacity))
                                        break;

                                    if (newCapacity < 0)
                                    {
                                        Console.WriteLine("Your answer was lower than zero, capacity will be default => 2");
                                        newCapacity = newList.CapacityBase;
                                    }

                                    newList = new IntArrayList(newCapacity);
                                    break;

                                case "push":
                                    Console.Write(" int to push >> ");
                                    if (!IntChecker(Console.ReadLine(), out int intToPush))
                                        break;

                                    newList.PushBack(intToPush);
                                    break;

                                case "pop":
                                    newList.PopBack();
                                    break;

                                case "insert":
                                    Console.Write(" index >> ");
                                    if (!IntChecker(Console.ReadLine(), out int insertIndex))
                                        break;
                                    Console.Write(" value >> ");
                                    if (!IntChecker(Console.ReadLine(), out int insertValue))
                                        break;
                                    newList.TryInsert(insertIndex, insertValue);
                                    break;

                                case "erase":
                                    Console.Write(" index >> ");
                                    if (!IntChecker(Console.ReadLine(), out int eraseIndex))
                                        break;
                                    newList.TryErase(eraseIndex);
                                    break;

                                case "get":
                                    Console.Write(" index >> ");
                                    if (!IntChecker(Console.ReadLine(), out int getIndex))
                                        break;
                                    newList.TryGetAt(getIndex, out int getResult);
                                    Console.WriteLine($"Your result is {getResult}");
                                    break;
                                case "clear":
                                    newList.Clear();
                                    break;

                                case "force":
                                    Console.Write(" newCapacity >> ");
                                    if (!IntChecker(Console.ReadLine(), out int forceCapacity))
                                        break;
                                    newList = new IntArrayList(forceCapacity);
                                    break;

                                case "find":
                                    Console.Write(" find value >> ");
                                    if (!IntChecker(Console.ReadLine(), out int findValue))
                                        break;
                                    int findIndex = newList.Find(findValue);
                                    Console.WriteLine($"Your value at index: {findIndex}");
                                    break;

                                case "print":
                                    newList.Print();
                                    break;

                                case "printAll":
                                    newList.PrintAll();
                                    break;

                                case "exit":
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine($"wrong answer => {Helper.Answer}");
                                    break;
                            }
                        }
                    case "exit":
                        Console.Clear();
                        return;
                }
            }
        }

        private bool IntChecker(string? tryNumber, out int number)
        {
            if (int.TryParse(tryNumber, out number)) return true;
            else
            {
                Console.WriteLine("Wrong number");
                return false;
            }
        }
    }
}

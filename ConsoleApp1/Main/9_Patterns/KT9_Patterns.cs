namespace KTs_CSharp
{
    public class KT9_Patterns : A_KT
    {
        public override void Enter()
        {
            while (true)
            {
                Helper.CreateAnIdentation("KT9_Patterns");
                Console.WriteLine($"" +
                    $"[1] - 3D Program" +
                    $"[2] - Coffee Machine" +
                    $"[3] - Public Chat" +
                    $"[4] - Restaraunt" +
                    $"[5] - Shop" +
                    $"[exit] - exit");

                Helper.GetAnswer();

                switch (Helper.Answer)
                {
                    case "1":

                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine($"{Helper.Answer} -> Incorrect");
                        break;
                }
            }
        }
    }

    public class CoffeeMachine
    {

    }

    public interface ICoffeeMachineState
    {

    }

    public class WaitForCoinState : ICoffeeMachineState { }
    public class ChooseDrinkState : ICoffeeMachineState { }
    public class GiveDringState : ICoffeeMachineState { }
    public class ReadyState : ICoffeeMachineState { }

    public class StateMachine { }

    public interface IChatMediator
    {
        void Register() { }
        void SendMessage(string message) { }
        void GetMessage(string message) { }
    }
    public class ChatManager { }
    public class ChatMediator : IChatMediator { }


    public interface IOrder
    {
        void GetPrice();
        void GetDescription();
    }
    public class  BaseOrder
    {
        public double MinCost { get; protected set; }
    }
    // decorators


    public class Shop
    {

    }
}

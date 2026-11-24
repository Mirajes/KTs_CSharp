namespace KTs_CSharp
{
    public class KT8_SmartHome : A_KT
    {
        public override void Enter()
        {
            while (true)
            {
                Helper.CreateAnIdentation("KT8_SmartHome");
                Console.WriteLine("[1] - lazy" +
                    "\n[non] - nonlazy" +
                    "\n[exit]");

                Helper.GetAnswer();

                SmartHome newSmartHome = new();
                switch (Helper.Answer)
                {
                    case "1":
                        Console.WriteLine("\nПереключаем умный дом на Ночной режим");
                        newSmartHome.SetUpHome(SmartHome.SmartHomeMode.Night);
                        Console.WriteLine("\nПереключаем умный дом на \"Один Дома\"");
                        newSmartHome.SetUpHome(SmartHome.SmartHomeMode.HomeAlone);
                        Console.WriteLine("\nПереключаем умный дом на Вечеринку");
                        newSmartHome.SetUpHome(SmartHome.SmartHomeMode.Party);
                        break;
                    case "non":
                        while (true)
                        {
                            Console.WriteLine("Выберите режим => " +
                                "\n[night]" +
                                "\n[party]" +
                                "\n[morning]" +
                                "\n[lesson]" +
                                "\n[outside]" +
                                "\n[homealone]" +
                                "\n[exit] - to exit");

                            Helper.GetAnswer();

                            switch (Helper.Answer)
                            {
                                case "night":
                                    newSmartHome.SetUpHome(SmartHome.SmartHomeMode.Night);
                                    break;
                                case "party":
                                    newSmartHome.SetUpHome(SmartHome.SmartHomeMode.Party);
                                    break;
                                case "morning":
                                    newSmartHome.SetUpHome(SmartHome.SmartHomeMode.GoodMorning);
                                    break;
                                case "lesson":
                                    newSmartHome.SetUpHome(SmartHome.SmartHomeMode.GoingToLessons);
                                    break;
                                case "outside":
                                    newSmartHome.SetUpHome(SmartHome.SmartHomeMode.GoingOut);
                                    break;
                                case "homealone":
                                    newSmartHome.SetUpHome(SmartHome.SmartHomeMode.HomeAlone);
                                    break;
                                case "exit":
                                    return;
                                default:
                                    Console.WriteLine("я вас не поняла");
                                    break;
                            }
                        }
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("я вас не поняла");
                        break;
                }
            }
        }
    }
}

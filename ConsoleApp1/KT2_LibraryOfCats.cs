using CatFramework;

namespace KTs_CSharp
{
    public class KT2_LibraryOfCats : A_KT
    {
        private readonly Random _random = new();
        private readonly Func<Cat>[] _catFactories;

        public KT2_LibraryOfCats()
        {
            _catFactories = new Func<Cat>[]
            {
                () => new CuteCat(GetRandomFluffiness(-20, 120)),
                () => new Tiger(GetRandomWeight(50, 160), GetRandomFluffiness(-20, 120))
            }; 
        }
        //private Type[] _availableCats = {
        //    typeof(CuteCat),
        //    typeof(Tiger)
        //};

        public override void Enter()
        {
            while (true) 
            {
                Helper.CreateAnIdentation("KT2_LibrabryOfCats");
                Console.WriteLine("\n[1] - lazy debug" +
                    "\n[exit] - ?");

                Helper.GetAnswer();
                switch (Helper.Answer)
                {
                    case "1":
                        uint lazy_catCount = 12;
                        Console.WriteLine($"number of cats: {lazy_catCount}");
                        Cat[] lazy_catArray = GenerateRandomCats(lazy_catCount);
                        DisplayCatInfo(lazy_catArray, "");
                        break;
                    case "exit":

                        return;
                }
            }
        }

        public Cat[] GenerateRandomCats(uint count)
        {
            Cat[] catArray = new Cat[count];

            for (int i = 0; i < count; i++)
            {
                int randomIndex = _random.Next(_catFactories.Length);

                catArray[i] = _catFactories[randomIndex]();                
            }

            return catArray;
        }

        public void DisplayCatInfo(Cat[] catsArr, string path) // path?
        {
            for (int i = 0; i < catsArr.Length; i++)
            {
                Cat askedCat = catsArr[i];
                askedCat.FluffinessCheck();
                askedCat.ToString();
            }
        }

        private int GetRandomFluffiness(int minValue, int maxValue)
        {
            return _random.Next(minValue, maxValue + 1);
        }

        private double GetRandomWeight(double minValue, double maxValue)
        {
            return _random.NextDouble() * (maxValue - minValue) + minValue;
        }
    }
}

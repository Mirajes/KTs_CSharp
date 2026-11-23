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
                    "\n[2] - CatFramework (Libraries)");
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
                }
            }
        }
    }

    public abstract class Property
    {
        protected double _Worth;
        protected double _Tax;
        public Property(double worth)
        {
            _Worth = worth;
            CalculateTax();
        }
        public virtual void CalculateTax() { }
    }

    public class Immovable : Property
    {
        protected double _Area;

        public Immovable(double worth,double area) : base(worth)
        {
            _Area = area;
        }

        public override void CalculateTax() // тз писал урод
        {
            if (_Area < 100)
            {
                _Tax = _Worth * (1 / 500);
            }
            else if (_Area > 100 && _Area < 300)
            {
                _Tax = _Worth * (1 / 350);
            }
            else if (_Area > 300)
            {
                _Tax = _Worth * (1 / 250);
            }
            else
            {
                Console.WriteLine($"Ваша недвижимость будет списана :3");
            }
        }
    }

    public class Vehicle : Property
    {
        protected double _EngineDisplacement; // объём двигателя

        public Vehicle(double worth, double engineDisplacement) : base(worth)
        {
            _EngineDisplacement = engineDisplacement;
        }

        public override void CalculateTax()
        {
            _Tax = _Worth * _EngineDisplacement / 3000;
        }
    }

    public class Car : Vehicle
    {
        public Car(double worth, double engineDisplacement) : base(worth, engineDisplacement) { }
    }

    public class Boat : Vehicle
    {
        public Boat(double worth, double engineDisplacement) : base(worth, engineDisplacement) {}
    }

    public class Appartment : Immovable
    {
        public Appartment(double worth, double area) : base(worth, area) { }
    }

    public class CountryHouse : Immovable
    {
        public CountryHouse(double worth, double area) : base(worth, area) { }
    }
}

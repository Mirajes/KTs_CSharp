using System.Drawing;

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

    public class KT8_SmartHome : A_KT
    {
        public override void Enter()
        {
            
        }
    }

    public class SmartHome
    {
        Light _light = new();

        public void SetUpHome() { } // ???
    }

    public class Light
    {
        public bool IsTurnedOn { get; private set; }
        public float Brightness { get; private set; }
        public Color Color { get; private set; }

        public void SwitchLight() // toggle lights 
        {
            IsTurnedOn = !IsTurnedOn;
        }

        public void ChangeBrightness(float brightness)
        {
            // range?
            Brightness = brightness;
        }
        public void ChangeColor(Color color)
        {
            Color = color;
        }

        public override string ToString()
        {
            return $"{IsTurnedOn}, {Brightness}, {Color}";
        }
    }

    public class TV
    {
        public bool IsTurnedOn { get; private set; }
        public string Program { get; private set; } = "Первый анал";

        public void SwitchTV() // toggleTV
        {
            IsTurnedOn = !IsTurnedOn;
        }
        public void TurnOnProgram(string program)
        {
            Program = program;
        }

        public override string ToString()
        {
            return $"{IsTurnedOn}, {Program}";
        }
    }

    public class AirConditioner
    {
        public bool IsTurnedOn { get; private set; }
        float Temperature;

        public void Switch() // toggle
        {
            IsTurnedOn = !IsTurnedOn;
        }

        public void SetTemperature(float temperature)
        {
            Temperature = temperature;
        }

        public override string ToString()
        {
            return $"{IsTurnedOn}, {Temperature}";
        }
    }

    public class MusicStation
    {
        public bool IsTurnedOn { get; private set; }
        public string Music { get; private set; } = string.Empty;

        public void Switch()
        {
            IsTurnedOn = !IsTurnedOn;
        }

        public void SetMusic(string music)
        {
            Music = music;
        }
    }
}

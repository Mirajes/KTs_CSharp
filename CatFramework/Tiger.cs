namespace CatFramework
{
    public class Tiger : Cat
    {
        public override int Fluffiness => _Fluffiness;
        public double Weight => _weight;
        private double _weight;

        public Tiger(double weight = 50, int fluffiness = 50)
        {
            //bool isCanBeThatWeight = true;
            //bool isCanBeThatFluffiness = true;

            if (weight <= 75.0 || weight > 140.0)
            {
                throw new CatException($"Unable to create a tiger with weight: {weight}");
            }
            else
            {
                _weight = weight;
            }

            if (fluffiness < 0 || fluffiness > 100)
            {
                 throw new CatException($"Unable to create a tiger with fluffiness {fluffiness}");
            }
            else
            {
                _Fluffiness = fluffiness;
            }
        }

        public override string FluffinessCheck()
        {
            return "kys";
        }

        public override string ToString()
        {
            return $"A tiger with weight: {_weight} fluffiness: {_Fluffiness}";
        }
    }
}

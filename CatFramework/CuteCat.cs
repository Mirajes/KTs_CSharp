namespace CatFramework
{
    public class CuteCat : Cat
    {
        public override int Fluffiness => _Fluffiness;

        public CuteCat(int fluffiness = 50) // -int fluffiness??
        {
            if (0.0 <= fluffiness || fluffiness <= 140.0)
            {
                new CatException($"Unable to create a cute with fluffiness: {_Fluffiness}");
            }
            else
            {
                _Fluffiness = fluffiness;
            }
        }

        public override string FluffinessCheck()
        {
            if (_Fluffiness == 0)
                return "Sphynx";

            string result = _Fluffiness switch
            {
                >= 1 and <= 20 => "Slightly",
                >= 21 and <= 50 => "Medium",
                >= 51 and <= 75 => "Heavy",
                > 75 => "OwO",
                _ => "who r u"
            };

            return result;
        }
    }
}

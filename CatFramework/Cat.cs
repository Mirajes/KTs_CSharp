namespace CatFramework
{
    public abstract class Cat
    {
        protected int _Fluffiness;
        public abstract int Fluffiness { get; }
        public abstract string FluffinessCheck();

        public override string ToString()
        {
            return $"A cat with fluffiness: {Fluffiness}";
        }
    }
}

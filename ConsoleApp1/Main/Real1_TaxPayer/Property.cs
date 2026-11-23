namespace KTs_CSharp
{
    public abstract class Property
    {
        protected double _Worth;
        protected double _Tax;

        public Property(double worth)
        {
            _Worth = worth;
        }
        public virtual void CalculateTax() { }
    }
}

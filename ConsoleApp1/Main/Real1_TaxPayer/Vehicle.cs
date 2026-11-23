namespace KTs_CSharp
{
    public class Vehicle : Property
    {
        protected double _EngineDisplacement; // объём двигателя

        public Vehicle(double worth, double engineDisplacement) : base(worth)
        {
            _EngineDisplacement = engineDisplacement;
            CalculateTax();
        }

        public override void CalculateTax()
        {
            _Tax = _Worth * _EngineDisplacement / 3000;
        }

        public override string ToString()
        {
            return $"{this.GetType()}: Стоимость - {_Worth}, налог - {_Tax}, объём двигателя - {_EngineDisplacement} см.куб";
        }
    }
}

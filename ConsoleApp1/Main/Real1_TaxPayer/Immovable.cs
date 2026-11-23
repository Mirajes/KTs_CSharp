namespace KTs_CSharp
{
    public class Immovable : Property
    {
        public double TaxPerMeter => _TaxPerMeter;

        protected double _Area;
        protected double _TaxPerMeter;

        public Immovable(double worth,double area) : base(worth)
        {
            _Area = area;
            CalculateTax();
        }

        public override void CalculateTax() // тз писал урод
        {
            if (_Area < 100)
            {
                _TaxPerMeter = 1 / 500;
                _Tax = _Worth * _TaxPerMeter;
            }
            else if (_Area > 100 && _Area < 300)
            {
                _TaxPerMeter = 1 / 350;
                _Tax = _Worth * _TaxPerMeter;
            }
            else if (_Area > 300)
            {
                _TaxPerMeter = 1 / 250;
                _Tax = _Worth * _TaxPerMeter;
            }
            else
            {
                Console.WriteLine($"Ваша недвижимость будет списана :3");
            }
        }

        public override string ToString()
        {
            return $"{this.GetType()}: Стоимость - {_Worth}, налог - {_Tax}, площадь - {_Area} кв.м";
        }
    }
}

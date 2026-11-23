namespace KTs_CSharp
{
    public class RealKT1_TaxPayer : A_KT
    {
        private Property[] _properties = new Property[10];

        public override void Enter()
        {
            Helper.CreateAnIdentation("RealKT1_TaxPayer");

            _properties[0] = new Appartment(5000000, 350);
            _properties[1] = new Appartment(15000000, 1373);
            _properties[2] = new Appartment(3500000, 209);

            _properties[3] = new Car(1000000, 3000);
            _properties[4] = new Car(150000, 1600);
            _properties[5] = new Car(500000, 2677);

            _properties[6] = new Boat(400000, 2666);
            _properties[7] = new Boat(300033, 1337);

            _properties[8] = new CountryHouse(12000000, 360);
            _properties[9] = new CountryHouse(500000, 36);

            foreach (var property in _properties)
            {
                Console.WriteLine(property.ToString());
            }

            while (true)
            {


                Console.WriteLine("[exit] - to Exit");
                Helper.GetAnswer();
                switch (Helper.Answer)
                {
                    case "exit":
                        return;
                }
            }
        }
    }
}

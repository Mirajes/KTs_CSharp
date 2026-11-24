namespace KTs_CSharp
{
    public class AirConditioner : Device
    {
        public float Temperature { get; private set; }

        public void Switch() // toggle
        {
            IsTurnedOn = !IsTurnedOn;
            OnSwitch(IsTurnedOn);
        }

        public void Switch(bool isTurnedOn)
        {
            IsTurnedOn = isTurnedOn;
            OnSwitch(IsTurnedOn);
        }

        public void SetTemperature(float temperature)
        {
            Temperature = temperature;
        }

        public override string ToString()
        {
            return $"Кондиционер => Включён: {IsTurnedOn}, Температура: {Temperature}";
        }

        protected override void OnSwitch(bool turnedOn)
        {
            if (!turnedOn)
            {
                Temperature = 0f;
            }
        }
    }
}

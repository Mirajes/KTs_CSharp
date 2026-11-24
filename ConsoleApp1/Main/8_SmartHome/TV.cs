namespace KTs_CSharp
{
    public class TV : Device
    {
        public string Program { get; private set; } = "Первый анал";

        public void SwitchTV() // toggleTV
        {
            IsTurnedOn = !IsTurnedOn;
            OnSwitch(IsTurnedOn);
        }

        public void SwitchTV(bool isTurnedOn)
        {
            IsTurnedOn = isTurnedOn;
            OnSwitch(IsTurnedOn);
        }

        public void TurnOnProgram(string program)
        {
            Program = program;
        }

        public override string ToString()
        {
            return $"Телевизор => Включён: {IsTurnedOn}, Канал: {Program}";
        }

        protected override void OnSwitch(bool turnedOn)
        {
            if (!IsTurnedOn)
            {
                Program = string.Empty;
            }
        }
    }
}

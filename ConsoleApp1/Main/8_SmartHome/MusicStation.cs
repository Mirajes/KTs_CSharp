namespace KTs_CSharp
{
    public class MusicStation : Device
    {
        public string Music { get; private set; } = string.Empty;

        public void Switch()
        {
            IsTurnedOn = !IsTurnedOn;
            OnSwitch(IsTurnedOn);
        }

        public void Switch(bool isTurnedOn)
        {
            IsTurnedOn = isTurnedOn;
            OnSwitch(IsTurnedOn);
        }

        public void SetMusic(string music)
        {
            Music = music;
        }

        public override string ToString()
        {
            return $"Колонка => Включена: {IsTurnedOn}, Текущий трек: {Music}";
        }

        protected override void OnSwitch(bool turnedOn)
        {
            if (!turnedOn)
            {
                Music = string.Empty;
            }
        }
    }
}

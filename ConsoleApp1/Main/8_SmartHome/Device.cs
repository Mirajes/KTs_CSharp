namespace KTs_CSharp
{
    public class Device 
    {
        public bool IsTurnedOn { get; protected set; }

        protected virtual void OnSwitch(bool turnedOn) { }
    }
}

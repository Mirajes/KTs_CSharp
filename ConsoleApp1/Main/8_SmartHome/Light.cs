using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace KTs_CSharp
{
    public class Light : Device
    {
        [Range(0, 1)] public float Brightness { get; private set; }
        public Color Color { get; private set; }

        public void SwitchLight() // toggle lights 
        {
            IsTurnedOn = !IsTurnedOn;
            OnSwitch(IsTurnedOn);
        }

        public void SwitchLight(bool isTurnedOn)
        {
            IsTurnedOn = isTurnedOn;
            OnSwitch(IsTurnedOn);
        }

        public void ChangeBrightness(float brightness)
        {
            // range?
            Brightness = brightness;
        }
        public void ChangeColor(Color color)
        {
            Color = color;
        }

        public override string ToString()
        {
            return $"Лампа => Включена: {IsTurnedOn}, Яркость: {Brightness}, Цвет: {Color}";
        }

        protected override void OnSwitch(bool isTurned)
        {
            if (!isTurned)
            {
                Brightness = 0f;
                Color = Color.Empty;
            }
        }
    }
}

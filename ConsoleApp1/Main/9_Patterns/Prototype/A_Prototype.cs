using System.Drawing;
using System.Numerics;

namespace KTs_CSharp
{
    public abstract class A_Prototype : IObject
    {
        public Vector3 Position { get; protected set; }
        public Vector3 Scale { get; protected set; }
        public Color Color { get; protected set; }

        //public abstract IObject Clone();
        public virtual void Clone(out IObject clone)
        {
            clone = this.MemberwiseClone() as A_Prototype;  // буквально создание копии (поверхностное)
            // для глубокого копирования => делать через return + переопределение в наследнике (от проблем с ссылками)
        }
        public A_Prototype(Vector3 position = new Vector3(), Vector3 scale = new Vector3(), Color color = new Color())
        {
            Position = position;
            Scale = scale;
            Color = color;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"{this.ToString()} - position {Position}, scale {Scale}, color {Color}");
        }
    }
}

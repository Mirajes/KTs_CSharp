namespace KTs_CSharp
{
    public class Circle<T> : Figure
    {
        public T Radius => _radius;
        private T _radius;

        public Circle(T radius)
        {
            _radius = radius;
        }

        public void SetRadius(T radius)
        {
            _radius = radius;
        }
        // ??
    }
}

//https://newlxp.ru/education/0cb66444-773b-4b66-a9e4-60508ea6ea6c/disciplines/b6cfb8ab-bd6e-462a-9d01-2822fd4c5c46/topics/64724cb6-a32a-4d30-855c-85b8ce2feee5

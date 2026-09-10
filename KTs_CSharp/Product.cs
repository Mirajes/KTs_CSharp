namespace KTs_CSharp
{
    public class Product
    {
        private string _name;
        private double _price;
        private int _quantity;

        public Product(string name, double price, int quantity)
        {
            _name = name;
            _price = price;
            _quantity = quantity;
        }

        public void ApplyDiscount(int percent)
        {
            if (percent <= 0) return;

            double discount = _price * percent / 100;
            _price -= discount;
        }

        public void Change(Product product)
        {
            _name = product._name;
            _price = product._price;
            _quantity = product._quantity;
        }
    }
}

//https://newlxp.ru/education/0cb66444-773b-4b66-a9e4-60508ea6ea6c/disciplines/b6cfb8ab-bd6e-462a-9d01-2822fd4c5c46/topics/64724cb6-a32a-4d30-855c-85b8ce2feee5

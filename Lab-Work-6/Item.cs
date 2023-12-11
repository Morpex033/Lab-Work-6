namespace Lab_Work_6
{
    internal abstract class Item
    {
        private readonly string _title; // Название продукта
        public string Title { get; init; }

        private double _price; // Цена продукта

        public double Price { get; set; }

        private double _quantity; // Количество на складе продукта

        public double Quantity { get => _quantity; set => _quantity = value > 0 ? value : 0; }

        public Item(string title, double price, double quantity)
        {
            Title = title;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Price: {Price}, Quantity: {Quantity}";
        }
    }
}

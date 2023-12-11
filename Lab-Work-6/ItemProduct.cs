namespace Lab_Work_6
{
    internal class ItemProduct : Item, IItem
    {
        private ItemCategory _category; // Категория товара

        public ItemCategory Category
        {
            get => _category;
            set
            {
                try
                {
                    _category = value;
                }
                catch (Exception e)
                {
                    _category = ItemCategory.None;
                    Console.WriteLine($"This category does not exist. Exception - ${e}");
                }
            }
        }

        private readonly DateTime _expiryDate; // Дата окончания срока годности

        public DateTime ExpiryTime
        {
            get => _expiryDate;
            init => _expiryDate = value;
        } 

        private readonly bool _inStock; // Наличие товара на складе

        public bool InStock { get => _inStock; init => _inStock = value; }
        public ItemProduct(string title, double price, double quantity, ItemCategory itemCategory) : base(title, price, quantity)
        {
            Category = itemCategory;
            ExpiryTime = DateTime.Now.AddDays(365);
            InStock = Quantity != 0;
        }
        //Возвращает цену со скидкой или без неё
        public double GetPrice(double? discount)
        {
            if (discount.HasValue)
            {
                if (discount is > 1 or < 0)
                {
                    Console.WriteLine("The discount is not correct");
                    return Price;
                }
                else
                {
                    return (double)(Price * (1 - discount));
                }
            }

            return Price;
        }

        public string GetInfo()
        {
            return ToString();
        }

        public override string ToString()
        {
            return base.ToString() + $", Category: {Category}, In Stock: {InStock}, Expiry Time: {ExpiryTime}";
        }
    }
}

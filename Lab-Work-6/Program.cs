namespace Lab_Work_6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Item item1 = new ItemProduct("Chocolate", 5, 100, ItemCategory.Food);
            ItemProduct item2 = new ItemProduct("Sweatshirt", 15, 20, ItemCategory.Clothing);
            ItemProduct item3 = new ItemProduct("Telephone", 50, 10, ItemCategory.Electronics);
            ItemDB itemDb = new ItemDB();
            itemDb.Add(item1);
            itemDb.Add(item2);
            itemDb.Add(item3);
            itemDb.Print();
        }
    }
}


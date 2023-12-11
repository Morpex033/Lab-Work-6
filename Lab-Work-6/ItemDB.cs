namespace Lab_Work_6
{
    internal class ItemDB
    {
        private List<Item> _list = new List<Item>(); //Массив обьектов 

        public List<Item> List
        {
            get => _list;
            set => _list = value;
        }

        //Добавление елемента в массив
        public void Add(Item entity)
        {
            try
            {
                List.Add(entity);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //Удадение елемента из массива по index
        public void Remove(int id)
        {

            try
            {
                List.RemoveAt(id);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Wrong input");
            }
        }

        //Удаление елемента из массива
        public void Remove(Item entity)
        {
            try
            {
                List.Remove(entity);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
                throw;
            }
            ;
        }

        //Выввод массива в консоль
        public void Print()
        {
            for (int i = 0; i < List.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {List[i]}");
            }
        }
    }
}

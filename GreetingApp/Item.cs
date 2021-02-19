using System.Collections.Generic;

namespace GreetingApp
{
    public class Item : IItem
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public List<Item> GetAllItems()
        {
            var itemList = new List<Item>()
            {
                new Item
                {
                    Name = "Item1",
                    Age = 4,
                }
            };
            return itemList;
        }
    }
}

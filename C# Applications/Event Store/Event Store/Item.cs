using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Store
{
    class Item
    {
        public int ID { get; private set; }

        public string Name { get; private set; }
        public double Price { get; private set; }

        public int Quantity { get; private set; }

        public int LeftInStock { get; set; }

        public bool OnlyForAdults { get; private set; }

        public Item(int id, string name, double price, int leftinstock, bool onlyforadults)
        {
            ID = id;
            Name = name;
            Price = price;
            Quantity = 0;
            LeftInStock = leftinstock;
            OnlyForAdults = onlyforadults;
        }

        public void UpdateQuantity(int n)
        {
            Quantity = Quantity + n;
        }
    }
}

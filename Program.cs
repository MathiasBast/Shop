using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Shop
    {
        private List<Item> items;
        private int maxContacts;
        public Shop (int maxContacts)
        {
            items = new List<Item>(maxContacts);
            this.maxContacts = maxContacts;
        }

    }
    class Item
    {

    }
}

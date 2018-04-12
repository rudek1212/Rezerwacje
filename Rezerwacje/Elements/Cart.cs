using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezerwacje.Elements
{
    public class Cart
    {
        public List<Item> List = new List<Item>();
        public int CustomerId { get; set; }

        public Item AddItem(Item item)
        {
            List.Add(item);
            return List[List.Count - 1];

        }
    }
}

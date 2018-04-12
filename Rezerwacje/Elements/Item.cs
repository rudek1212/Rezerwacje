using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezerwacje.Elements
{
    public class Item
    {
        private static int _counter = 1000000;

        public Item(Size size, Type type, string name)
        {
            Id = _counter++;
            Size = size;
            Type = type;
            Name = name;
        }

        public int Id { get; set; }
        public Size Size { get; set; }
        public Type Type { get; set; }
        public string Name { get; set; }
    }
}

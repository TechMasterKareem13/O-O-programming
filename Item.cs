using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_O_programming
{
    internal class Item
    {
        internal string Name;
        internal string Description;
        internal decimal Price;

        internal Item()
        {

        }

        internal Item(string Iname, string IDescription, decimal IPrice)
        {
            Name = Iname;   
            Description = IDescription;
            Price = IPrice;
        }

        internal bool isCostly()
        {
            return (Price >= 300m);
        }


    }
}

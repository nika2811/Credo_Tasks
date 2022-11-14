using Burgerbuilder.Kitchen;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Burgerbuilder.Kitchen
{
    internal class Burger
    {
        public bool MeltedCheese { get; set; }
        public bool Pickles { get; set; }
        public string Meat { get; set; }
        public string Sauce { get; set; }
        public bool Lettuce { get; set; }
        public bool Cookie { get; set; }

        public Burger(bool meltedCheese, bool pickles, string meat, string sauce, bool lettuce, bool cookie)
        {
            MeltedCheese = meltedCheese;
            Pickles = pickles;
            Meat = meat;
            Sauce = sauce;
            Lettuce = lettuce;
            Cookie = cookie;
        }

        public override string ToString()
        {
            return $"MeltedCheese: {MeltedCheese} \nPickles: {Pickles}\nMeat: {Meat}\nSauce: {Sauce}\nLettuce:{Lettuce}\nCookie:{Cookie}";
        }


    }

}



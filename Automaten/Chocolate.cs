using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class Chocolate
    {
        string name;
        int price;

        public string Name
        {

            get { return name; }

            set { name = value; }

        }

        public int Price
        {
            get { return price; }

            set { price = value; }
        }

        public Chocolate()
        {

        }

        //this. = that the value is always used when this class is used
        public Chocolate(string name, int price)
        {
            this.name = name;
            this.price = price;
        }










    }
}

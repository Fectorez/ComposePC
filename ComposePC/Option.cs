using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposePC
{
    public abstract class Option : IOption
    {
        protected double Price;

        protected Option(double price)
        {
            this.Price = price;
        }

        public double GetPrice()
        {
            return Price;
        }
    }
}

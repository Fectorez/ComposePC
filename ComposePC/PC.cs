using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposePC
{
    public class PC : IPC
    {
        private static double INITIAL_PRICE = 300.0;
        private List<IOption> Options;
        private double Price;

        public PC(List<IOption> options, double optionsPrice)
        {
            this.Options = options;
            this.Price = INITIAL_PRICE + optionsPrice;
        }

        public double GetPrice()
        {
            return Price;
        }

        public void SetPrice(double price)
        {
            this.Price = price;
        }
    }
}

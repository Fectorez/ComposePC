using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposePC
{
    public interface IPC
    {
        double GetPrice();
        void SetPrice(double price);
    }
}

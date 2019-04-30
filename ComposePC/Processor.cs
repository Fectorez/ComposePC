using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposePC
{
    public abstract class Processor : Option
    {
        protected Processor(double price) : base(price)
        {
        }
    }
}

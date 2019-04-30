using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposePC
{
    public class PCBuilder : IPCBuilder
    {
        private List<IOption> Options = new List<IOption>();
        private double OptionsPrice = 0.0;

        public PCBuilder(Processor processor, Ram ram)
        {
            Options.Add(processor);
            Options.Add(ram);
            OptionsPrice += processor.GetPrice();
            OptionsPrice += ram.GetPrice();
        }

        private IPCBuilder AddOption(IOption option)
        {
            Options.Add(option);
            OptionsPrice += option.GetPrice();
            return this;
        }

        public IPCBuilder AddScreen(Screen screen)
        {
            return AddOption(screen);
        }

        public IPCBuilder AddMouse(Mouse mouse)
        {
            return AddOption(mouse);
        }

        public IPC Build()
        {
            return new PC(Options, OptionsPrice);
        }
    }
}

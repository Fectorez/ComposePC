using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposePC
{
    public interface IPCBuilder
    {
        IPCBuilder AddScreen(Screen screen);
        IPCBuilder AddMouse(Mouse mouse);

        IPC Build();
    }
}

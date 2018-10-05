
using System;
using System.Collections.Generic;
using System.Text;
using Adapter.Interfaces;

namespace Adapter
{
    class Driver
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Adapter.Interfaces;

namespace Adapter
{
    class CamelToTransportAdapter : ITransport
    {
        private Camel _camel;

        public CamelToTransportAdapter(Camel camel)
        {
            _camel = camel;
        }

        public void Drive()
        {
            _camel.Move();
        }
    }
}

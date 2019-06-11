using Adapter.Interfaces;

namespace Adapter
{
    internal class CamelToTransportAdapter : ITransport
    {
        private readonly Camel _camel;

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
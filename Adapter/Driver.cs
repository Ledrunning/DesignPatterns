using Adapter.Interfaces;

namespace Adapter
{
    internal class Driver
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }
}
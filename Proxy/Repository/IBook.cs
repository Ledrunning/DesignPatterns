using System;

namespace Proxy.Repository
{
    internal interface IBook : IDisposable
    {
        Page GetPage(int number);
        void SetData(Page data);
    }
}
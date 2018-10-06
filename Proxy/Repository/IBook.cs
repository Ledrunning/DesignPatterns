using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    interface IBook : IDisposable
    {
        Page GetPage(int number);
        void SetData(Page data);
    }
}

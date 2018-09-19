using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Interfaces
{
    public interface IObserver
    {
        void Update(Object ob);
    }
}

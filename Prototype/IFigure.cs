using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }
}

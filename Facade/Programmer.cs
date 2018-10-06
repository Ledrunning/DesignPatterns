using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Programmer
    {
        public void CreateApplication(VisualStudioFacade facade)
        {
            facade.Start();
            facade.Stop();
        }
    }
}

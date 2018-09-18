using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.Houses;

namespace FactoryMethod.Developers
{
    /// <summary>
    /// Классы строительных компаний
    /// </summary>
    /// <param name="args"></param>
    class PanelDeveloper : Developer
    {
        public PanelDeveloper(string name) : base(name)
        {
        }

        public override House Create()
        {
            return new PanelHouse();
        }
    }
}

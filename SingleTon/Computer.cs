using System;
using System.Collections.Generic;
using System.Text;

namespace SingleTon
{
    class Computer
    {
        public OpSystem Os { get; set; }

        public void Launch(string osName)
        {
            Os = OpSystem.GetInstance(osName);
        }
    }
}

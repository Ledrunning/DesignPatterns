using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class MicrowaveCommand : ICommand
    {
        private Microwave _microwave;
        private int _time;

        public MicrowaveCommand(Microwave m, int t)
        {
            _microwave = m;
            _time = t;
        }

        public void Execute()
        {
            _microwave.StartCooking(_time);
            _microwave.StopCooking();
        }

        public void Undo()
        {
            _microwave.StopCooking();
        }
    }
}

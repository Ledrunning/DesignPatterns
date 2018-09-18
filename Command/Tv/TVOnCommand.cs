using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Tv
{
    // Reciever - Получатель
    public class TVOnCommand : ICommand
    {
        private TV _tv;

        public TVOnCommand(TV tvSet)
        {
            _tv = tvSet;
        }

        public void Execute()
        {
            _tv.On();
        }

        public void Undo()
        {
            _tv.Off();
        }
    }
}

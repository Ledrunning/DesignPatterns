using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    // Invoker - инициализатор
    class RemoteControl
    {
        private ICommand _iCommand;

        public RemoteControl()
        {

        }

        public void SetCommand(ICommand command)
        {
            _iCommand = command;
        }

        public void PressButton()
        {
            _iCommand.Execute();
        }

        public void PressUndo()
        {
            _iCommand.Undo();
        }
    }
}

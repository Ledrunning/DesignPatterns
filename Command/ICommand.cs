using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}

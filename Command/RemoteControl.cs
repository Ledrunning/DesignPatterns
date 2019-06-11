namespace Command
{
    /// <summary>
    ///     Класс Invoker - инициализатор
    /// </summary>
    internal class RemoteControl
    {
        private ICommand _iCommand;

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
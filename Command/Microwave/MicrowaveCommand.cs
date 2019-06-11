namespace Command.Microwave
{
    internal class MicrowaveCommand : ICommand
    {
        private readonly Microwave _microwave;
        private readonly int _time;

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
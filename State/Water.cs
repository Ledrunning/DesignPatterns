namespace State
{
    public class Water
    {
        public Water(IWaterState ws)
        {
            State = ws;
        }

        public IWaterState State { get; set; }

        public void Heat()
        {
            State.Heat(this);
        }

        public void Frost()
        {
            State.Frost(this);
        }
    }
}
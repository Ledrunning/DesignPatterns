namespace Strategy
{
    internal class Car
    {
        protected string model;
        protected int passengers;

        public Car(int num, string model, IMovable move)
        {
            passengers = num;
            this.model = model;
            Movable = move;
        }

        public IMovable Movable { private get; set; }

        public void Move()
        {
            Movable.Move();
        }
    }
}
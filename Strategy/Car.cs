using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Car
    {
        protected int passengers;
        protected string model;

        public IMovable Movable { private get; set; }

        public Car(int num, string model, IMovable move)
        {
            passengers = num;
            this.model = model;
            Movable = move;
        }

        public void Move()
        {
            Movable.Move();
        }
    }
}

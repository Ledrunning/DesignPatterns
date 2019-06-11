using System;
using System.Threading.Tasks;

namespace Command.Microwave
{
    public class Microwave
    {
        public void StartCooking(int time)
        {
            Console.WriteLine("Подогреваем еду");

            // имитация работы с помощью асинхронного метода Task.Delay
            Task.Delay(time).GetAwaiter().GetResult();
        }

        public void StopCooking()
        {
            Console.WriteLine("Еда подогрета");
        }
    }
}
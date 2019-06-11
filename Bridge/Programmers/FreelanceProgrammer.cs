using System;

namespace Bridge.Programmers
{
    internal class FreelanceProgrammer : Programmer
    {
        public FreelanceProgrammer(ILanguage language) : base(language)
        {
        }

        public override void EarnMoney()
        {
            Console.WriteLine("Получаем оплату за выполненный заказ");
        }
    }
}
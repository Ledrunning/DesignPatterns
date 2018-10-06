using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class FreelanceProgrammer : Programmer
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

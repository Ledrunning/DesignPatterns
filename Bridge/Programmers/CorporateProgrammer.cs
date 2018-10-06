using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class CorporateProgrammer : Programmer
    {
        public CorporateProgrammer(ILanguage language) : base(language)
        {
        }

        public override void EarnMoney()
        {
            Console.WriteLine("Получаем в конце месяца зарплату");
        }
    }
}

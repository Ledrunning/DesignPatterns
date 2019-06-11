using System;

namespace Bridge.Programmers
{
    internal class CorporateProgrammer : Programmer
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
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    abstract class Programmer
    {
        protected ILanguage language;

        public ILanguage Language
        {
            set { language = value; }
        }

        public Programmer(ILanguage language)
        {
            this.language = language;
        }

        public virtual void DoWork()
        {
            language.Build();
            language.Execute();
        }

        public abstract void EarnMoney();

    }
}

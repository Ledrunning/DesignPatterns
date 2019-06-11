namespace Bridge.Programmers
{
    internal abstract class Programmer
    {
        protected ILanguage language;

        public Programmer(ILanguage language)
        {
            this.language = language;
        }

        public ILanguage Language
        {
            set => language = value;
        }

        public virtual void DoWork()
        {
            language.Build();
            language.Execute();
        }

        public abstract void EarnMoney();
    }
}
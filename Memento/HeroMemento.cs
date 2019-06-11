namespace Memento
{
    /// <summary>
    ///     Memento
    /// </summary>
    public class HeroMemento
    {
        public HeroMemento(int patrons, int lives)
        {
            Patrons = patrons;
            Lives = lives;
        }

        public int Patrons { get; }
        public int Lives { get; }
    }
}
using System.Collections.Generic;

namespace Memento
{
    /// <summary>
    ///     Caretaker
    /// </summary>
    public class GameHistory
    {
        public GameHistory()
        {
            History = new Stack<HeroMemento>();
        }

        public Stack<HeroMemento> History { get; }
    }
}
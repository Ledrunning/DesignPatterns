using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    /// <summary>
    /// Memento
    /// </summary>
    public class HeroMemento
    {
        public int Patrons { get; private set; }
        public int Lives { get; private set; }

        public HeroMemento(int patrons, int lives)
        {
            Patrons = patrons;
            Lives = lives;
        }
    }
}

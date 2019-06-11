using FactoryMethod.Houses;

namespace FactoryMethod.Developers
{
    /// <summary>
    ///     Строительная компания
    /// </summary>
    internal abstract class Developer
    {
        public Developer(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public abstract House Create();
    }
}
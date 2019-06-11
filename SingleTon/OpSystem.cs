namespace SingleTon
{
    internal class OpSystem
    {
        private static OpSystem instance;

        protected OpSystem(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public static OpSystem GetInstance(string name)
        {
            if (instance == null) instance = new OpSystem(name);

            return instance;
        }
    }
}
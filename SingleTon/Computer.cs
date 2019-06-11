namespace SingleTon
{
    internal class Computer
    {
        public OpSystem Os { get; set; }

        public void Launch(string osName)
        {
            Os = OpSystem.GetInstance(osName);
        }
    }
}
namespace Iterator.Interfaces
{
    public interface IBookNumerable
    {
        int Count { get; }
        Book this[int index] { get; }
        IBookIterator CreateNumerator();
    }
}
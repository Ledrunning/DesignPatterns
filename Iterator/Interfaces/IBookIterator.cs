namespace Iterator.Interfaces
{
    public interface IBookIterator
    {
        bool HasNext();
        Book Next();
    }
}
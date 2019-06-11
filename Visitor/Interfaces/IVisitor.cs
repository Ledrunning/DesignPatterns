namespace Visitor.Interfaces
{
    public interface IVisitor
    {
        void VisitPersonAccount(Person account);
        void VisitCompanyAccount(Company account);
    }
}
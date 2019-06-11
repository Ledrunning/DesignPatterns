using System.Linq;
using Proxy.Repository;

namespace Proxy
{
    internal class BookStore : IBook
    {
        private readonly PageContext _dbContext;

        public BookStore()
        {
            _dbContext = new PageContext();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public Page GetPage(int number)
        {
            return _dbContext.Pages.FirstOrDefault(p => p.Number == number);
        }

        public void SetData(Page page)
        {
            _dbContext.Pages.Add(page);
            _dbContext.SaveChanges();
        }
    }
}
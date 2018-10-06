using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    class BookStore : IBook
    {
        private PageContext _dbContext;

        public BookStore()
        {
            _dbContext = new PageContext();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public Page GetPage(int number) => _dbContext.Pages.FirstOrDefault(p => p.Number == number);

        public void SetData(Page page)
        {
            _dbContext.Pages.Add(page);
            _dbContext.SaveChanges();
        }
    }
}

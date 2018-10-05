using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class Bank
    {
        List<IAccount> accounts = new List<IAccount>();

        public void Add(IAccount account)
        {
            accounts.Add(account);
        }

        public void Remove(IAccount account)
        {
            accounts.Remove(account);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var account in accounts)
            {
                account.Accept(visitor);
            }
        }
    }
}

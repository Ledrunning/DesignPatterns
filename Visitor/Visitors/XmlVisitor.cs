using System;
using Visitor.Interfaces;

namespace Visitor.Visitors
{
    /// <summary>
    ///     Сериализация в Xml
    /// </summary>
    public class XmlVisitor : IVisitor
    {
        public void VisitCompanyAccount(Company account)
        {
            var result = "<Company><Name>" + account.Name + "</Name>" +
                         "<RegNumber>" + account.RegNumber + "</RegNumber>" +
                         "<Number>" + account.Number + "</Number><Company>";
            Console.WriteLine(result);
        }

        public void VisitPersonAccount(Person account)
        {
            var result = "<Person><Name>" + account.Name + "</Name>" +
                         "<Number>" + account.Number + "</Number><Person>";
            Console.WriteLine(result);
        }
    }
}
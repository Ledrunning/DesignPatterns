using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    /// <summary>
    /// Сериализация в Xml
    /// </summary>
    public class XmlVisitor : IVisitor
    {
        public void VisitCompanyAccount(Company account)
        {
            string result = "<Company><Name>" + account.Name + "</Name>" +
                            "<RegNumber>" + account.RegNumber + "</RegNumber>" +
                            "<Number>" + account.Number + "</Number><Company>";
            Console.WriteLine(result);
        }

        public void VisitPersonAccount(Person account)
        {
            string result = "<Person><Name>" + account.Name + "</Name>" +
                            "<Number>" + account.Number + "</Number><Person>";
            Console.WriteLine(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    /// <summary>
    /// Сериализаия в Html
    /// </summary>
    public class HtmlVisitor : IVisitor
    {
        public void VisitPersonAccount(Person account)
        {
            string result = "<table><tr><td>Свойство<td><td>Значение</td></tr>";
            result += $"<tr><td>Name<td><td>{account.Name}</td></tr>";
            result += $"<tr><td>Number<td><td>{account.Number}</td></tr></table>";
            Console.WriteLine(result);
        }

        public void VisitCompanyAccount(Company account)
        {
            string result = "<table><tr><td>Свойство<td><td>Значение</td></tr>";
            result += $"<tr><td>Name<td><td>{account.Name}</td></tr>";
            result += $"<tr><td>RegNumber<td><td>{account.RegNumber}</td></tr>";
            result += $"<tr><td>Number<td><td>{account.Number}</td></tr></table>";
            Console.WriteLine(result);
        }

    }
}

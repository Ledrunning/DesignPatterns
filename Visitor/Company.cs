using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Company : IAccount
    {
        public string Name { get; set; }
        public string RegNumber { get; set; }
        public string Number { get; set; }

        public void ToHtml()
        {
            string result = "<table><tr><td>Свойство<td><td>Значение</td></tr>";
            result += $"<tr><td>Name<td><td>{Name}</td></tr>";
            result += $"<tr><td>RegNumber<td><td>{RegNumber}</td></tr>";
            result += $"<tr><td>Number<td><td>{Number}</td></tr></table>";
            Console.WriteLine(result);
        }
    }
}

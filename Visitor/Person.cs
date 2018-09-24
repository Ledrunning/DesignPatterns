using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Person : IAccount
    {
        public string Name { get; set; }
        public string AccountNumber { get; set; }

        public void ToHtml()
        {
            string result = @"<table><tr><td>Свойство<td><td>Значение</td></tr>";
            result += $"<tr><td>FIO<td><td>{Name}</td></tr>";
            result += $"<tr><td>Number<td><td>{AccountNumber}</td></tr></table>";
            Console.WriteLine(result);
        }
    }
}

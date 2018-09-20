using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class NumberExpression : IExpression
    {
        private string _name;

        public NumberExpression(string variableName)
        {
            _name = variableName;
        }

        public int Interpret(Context context)
        {
            return context.GetVariable(_name);
        }
    }
}

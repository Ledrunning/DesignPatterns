using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class AddExpression : IExpression
    {
        private IExpression _leftExpression;
        private IExpression _rightExpression;

        public AddExpression(IExpression left, IExpression right)
        {
            _leftExpression = left;
            _rightExpression = right;
        }

        public int Interpret(Context context)
        {
            return _leftExpression.Interpret(context) + _rightExpression.Interpret(context);
        }
    }
}

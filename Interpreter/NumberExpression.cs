namespace Interpreter
{
    internal class NumberExpression : IExpression
    {
        private readonly string _name;

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
using Builder.Ingredients;

namespace Builder.Builders
{
    /// <summary>
    ///     Строитель для ржаного хлеба
    /// </summary>
    internal class RyeBreadBuilder : BreadBuilder
    {
        public override void SetFlour()
        {
            Bread.Flour = new Flour {Sort = "Ржаная мука 1 сорт"};
        }

        public override void SetSalt()
        {
            Bread.Salt = new Salt();
        }

        public override void SetAdditives()
        {
            // не используется
        }
    }
}
using Builder.Ingredients;

namespace Builder.Builders
{
    /// <summary>
    ///     Строитель для пшеничного хлеба
    /// </summary>
    internal class WheatBreadBuilder : BreadBuilder
    {
        public override void SetFlour()
        {
            Bread.Flour = new Flour {Sort = "Пшеничная мука высший сорт"};
        }

        public override void SetSalt()
        {
            Bread.Salt = new Salt();
        }

        public override void SetAdditives()
        {
            Bread.Additives = new Additives {Name = "улучшитель хлебопекарный"};
        }
    }
}
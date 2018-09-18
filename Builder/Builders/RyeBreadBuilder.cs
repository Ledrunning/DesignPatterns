using Builder.Ingredients;

namespace Builder.Builders
{
	// Строитель для ржаного хлеба
	class RyeBreadBuilder : BreadBuilder
	{
		public override void SetFlour()
		{
			this.Bread.Flour = new Flour { Sort = "Ржаная мука 1 сорт" };
		}

		public override void SetSalt()
		{
			this.Bread.Salt = new Salt();
		}

		public override void SetAdditives()
		{
			// не используется
		}
	}
}

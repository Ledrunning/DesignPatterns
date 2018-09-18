using System;
using System.Collections.Generic;
using System.Text;
using Builder.Ingredients;

namespace Builder.Builders
{
	// Строитель для пшеничного хлеба
	class WheatBreadBuilder : BreadBuilder
	{
		public override void SetFlour()
		{
			this.Bread.Flour = new Flour { Sort = "Пшеничная мука высший сорт" };
		}

		public override void SetSalt()
		{
			this.Bread.Salt = new Salt();
		}

		public override void SetAdditives()
		{
			this.Bread.Additives = new Additives { Name = "улучшитель хлебопекарный" };
		}
	}
}

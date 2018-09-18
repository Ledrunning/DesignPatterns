using Builder.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
	// Пекарь
	class Baker
	{
		public Bread Bake(BreadBuilder breadBuilder)
		{
			breadBuilder.CreateBread();
			breadBuilder.SetFlour();
			breadBuilder.SetSalt();
			breadBuilder.SetAdditives();
			return breadBuilder.Bread;
		}
	}
}

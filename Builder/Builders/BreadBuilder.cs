using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Builders
{
	// Абстрактный класс строителя
	abstract class BreadBuilder
	{
		public Bread Bread { get; private set; }
		public void CreateBread()
		{
			Bread = new Bread();
		}
		public abstract void SetFlour();
		public abstract void SetSalt();
		public abstract void SetAdditives();
	}
}

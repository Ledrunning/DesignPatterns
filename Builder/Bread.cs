﻿using System.Text;
using Builder.Ingredients;

namespace Builder
{
    internal class Bread
    {
        // Мука
        public Flour Flour { get; set; }

        // Соль
        public Salt Salt { get; set; }

        // Добавки 
        public Additives Additives { get; set; }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            if (Flour != null)
                stringBuilder.Append(Flour.Sort);

            if (Salt != null)
                stringBuilder.Append(" Соль \n");

            if (Additives != null)
                stringBuilder.Append($"Добавки: {Additives.Name}\n");

            return stringBuilder.ToString();
        }
    }
}
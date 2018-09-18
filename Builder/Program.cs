using System;
using System.Text;

namespace Builder
{
    /// <summary>
    /// Строитель (Builder) - шаблон проектирования, который инкапсулирует создание объекта и позволяет разделить его на различные этапы.
    /// Когда использовать паттерн Строитель?
    /// - Когда процесс создания нового объекта не должен зависеть от того, из каких частей этот объект состоит
    /// и как эти части связаны между собой
    /// - Когда необходимо обеспечить получение различных вариаций объекта в процессе его создания
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Builder";

            // Объект пекаря
            Baker baker = new Baker();
            // Строитель для ржаного хлеба
            BreadBuilder breadBuilder = new RyeBreadBuilder();
            // Выпекаем
            Bread ryeBread = baker.Bake(breadBuilder);
            Console.WriteLine(ryeBread.ToString());

            // Строим пшеничный хлеб
            breadBuilder = new WheatBreadBuilder();
            Bread wheatBread = baker.Bake(breadBuilder);
            Console.WriteLine(wheatBread.ToString());

            Console.ReadKey();
        }
    }

        // Мука
        class Flour
        {
            // Сорт муки
            public string Sort { get; set; }
        }

        // Соль 
        class Salt
        {

        }

        // Пищевые добавки
        class Additives
        {
            public string Name { get; set; }
        }

        class Bread
        {
            // Мука
            public Flour Flour { get; set; }
            
            // Соль
            public Salt Salt { get; set; }

            // Добавки 
            public Additives Additives { get; set; }

            public override string ToString()
            {
                StringBuilder stringBuilder = new StringBuilder();

                if (Flour != null)
                    stringBuilder.Append(Flour.Sort);

                if (Salt != null)
                    stringBuilder.Append(" Соль \n");

                if (Additives != null)
                    stringBuilder.Append($"Добавки: {Additives.Name}\n");

                return stringBuilder.ToString();
            }
        }

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

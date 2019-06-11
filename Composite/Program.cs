using System;

namespace Composite
{
    /// <summary>
    ///     Паттерн Компоновщик (Composite) объединяет группы объектов в древовидную структуру по принципу "часть-целое и
    ///     позволяет клиенту одинаково работать как с отдельными объектами, так и с группой объектов.
    ///     Образно реализацию паттерна можно представить в виде меню, которое имеет различные пункты.
    ///     Эти пункты могут содержать подменю, в которых, в свою очередь, также имеются пункты.То есть пункт меню служит с
    ///     одной стороны частью меню,
    ///     а с другой стороны еще одним меню.В итоге мы однообразно можем работать как с пунктом меню, так и со всем меню в
    ///     целом.
    ///     Когда использовать компоновщик?
    ///     Когда объекты должны быть реализованы в виде иерархической древовидной структуры
    ///     Когда клиенты единообразно должны управлять как целыми объектами, так и их составными частями.
    ///     То есть целое и его части должны реализовать один и тот же интерфейс
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Composite";

            Component fileSystem = new Directory("Файловая система");
            // Определяем новый диск
            Component diskC = new Directory("Диск С");
            // Новые файлы
            Component pngFile = new File("12345.png");
            Component docxFile = new File("Document.docx");
            // Добавляем файлы на диск С
            diskC.Add(pngFile);
            diskC.Add(docxFile);
            // Добавляем диск С в файловую систему
            fileSystem.Add(diskC);
            // Выводим все данные
            fileSystem.Print();
            Console.WriteLine();
            // Удаляем с диска С файл
            diskC.Remove(pngFile);
            // Создаем новую папку
            Component docsFolder = new Directory("Мои Документы");
            // Добавляем в нее файлы
            Component txtFile = new File("readme.txt");
            Component csFile = new File("Program.cs");
            docsFolder.Add(txtFile);
            docsFolder.Add(csFile);
            diskC.Add(docsFolder);

            fileSystem.Print();

            Console.ReadKey();
        }
    }
}
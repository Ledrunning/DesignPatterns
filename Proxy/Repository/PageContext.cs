using Microsoft.EntityFrameworkCore;

namespace Proxy.Repository
{
    /// <summary>
    ///     Необходимо настроить миграцию
    ///     Enable-Migrations -ProjectName "Имя проекта" -StartUpProjectName "Запускаемый проект"
    ///     Add-Migration
    ///     Update-Database
    /// </summary>
    internal class PageContext : DbContext
    {
        public PageContext()
        {
        }

        public PageContext(DbContextOptions<PageContext> options)
            : base(options)
        {
        }

        public DbSet<Page> Pages { get; set; }

        // Прописали провайдера и указали адресс БД
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // строка подключения к БД
            optionsBuilder.UseSqlServer(
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VS_Projects_Examples\StudyProjects\DesignPatterns\Proxy\bookDB.mdf;Integrated Security=True");
        }
    }
}
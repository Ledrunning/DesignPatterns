using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Proxy
{
    /// <summary>
    /// Необходимо настроить миграцию
    /// Enable-Migrations -ProjectName "Имя проекта" -StartUpProjectName "Запускаемый проект"
    /// Add-Migration
    /// Update-Database
    /// </summary>
    class PageContext : DbContext
    {
        public DbSet<Page> Pages { get; set; }

        public PageContext() { }

        // Прописали провайдера и указали адресс БД
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\omazinov\Documents\Visual Studio 2017\Projects\DesignPatterns\Proxy\bookDB.mdf"";Integrated Security=True");
        }

        public PageContext(DbContextOptions<PageContext> options)
            : base(options)
        { }
    }
}

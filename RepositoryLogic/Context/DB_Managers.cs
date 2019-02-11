namespace RepositoryLogic.Context
{
    using RepositoryLogic.Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DB_Managers : DbContext
    {
        // Контекст настроен для использования строки подключения "DB_Managers" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "RepositoryLogic.Context.DB_Managers" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "DB_Managers" 
        // в файле конфигурации приложения.
        public DB_Managers()
            : base("name=DB_Managers")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Manager> Managers { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
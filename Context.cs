using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace WinFormsAdminka
{
    //класс контекста БД, с помощью которой уже и будем работать с БД из SQL Express
    public class Context : DbContext
{
    public DbSet<TableMoneyAccounts> TMA { get; set; }
    public DbSet<TableCards> TC { get; set; } = null!;
    public DbSet<TableHisOfOper> THO { get; set; } = null!;
    public DbSet<TableFavourites> TF { get; set; } = null!;
    public Context()
    {

    }
    //метод для подключения к локальной БД MSQL, сама строка подключения находиться в ресурсах
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer (Resource1.StringConnection);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}
}

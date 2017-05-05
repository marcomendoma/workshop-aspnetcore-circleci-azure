using Microsoft.EntityFrameworkCore;
using WorkShopAspnetCore.Models;

namespace WorkShopAspnetCore
{
    //-------------------------------------------------------------------------------------------------------------------------//
    //  -- Nugets packages --
    //
    //  Instalando o Entity Framework Core E tools para Migrations
    //  Install-Package Microsoft.EntityFrameworkCore
    //  Install-Package Microsoft.EntityFrameworkCore.Tools
    //  Install-Package Microsoft.EntityFrameworkCore.SqlServer
    //  Install-Package Microsoft.EntityFrameworkCore.SqlServer.Design
    //-------------------------------------------------------------------------------------------------------------------------//

    //-------------------------------------------------------------------------------------------------------------------------//
    //  Adicionando Migrations
    //  Add-Migration MigracaoInicial
    //  Update-Database
    //-------------------------------------------------------------------------------------------------------------------------//

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :
            base(options) 
        {
            
        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}

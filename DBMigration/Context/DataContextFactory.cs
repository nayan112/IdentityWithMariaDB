using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMigration.Context
{
    public class DataContextFactory : IDesignTimeDbContextFactory<EfcoreTestContext>
    {
        public EfcoreTestContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EfcoreTestContext>();
            //this code will be never executed in runtime only in design time
            builder.UseMySQL("Server=localhost;UserId=root;Password=toor;Database=efcoretest;SslMode=none;");
            return new EfcoreTestContext(builder.Options);
        }
    }
}

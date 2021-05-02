using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApiApricod.Migrations;

namespace WebApiApricod.Model
{
    public class DBAppContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

        public DBAppContext(DbContextOptions<DBAppContext> options) : base(options) {}
    }
}

using Lib.Data.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Data.Context
{
    public class SPMDbContext : DbContext
    {
        public SPMDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<User> User { get; set; }
    }
}

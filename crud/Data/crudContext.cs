using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using crud.model;

namespace crud.Data
{
    public class crudContext : DbContext
    {
        public crudContext (DbContextOptions<crudContext> options)
            : base(options)
        {
        }

        public DbSet<crud.model.user> user { get; set; } = default!;
    }
}

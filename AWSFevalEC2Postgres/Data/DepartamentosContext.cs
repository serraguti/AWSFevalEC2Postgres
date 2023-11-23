using AWSFevalEC2Postgres.Models;
using Microsoft.EntityFrameworkCore;

namespace AWSFevalEC2Postgres.Data
{
    public class DepartamentosContext: DbContext
    {
        public DepartamentosContext(DbContextOptions<DepartamentosContext>
            options): base(options) { }

        public DbSet<Departamento> Departamentos { get; set; }
    }
}

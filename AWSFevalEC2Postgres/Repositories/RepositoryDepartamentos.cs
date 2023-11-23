using AWSFevalEC2Postgres.Data;
using AWSFevalEC2Postgres.Models;
using Microsoft.EntityFrameworkCore;

namespace AWSFevalEC2Postgres.Repositories
{
    public class RepositoryDepartamentos
    {
        private DepartamentosContext context;

        public RepositoryDepartamentos(DepartamentosContext context)
        {
            this.context = context;
        }

        public async Task<List<Departamento>> GetDepartamentosAsync()
        {
            return await this.context.Departamentos.ToListAsync();
        }
    }
}

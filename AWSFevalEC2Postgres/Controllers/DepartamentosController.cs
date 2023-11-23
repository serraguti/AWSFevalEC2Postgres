using AWSFevalEC2Postgres.Models;
using AWSFevalEC2Postgres.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AWSFevalEC2Postgres.Controllers
{
    public class DepartamentosController : Controller
    {
        private RepositoryDepartamentos repo;

        public DepartamentosController(RepositoryDepartamentos repo)
        {
            this.repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            List<Departamento> departamentos = await this.repo.GetDepartamentosAsync();
            return View(departamentos);
        }
    }
}

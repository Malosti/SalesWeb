using SalesWebMVC.Model;
using SalesWebMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMVCContext _context;

        public DepartmentService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            // acessa a fonte de dados da tabela vendedores e converte em uma lista
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}

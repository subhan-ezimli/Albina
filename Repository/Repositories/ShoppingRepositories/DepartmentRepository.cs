using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Repository.Repositories.ShoppingRepositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AlbinaDbContext _context;
        public DepartmentRepository(AlbinaDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Department> GetDepartmentsWithCategory()
        {
            return _context.Departments.Include("Categories")
                                       .Where(d => d.Status)
                                       .ToList();
        }
    }
}

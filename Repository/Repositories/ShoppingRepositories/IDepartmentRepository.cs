﻿using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.ShoppingRepositories
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartmentsWithCategory();

    }
}

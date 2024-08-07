﻿using Crud_Core_Mvc.Data;
using Crud_Core_Mvc.Models.Departments;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Crud_Core_Mvc.Services
{
    public class DepartmentService
    {

        private readonly Crud_Core_MvcContext _context;

        public DepartmentService(Crud_Core_MvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>>FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
        
    }
}

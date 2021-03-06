﻿using BangazonWorkforceMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BangazonWorkforceMVC.Models.ViewModels
{
    public class DepartmentCreateViewModel  
    {
        public Department Department { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public List<SelectListItem> AllEmployeeOptions
        {
            get
            {
                if (Employees == null) return null;

                return Employees
                    .Select(e => new SelectListItem(e.FullName, e.Id.ToString()))
                    .ToList();
            }
        }
    }
}


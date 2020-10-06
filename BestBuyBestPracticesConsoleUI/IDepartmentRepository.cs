using System;
using System.Collections.Generic;

namespace BestBuyBestPracticesConsoleUI
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();
    }
}

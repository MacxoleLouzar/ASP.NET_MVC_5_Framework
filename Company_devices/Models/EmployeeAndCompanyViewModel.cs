using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Company_devices.Models
{
    public class EmployeeAndCompanyViewModel
    {
        public Company Company { get; set; }
        public IEnumerable<Employee> employee { get; set; }
    }
}

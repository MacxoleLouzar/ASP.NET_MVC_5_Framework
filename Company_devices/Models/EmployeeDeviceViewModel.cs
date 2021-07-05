using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Company_devices.Models
{
    public class EmployeeDeviceViewModel
    {
        public Employee Employee { get; set; }
        public IEnumerable<Device> device { get; set; }
    }
}

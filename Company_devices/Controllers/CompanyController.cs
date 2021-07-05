using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Company_devices.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Company_devices.Controllers
{
    
    public class CompanyController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CompanyController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Companies.ToList());
        }
        public IActionResult EmployeeList(int? id)
        {
            if (id == null)
            {
                id = this._db.Companies.FirstOrDefault().id;
                _db.employees.Where(c => c.id == id).ToList();
            }
            var model = new EmployeeAndCompanyViewModel
            {
                employee = _db.employees.Where(x => x.id == id).ToList(),
                Company = _db.Companies.FirstOrDefault(x => x.id==id)
            };
            return View(model);
        }

        public IActionResult addCompany()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> addCompany(Company company)
        {
            if(ModelState.IsValid)
            {
                _db.Add(company);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(company);
        }

        //View Company
        public async Task<IActionResult> viewCompany(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var company = await _db.Companies.SingleOrDefaultAsync(m => m.id == id);
            if (company==null)
            {
                return NotFound();
            }
            return View(company);
        }

        public IActionResult addEmployee(int id)
        {
            Employee employee = new Employee
            {
                id = id
            };
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> addEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _db.Add(employee);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(EmployeeList), new { id = employee.id });
            }
            return View(employee);
        }
        public async Task<IActionResult> viewEmployee(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var employee = await _db.employees.SingleOrDefaultAsync(m => m.Empid == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }
        //Add New Device

        public IActionResult DeviceList(int? id)
        {
            if (id == null)
            {
                //id = this._db.employees.FirstOrDefault().Empid;
                _db.devices.Where(c => c.Empid == id).ToList();
            }

            var model = new EmployeeDeviceViewModel
            {
                device = _db.devices.Where(x => x.Empid == id).ToList()
                //Employee = _db.employees.FirstOrDefault(x => x.Empid == id)
            };
            return View(model);
        }
        public IActionResult addDevice(int id)
        {
            ViewData["Empid"] = new SelectList(_db.employees.Where(m=>m.id==id), "Empid", "FirstName");
            Device device = new Device
            {
                Empid = id
            };
            return View(device);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> addDevice(Device device)
        {
            if (ModelState.IsValid)
            {
                _db.Add(device);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(DeviceList), new { Empid = device.Empid });
            }
            return View(device);
        }



        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing)
            {
                _db.Dispose();
            }
        }
    }
}

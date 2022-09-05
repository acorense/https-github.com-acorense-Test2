using EmployeeCrud.Data;
using EmployeeCrud.Infrastructure;
using EmployeeCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCrud.Service
{
    public class EmployeeRository : IEmployee
    {
        private readonly EmployeeContext _context;
        public void Delete(Employee employee)
        {
            _context.Employees.Remove(employee);
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee GetById(int Id)
        {
            return _context.Employees.Where(e => e.Id == Id).FirstOrDefault();
        }

        public void Insert(Employee employee)
        {
            _context.Employees.Add(employee);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Employee employee)
        {
            _context.Employees.Update(employee);
        }
    }
}

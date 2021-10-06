using DataAccessLayer.Models;
using System.Collections.Generic;

namespace DataAccessLayer.Interfaces
{
    public interface IRepository
    {
       List<Employee> GetAllEmployee();
    }
}

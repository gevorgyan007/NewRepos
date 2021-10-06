using DataAccessLayer.Models;
using System.Collections.Generic;

namespace DataAccessLayer.Interfaces
{
    public interface IRepository
    {
        List<Car> GetCars();
        List<Make> GetMakes();
       
    }
}

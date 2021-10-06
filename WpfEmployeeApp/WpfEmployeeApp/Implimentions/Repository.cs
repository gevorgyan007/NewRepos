using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System.Collections.Generic;

namespace WpfEmployeeApp.Implimentions
{
    public class Repository : IRepository
    {
        

        public  List<Employee> GetAllEmployee()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    FirstName = "Vahan",
                    LastName = "Grigoryan",
                    Age = 25,
                    Addresses = new List<Address>()
                    {
                        new Address()
                        {
                            City = "Yerevan",
                            HomeAddress = "Tumanyan",
                            WorkAddress = "Arshakunyac"
                        }
                    },
                },
                new Employee()
                {
                    FirstName = "Sveta",
                    LastName = "Danielyan",
                    Age = 20,
                    Addresses = new List<Address>()
                    {
                        new Address()
                        {
                            City = "Gyumryu",
                            HomeAddress = "Amiryan",
                            WorkAddress = "Xorenaci"
                        }
                    },
                }
            };
        }
    }
}

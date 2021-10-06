using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocktEST
{
    public interface ICustomerRepository
    {
        void Save(Customer customer);
       // void SaveExtended(Customer customer);
        
    }
}

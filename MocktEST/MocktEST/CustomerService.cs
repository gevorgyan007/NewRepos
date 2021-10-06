using CunsomerServiceLibrary;
using System;
using System.Collections.Generic;

namespace MocktEST
{
    public class CustomerService
    {
        private ICustomerRepository customerRepository;
       // private ICustomerStatusFactory customerStatusFactory;
        //private IIdFactory idFactory;
        private IAddressFactory _addressFactory;

        public CustomerService(ICustomerRepository customerRepository, IAddressFactory addressFactory)
        {
            this.customerRepository = customerRepository;
            _addressFactory = addressFactory;
        }

        public void Create(CustomerDTO customerDTO)
        {
            try
            {
                Customer newCustomer = new Customer();
                newCustomer.FirstName = customerDTO.FirstName;
                newCustomer.LastName = customerDTO.LastName;
                newCustomer.Address = _addressFactory.CreateFrom(customerDTO);
            }
            catch (InvalidCustomerAddressException e)
            {
                throw new CustomerCreateException();
            }

              
            //newCustomer.StatusLevel = customerStatusFactory.CreateFrom(customerDTO);

            //if (newCustomer.StatusLevel == StatusLevel.Gold)
            //{
            //    customerRepository.SaveExtended(newCustomer);
            //}
            //else
            //{
            //    customerRepository.Save(newCustomer);
            //}

        }
    }
    #region  Exceptions

    public class InvalidCustomerAddressException:Exception
    {
        public InvalidCustomerAddressException(string msg):base(msg)
        {
                
        }

        public InvalidCustomerAddressException()
        {
            
        }
    }
    public class CustomerCreateException:Exception
    {
        public CustomerCreateException(string msg):base(msg)
        {
                
        }

        public CustomerCreateException()
        {
                
        }
    }

    #endregion      
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using MocktEST;
using System.Collections.Generic;
using Moq;
using CunsomerServiceLibrary;
using System;



namespace CunsomerServiceLib
{
    [TestClass]
    public class CunsomerServiceTests
    {
        // [TestMethod]
        // [ExpectedException(typeof(ApplicationException))]
        // public void CreateMethod_Save_WasCalled()
        // {
        //     //arrange
        //
        //     CustomerDTO customerDTO = new CustomerDTO { FirstName = "Taron", LastName = "Gevorgyan" };
        //
        //     Mock<ICustomerRepository> mock = new Mock<ICustomerRepository>();
        //     Mock<IEmailBuilder> mock1 = new Mock<IEmailBuilder>();
        //     ICustomerRepository repository = mock.Object;
        //     IEmailBuilder emailBuilder = mock1.Object;
        //
        //     CustomerService customerService = new CustomerService(repository,emailBuilder);
        //
        //     mock1.Setup(x => x.From(It.IsAny<CustomerDTO>()))
        //         .Returns<Address>(null);
        //
        //
        //     customerService.Create(customerDTO);
        //
        //
        // }
        // [TestMethod]
        // public void Create_AddressCreated()
        // {
        //     //arrange
        //
        //     CustomerDTO customerDTO = new CustomerDTO { FirstName = "Taron", LastName = "Gevorgyan" };
        //
        //     Mock<ICustomerRepository> mock = new Mock<ICustomerRepository>();
        //     Mock<IEmailBuilder> mock1 = new Mock<IEmailBuilder>();
        //     ICustomerRepository repository = mock.Object;
        //     IEmailBuilder emailBuilder = mock1.Object;
        //
        //     CustomerService customerService = new CustomerService(repository, emailBuilder);
        //
        //     mock1.Setup(x => x.From(It.IsAny<CustomerDTO>()))
        //         .Returns(() => new Address());
        //
        //
        //     customerService.Create(customerDTO);
        //
        //     mock.Verify(x => x.Save(It.IsAny<Customer>()));
        // }
        // [TestMethod]
        // public void Create_AddressCreated()
        // {
        //     //arrange
        //     List<CustomerDTO> list = new List<CustomerDTO> {
        //         new CustomerDTO { FirstName = "Taron", LastName = "Gevorgyan" },
        //         new CustomerDTO { FirstName = "Taron", LastName = "Gevorgyan" },
        //         new CustomerDTO { FirstName = "Taron", LastName = "Gevorgyan" }
        //     };
        //     
        //
        //     Mock<ICustomerRepository> mock = new Mock<ICustomerRepository>();
        //     Mock<IIdFactory> mock1 = new Mock<IIdFactory>();
        //    
        //     CustomerService customerService = new CustomerService(mock.Object, mock1.Object);
        //     int id = 1;
        //     mock1.Setup(x => x.Create()).Returns(() => id).Callback(()=>id++);
        //
        //     customerService.Create(list);
        //
        //     mock.Verify(x => x.Save(It.IsAny<Customer>()),Times.Exactly(3));
        //     mock1.Verify(x => x.Create(),Times.AtLeastOnce);
        // }
        // [TestMethod]
        // public void Create_BronzeCustomer_ShouldBeCallSaveMethod()
        // {
        //     Mock<ICustomerStatusFactory> cSFMock = new Mock<ICustomerStatusFactory>();
        //     Mock<ICustomerRepository> cRMock = new Mock<ICustomerRepository>();
        //     CustomerService customerService = new CustomerService(cRMock.Object,cSFMock.Object);
        //
        //     CustomerDTO customerDto = new CustomerDTO() 
        //     {
        //         FirstName = "Ivan",
        //        LastName = "Ivanov",
        //       StatusLevel = StatusLevel.Bronze
        //     };
        //     cSFMock.Setup(x => x.CreateFrom(It.Is<CustomerDTO>(x => x.StatusLevel.Equals(StatusLevel.Bronze))))
        //         .Returns(StatusLevel.Bronze);
        //     
        //     customerService.Create(customerDto);
        //     
        //     cRMock.Verify(x=>x.Save(It.IsAny<Customer>()));
        // }
        // [TestMethod]
        // public void Create_GoldCustomer_ShouldBeCallSaveExtendedMethod()
        // {
        //     Mock<ICustomerStatusFactory> cSFMock = new Mock<ICustomerStatusFactory>();
        //     Mock<ICustomerRepository> cRMock = new Mock<ICustomerRepository>();
        //     CustomerService customerService = new CustomerService(cRMock.Object,cSFMock.Object);
        //
        //     CustomerDTO customerDto = new CustomerDTO() 
        //     {
        //         FirstName = "Ivan",
        //         LastName = "Ivanov",
        //         StatusLevel = StatusLevel.Gold
        //     };
        //     cSFMock.Setup(x => x.CreateFrom(It.Is<CustomerDTO>(x => x.StatusLevel.Equals(StatusLevel.Gold))))
        //         .Returns(StatusLevel.Gold);
        //     
        //     customerService.Create(customerDto);
        //     
        //     cRMock.Verify(x=>x.SaveExtended(It.IsAny<Customer>()));
        // }
        [TestMethod]
        [ExpectedException(typeof(CustomerCreateException))]
        public void Create_Exception_ShouldBeThrow()
        {
            Mock<IAddressFactory> addressFactory = new Mock<IAddressFactory>();
            Mock<ICustomerRepository> cRMock = new Mock<ICustomerRepository>();
            CustomerService customerService = new CustomerService(cRMock.Object,addressFactory.Object);

            addressFactory.Setup(x => x.CreateFrom(It.IsAny<CustomerDTO>())).Throws<InvalidCustomerAddressException>();
    
            customerService.Create(new CustomerDTO());
        }
    }
}
 
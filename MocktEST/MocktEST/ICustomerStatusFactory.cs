using MocktEST;

namespace CunsomerServiceLibrary
{
    public interface ICustomerStatusFactory
    {
        StatusLevel CreateFrom(CustomerDTO customerDto);
    }
}
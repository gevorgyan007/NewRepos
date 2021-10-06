using MocktEST;

namespace CunsomerServiceLibrary
{
    public interface IAddressFactory
    {
      public  Address CreateFrom(CustomerDTO customerDto);
    }
}
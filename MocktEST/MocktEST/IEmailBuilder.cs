using MocktEST;
using System;
using System.Collections.Generic;
using System.Text;

namespace CunsomerServiceLibrary
{
   public interface IEmailBuilder
    {
        Address From(CustomerDTO customerDTO);
    }
}

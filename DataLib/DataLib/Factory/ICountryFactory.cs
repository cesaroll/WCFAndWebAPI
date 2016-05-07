using System.Collections.Generic;
using ModelLib.Query;

namespace DataLib.Factory
{
    public interface ICountryFactory
    {
        List<Country> GetAll();
    }
}
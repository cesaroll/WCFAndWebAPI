using System.Collections.Generic;
using ModelLib.Query;
using ModelLib.Util;

namespace DataLib.Factory
{
    public interface ICountryFactory
    {
        List<Country> GetAll();

        IReturnMsg Save(Country Country);

    }
}
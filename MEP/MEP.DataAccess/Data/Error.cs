using System;
using MEP.Models.Data;

namespace MEP.DataAccess.Data
{
    public class Error : IError
    {
        public int Id { get; set; }
        public IApp App { get; set; }
        public DateTime DateTime { get; set; }
        public string Message { get; set; }
    }
}
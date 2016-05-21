using System;

namespace MEP.Models.Data
{
    public interface IError
    {
        int Id { get; set; }
        IApp App { get; set; }
        DateTime DateTime { get; set; }
        string Message { get; set; }
    }
}
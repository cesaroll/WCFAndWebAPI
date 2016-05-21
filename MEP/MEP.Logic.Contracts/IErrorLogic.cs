using System;

namespace MEP.Logic.Contracts
{
    public interface IErrorLogic
    {
        void LogError(string msg);
        void LogError(Exception e);
    }
}
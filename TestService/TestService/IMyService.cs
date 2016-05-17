using System.Collections.Generic;
using System.ServiceModel;
using ModelLib.Query;
using ModelLib.Util;

namespace TestService
{
    //[ServiceContract(Name = "CountriesService")]
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        string GetData();

        [OperationContract]
        string GetMessage(string Name);

        [OperationContract]
        string GetResult(Student Student);

        [OperationContract]
        Student GetTopper(List<Student> Students);

        [OperationContract]
        int GetMax(int[] ar);

        [OperationContract]
        int[] GetSorted(int[] ar);

        [OperationContract(Name = "CountriesGetAll")]
        List<Country> CountriesGetAll();

        [OperationContract]
        ReturnMsg CountrySave(Country Country);

        #region Method Overloading
        /// <summary>
        /// Multiply Integer
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        [OperationContract(Name = "MultiplyInt")]
        int Multiply(int a, int b);

        /// <summary>
        /// Multiply Double
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        [OperationContract(Name = "MultiplyDouble")]
        double Multiply(double a, double b);

        #endregion

        #region FaultExceptions and FaultContracts
        [OperationContract]
        [FaultContract(typeof(DivFault))]
        int DivInt(int a, int b);

        #endregion
    }
}
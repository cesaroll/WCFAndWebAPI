using System.Collections.Generic;
using System.ServiceModel;
using ModelLib.Query;

namespace TestService
{
    [ServiceContract(Name = "CountriesService")]
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
    }
}
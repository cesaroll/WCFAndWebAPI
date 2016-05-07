using System.Collections.Generic;
using System.ServiceModel;
using L1_TestService.Entities;

namespace L1_TestService
{
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
    }
}
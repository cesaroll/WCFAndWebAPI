using System;
using System.Runtime.Serialization;

namespace WCF.HR.Service.Lib.Contracts
{
    [DataContract]
    public class EmployeeContract
    {
        [DataMember]
        public int EmployeeId { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public DateTime HireDate { get; set; }
        [DataMember]
        public string JobId { get; set; }
        [DataMember]
        public Nullable<decimal> Salary { get; set; }
        [DataMember]
        public Nullable<decimal> CommissionPct { get; set; }
        [DataMember]
        public Nullable<int> ManagerId { get; set; }
        [DataMember]
        public Nullable<short> DepartmentId { get; set; } 
    }
}
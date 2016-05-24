using System;
using System.Runtime.Serialization;

namespace WCF.HR.Service.Lib.Contracts
{
    [DataContract]
    public class EmployeeContract
    {
        [DataMember(Order = 1)]
        public int EmployeeId { get; set; }
        [DataMember(Order = 2)]
        public string FirstName { get; set; }
        [DataMember(Order = 3)]
        public string LastName { get; set; }
        [DataMember(Order = 4)]
        public string Email { get; set; }
        [DataMember(Order = 5)]
        public string PhoneNumber { get; set; }
        [DataMember(Order = 6)]
        public DateTime HireDate { get; set; }
        [DataMember(Order = 7)]
        public string JobId { get; set; }
        [DataMember(Order = 8)]
        public Nullable<decimal> Salary { get; set; }
        [DataMember(Order = 9)]
        public Nullable<decimal> CommissionPct { get; set; }
        [DataMember(Order = 10)]
        public Nullable<int> ManagerId { get; set; }
        [DataMember(Order = 11)]
        public Nullable<short> DepartmentId { get; set; } 
    }
}
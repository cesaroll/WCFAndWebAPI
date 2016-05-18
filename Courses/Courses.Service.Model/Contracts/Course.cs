using System.Runtime.Serialization;

namespace Courses.Service.Model.Contracts
{
    [DataContract]
    public class Course
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public decimal Price { get; set; }
         
    }
}
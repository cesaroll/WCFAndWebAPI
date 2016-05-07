using System.Runtime.Serialization;

namespace ModelLib.Query
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int[] Grades { get; set; }
    }
}
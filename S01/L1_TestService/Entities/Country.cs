using System.Runtime.Serialization;

namespace L1_TestService.Entities
{
    [DataContract]
    public class Country
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }
         
    }
}
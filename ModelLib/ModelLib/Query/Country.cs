using System.Runtime.Serialization;

namespace ModelLib.Query
{
    [DataContract]
    public class Country
    {
        [DataMember(IsRequired = true)]
        public int Id { get; set; }

        [DataMember(IsRequired = true)]
        public string Name { get; set; } 
    }
}
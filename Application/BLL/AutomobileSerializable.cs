using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BLL
{
    [DataContract]
    public class AutomobileSerializable
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string model { get; set; }
        [DataMember]
        public int enginePower { get; set; }
        [DataMember]
        public int maxSpeed { get; set; }
        [DataMember]
        public decimal acceleration { get; set; }
        [DataMember]
        public decimal fuelEconomy { get; set; }
        [DataMember]
        public decimal price { get; set; }
        [DataMember]
        public int vendorId { get; set; }
    }
}

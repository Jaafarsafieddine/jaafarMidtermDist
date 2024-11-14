using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab2
{
    public class branchAdress
    {
        [XmlAttribute("number")]
        public int number { get; set; }
        public String streetName { get; set; }
        public String city { get; set; }
    }
}

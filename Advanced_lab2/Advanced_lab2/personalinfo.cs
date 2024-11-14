using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Advanced_lab2
{
    public class personalinfo
    {
        [XmlAttribute("number")]
        public int number;
        public String streetName {  get; set; }
        public String city {  get; set; }

    }
}

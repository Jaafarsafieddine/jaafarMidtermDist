using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Advanced_lab2
{
    
    public class Student
    {
        [XmlAttribute("StudentId")]
        public int StudentId { get; set; }
        public String firstname { get; set; }
        public String lastname { get; set; }

        public personalinfo personalAddress { get; set; }
        public faculty faculty { get; set; }
        public branch branch { get; set; }

    }
}

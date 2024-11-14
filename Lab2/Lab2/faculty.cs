using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab2
{
    public class faculty
    {
        [XmlAttribute("facultyId")]
        public int FacultyId { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
}

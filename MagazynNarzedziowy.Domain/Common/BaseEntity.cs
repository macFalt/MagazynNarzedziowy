using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace MagazynNarzedziowy.Domain.Common
{
    public class BaseEntity 
    {
        [XmlAttribute("Id")]
        public int Id { get; set; }
    }
}

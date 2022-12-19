using MagazynNarzedziowy.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace MagazynNarzedziowy.Domain.Entity
{


    public class Tools : BaseEntity
    {
        [XmlElement("Name")]
        public string Name{ get; set; }
        [XmlElement("TypeId")]
        public int TypeId { get; set; }

        public Tools()
        {
            
        }
        public Tools(int id,string name, int typeId)
        {
            Name = name;
            TypeId = typeId;
            Id = id;
        }
    }
}

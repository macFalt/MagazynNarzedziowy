using MagazynNarzedziowy.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagazynNarzedziowy.Domain.Entity
{


    public class Tools : BaseEntity
    {
        public string Name{ get; set; }
        public int TypeId { get; set; }

        public Tools()
        {
            ;
        }
        public Tools(int id,string name, int typeId)
        {
            Name = name;
            TypeId = typeId;
            Id = id;
        }
    }
}

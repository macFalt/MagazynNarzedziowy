using MagazynNarzedziowy.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagazynNarzedziowy.Domain.Entity
{
    public class MenuAction : BaseEntity
    {

        public string Name { get; set; }
        public string MenuName { get; set; }

        public MenuAction(int id, string name , string menuName)
        {
            Id = id;
            Name = name;
            MenuName = menuName;

        }
    }
}

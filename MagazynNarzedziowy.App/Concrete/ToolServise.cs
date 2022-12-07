using MagazynNarzedziowy.App.Common;
using System;
using System.Collections.Generic;
using System.Text;
using MagazynNarzedziowy.Domain.Entity;

namespace MagazynNarzedziowy.App.Concrete
{
    public class ToolService : BaseService<Tools>
    {
 


        public void AddNewTools(Tools tool)
        {
 
            AddObject(tool);

        }


        public void RemoveItem(int id)
        {
            var tool = GetObjectById(id);
            RemoveObject(tool);

        }




    }
}

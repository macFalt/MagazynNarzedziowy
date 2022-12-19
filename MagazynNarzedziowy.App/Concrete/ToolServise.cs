using MagazynNarzedziowy.App.Common;
using System;
using System.Collections.Generic;
using System.Text;
using MagazynNarzedziowy.Domain.Entity;
using System.Linq;
using Newtonsoft.Json;
using System.IO;

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

        //public IEnumerable<Tools> Seed()
        //{
        //    List<Tools> tools = new List<Tools>();
        //    for (int i=0;i<500;i++)
        //    {
        //        Tools tool = new Tools()
        //        {
        //            Id = i,
        //            Name = i.ToString(),
        //            TypeId = i * 12
        //        };
        //        tools.Add(tool);
        //    return tools;
        //}

        //    }
        //public IQueryable<Tools> GetAllToolsQueryable()
        //{
        //    IQueryable<Tools> tools = Seed().AsQueryable();
        //    return tools;
        //}

        //public IEnumerable<Tools> GetAllToolsEnumerable()
        //{
        //    IEnumerable<Tools> tools = Seed();
        //    return tools;
        //}


    }
}

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
 
        public void UpdateFile()
        {
            string output = JsonConvert.SerializeObject(Objects);
            using StreamWriter sw = new StreamWriter(@"/Users/maciejfaltynski/Documents/Visual Studio/Magazyn narzedziowy/proba.json");
            using JsonWriter writer = new JsonTextWriter(sw);
            JsonSerializer serializer = new JsonSerializer();
            serializer.Serialize(writer, output);
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

using MagazynNarzedziowy.App.Abstract;
using MagazynNarzedziowy.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagazynNarzedziowy.App.Common
{
    public class BaseService<T> : IService<T> where T : BaseEntity
    {

        public List<T> Tools { get; set ; }

        public BaseService()
        {
            Tools = new List<T>();
        }

        public int GetLastId()
        {
            int lastId;
            if(Tools.Any())
            {
                lastId = Tools.OrderBy(p => p.Id).LastOrDefault().Id;

            }
            else
            {
                lastId = 0;
            }
            return lastId;
        }


        public int AddTools(T tool)
        {
            Tools.Add(tool);
            return tool.Id;

        }

        public List<T> GetAllTools()
        {
            return Tools;
        }

        public void RemoveTool(T tool)
        {
            Tools.Remove(tool);
        }

        public int UpdateTool(T tool)
        {
            var entity = Tools.FirstOrDefault(p => p.Id == tool.Id); 
            if(entity!=null)
            {
                entity = tool;
            }
            return entity.Id;
        }

        public T GetItemById(int id)
        {
            var entity = Tools.FirstOrDefault(p => p.Id == id);
            return entity;
        }
    }
}

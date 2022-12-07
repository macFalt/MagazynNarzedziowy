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

        public List<T> Objects { get; set ; }

        public BaseService()
        {
            Objects = new List<T>();
        }

        public int GetLastId()
        {
            int lastId;
            if(Objects.Any())
            {
                lastId = Objects.OrderBy(p => p.Id).LastOrDefault().Id;

            }
            else
            {
                lastId = 0;
            }
            return lastId;
        }


        public int AddObject(T objects)
        {
            Objects.Add(objects);
            return objects.Id;

        }

        public List<T> GetAllObjects()
        {
            return Objects;
        }

        public void RemoveObject(T objects)
        {
            Objects.Remove(objects);
        }

        public int UpdateObject(T objects)
        {
            var entity = Objects.FirstOrDefault(p => p.Id == objects.Id); 
            if(entity!=null)
            {
                entity = objects;
            }
            return entity.Id;
        }

        public T GetObjectById(int id)
        {
            var entity = Objects.FirstOrDefault(p => p.Id == id);
            return entity;
        }
    }
}

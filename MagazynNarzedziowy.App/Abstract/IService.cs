using System;
using System.Collections.Generic;
using System.Text;

namespace MagazynNarzedziowy.App.Abstract
{
    public interface IService<T>
    {
        List<T> Objects { get; set; }

        List<T> GetAllObjects();

        int AddObject(T objects);

        int UpdateObject(T objects);

        void RemoveObject(T objects);

        public T GetObjectById(int id);

        int GetLastId();

        void AddObjectsToFile();

       // void xxx();
    }
}

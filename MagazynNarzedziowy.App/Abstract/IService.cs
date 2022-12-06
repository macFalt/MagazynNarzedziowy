using System;
using System.Collections.Generic;
using System.Text;

namespace MagazynNarzedziowy.App.Abstract
{
    public interface IService<T>
    {
        List<T> Tools { get; set; }

        List<T> GetAllObject();

        int AddObject(T tool);

        int UpdateObject(T tool);

        void RemoveObject(T tool);


    }
}

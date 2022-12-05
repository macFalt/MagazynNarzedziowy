using System;
using System.Collections.Generic;
using System.Text;

namespace MagazynNarzedziowy.App.Abstract
{
    public interface IService<T>
    {
        List<T> Tools { get; set; }

        List<T> GetAllTools();

        int AddTools(T tool);

        int UpdateTool(T tool);

        void RemoveTool(T tool);


    }
}

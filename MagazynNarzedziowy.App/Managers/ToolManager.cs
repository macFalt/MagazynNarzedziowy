using MagazynNarzedziowy.App.Common;
using MagazynNarzedziowy.App.Concrete;
using MagazynNarzedziowy.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagazynNarzedziowy.App.Managers
{
    public class ToolManager : BaseService<Tools>
    {
        private readonly MenuActionServise _actionService;
        private ToolServise _toolServise;
        private MenuActionServise actionService;

        public ToolManager(MenuActionServise actionService)
        {
            _toolServise = new ToolServise();
            _actionService = actionService;
        }



        public int AddNewTool()
        {
            var addNewToolMenu = _actionService.ShowMenu("RodzajNarzedzi");
            Console.WriteLine("Wybierz typ");

            for (int i = 0; i < addNewToolMenu.Count; i++)
            {
                Console.WriteLine($"{addNewToolMenu[i].Id}.{addNewToolMenu[i].Name}");
            }

            var operation = Console.ReadKey();
            int typeId;
            Int32.TryParse(operation.KeyChar.ToString(), out typeId);
            Console.WriteLine("Podaj nazwe narzedzia");
            var name = Console.ReadLine();
            var lastId = _toolServise.GetLastId();
            Tools tool = new Tools(lastId + 1, name, typeId); ;
            _toolServise.AddTools(tool);

            return tool.Id;
        }



        //public int RemoveItem()
        //{

        //    Console.WriteLine("Podaj Id narzedzia do usuniecia");
        //    var id = Convert.ToInt32(Console.ReadLine());
        //    if (id != null)
        //    {
        //        _toolServise.Remove(id);
        //    }



        //}


        //public int ShowDetailsView()
        //{

        //}


        //public void ShowDetails(int showId)
        //{




        //}
    }
}

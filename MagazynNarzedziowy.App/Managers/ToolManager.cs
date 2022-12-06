using MagazynNarzedziowy.App.Common;
using MagazynNarzedziowy.App.Concrete;
using MagazynNarzedziowy.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagazynNarzedziowy.App.Managers
{
    //public class ToolManager : BaseService<Tools>
    public class ToolManager : ToolService
    {

        //private readonly MenuActionServise _actionService;
        private ToolService _toolService;
        private MenuActionServise _actionService;

        public ToolManager()
        {

        }

        public ToolManager(MenuActionServise actionService)
        {
            _toolService = new ToolService();
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
            Console.WriteLine("");
            int typeId;


            Int32.TryParse(operation.KeyChar.ToString(), out typeId);
            Console.WriteLine("Podaj nazwe narzedzia");
            var name = Console.ReadLine();
            int toolTypeId;
            Int32.TryParse(typeId.ToString(), out toolTypeId);
            Console.WriteLine("Podaj id nowego narzedzia:");
            var id = Console.ReadLine();
            int toolId;
            Int32.TryParse(id, out toolId);
            Tools tool = new Tools(toolId, name, toolTypeId); 
            _toolService.AddNewTools(tool);
            return tool.Id;
        }


        public int RemoveTool()
        {

            Console.WriteLine("Podaj Id narzedzia do usuniecia");
            var id = Convert.ToInt32(Console.ReadLine());
            _toolService.RemoveItem(id);
            return id;
            
        }

        //public void ShowToolList()
        //{ 
        //    _toolService.GetAllObject();
        //}


        public List<Tools> ShowToolList()
        {

           return _toolService.GetAllObject();
        }



        //}


        //public int ShowDetailsView()
        //{

        //}


        //public void ShowDetails(int showId)
        //{


        //private readonly MenuActionServise _actionService;
        //private ToolServise _toolServise;
        //private MenuActionServise actionService;

        //public ToolManager(MenuActionServise actionService)
        //{
        //    _toolServise = new ToolServise();
        //    _actionService = actionService;
        //}






        //public int AddNewTool()
        //{
        //    var addNewToolMenu = _actionService.ShowMenu("RodzajNarzedzi");
        //    Console.WriteLine("Wybierz typ");

        //    for (int i = 0; i < addNewToolMenu.Count; i++)
        //    {
        //        Console.WriteLine($"{addNewToolMenu[i].Id}.{addNewToolMenu[i].Name}");
        //    }

        //    var operation = Console.ReadKey();
        //    int typeId;
        //    Int32.TryParse(operation.KeyChar.ToString(), out typeId);
        //    Console.WriteLine("Podaj nazwe narzedzia");
        //    var name = Console.ReadLine();
        //    var lastId = _toolServise.GetLastId();
        //    Tools tool = new Tools(lastId + 1, name, typeId); ;
        //    _toolServise.AddObject(tool);

        //    return tool.Id;
        //}


        //}

    }
}

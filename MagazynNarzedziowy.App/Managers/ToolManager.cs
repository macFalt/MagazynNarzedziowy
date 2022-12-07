using MagazynNarzedziowy.App.Common;
using MagazynNarzedziowy.App.Concrete;
using MagazynNarzedziowy.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagazynNarzedziowy.App.Managers
{

    public class ToolManager : ToolService
    {
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
            int toolId=_toolService.GetLastId();
            Tools tool = new Tools(toolId+1, name, typeId); 
            _toolService.AddNewTools(tool);
            return tool.Id;
        }


        public int RemoveTool()
        {

            Console.WriteLine("Podaj Id narzedzia do usuniecia");
            var toolList = _toolService.GetAllObjects();
            for (int i = 0; i < toolList.Count; i++)
            Console.WriteLine($"{toolList[i].Id}.{toolList[i].Name}");
            var id = Convert.ToInt32(Console.ReadLine());
            _toolService.RemoveItem(id);
            return id;
            
        }


        public List<Tools> ShowToolList()
        {
            return _toolService.GetAllObjects();
        }


        public Tools ShowToolDetail()
        {

            Console.WriteLine("Podaj Id narzedzia do wyswietlenia szczegółów:");
            var id = Convert.ToInt32(Console.ReadLine());
            var toolDetail = _toolService.GetAllObjects();
            for (int i = 0; i < toolDetail.Count; i++)
                Console.WriteLine($"{toolDetail[i].Id}.{toolDetail[i].Name}");
            //_toolService.GetObjectById(id);
            return _toolService.GetObjectById(id);



        }




    }
}

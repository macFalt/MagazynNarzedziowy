using MagazynNarzedziowy.App.Abstract;
using MagazynNarzedziowy.App.Common;
using MagazynNarzedziowy.App.Concrete;
using MagazynNarzedziowy.Domain.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MagazynNarzedziowy.App.Managers
{

    public class ToolManager 
    {

        //private IService<Tools> _toolService;
        private ToolService _toolService;
        private MenuActionServise _actionService;

        public ToolManager(MenuActionServise actionService,ToolService toolService)
        {

            _toolService = toolService;
            _actionService = actionService;
        }


        public void AddNewTool()
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
            _toolService.AddObject(tool);
            _toolService.UpdateFile();
            
        }

        public int UpdateToolList()
        {

            if (new FileInfo(@"/Users/maciejfaltynski/Documents/Visual Studio/Magazyn narzedziowy/proba.json").Length == 0)
            {
                return 0;
            }
            else
            {
                using StreamReader streamReader = new StreamReader(@"/Users/maciejfaltynski/Documents/Visual Studio/Magazyn narzedziowy/proba.json");
                string output = streamReader.ReadToEnd();
                string output2 = output.Substring(1, (output.Length - 2));
                string output3 = output2.Replace("\\", "");
                var tools = JsonConvert.DeserializeObject<List<Tools>>(output3);

                foreach (var x in tools)
                {
                    _toolService.AddObject(x);
                }

            }
            return 1;
        }


        public void RemoveTool()
        {

            Console.WriteLine("Podaj Id narzedzia do usuniecia");
            ShowToolList();
            var id = Convert.ToInt32(Console.ReadLine());
            var toolId =_toolService.GetObjectById(id);
            _toolService.RemoveObject(toolId);
            _toolService.UpdateFile();
          
            
        }


        public void ShowToolList()
        {
            var tools = _toolService.GetAllObjects();
            for (int i = 0; i < tools.Count; i++)
            {
                Console.WriteLine($"Tool id:{tools[i].Id}");
                Console.WriteLine($"Tool name:{tools[i].Name}");
                Console.WriteLine("");

            }
        }

        public void ShowToolDetail()
        {
            Console.WriteLine("Podaj Id narzedzia do wyswietlenia szczegółów:");
            var toolDetail = _toolService.GetAllObjects();
            for (int i = 0; i < toolDetail.Count; i++)
                Console.WriteLine($"{toolDetail[i].Id}.{toolDetail[i].Name}");
            var idTool = Convert.ToInt32(Console.ReadLine());
            var tool= _toolService.GetObjectById(idTool);
            Console.WriteLine($"Tool id:{tool.Id}");
            Console.WriteLine($"Tool name:{tool.Name}");
            Console.WriteLine($"Tool type:{tool.TypeId}");
        }





        //METODY DO LEKCJI O TESTACH
        //public Tools ShowDetail(int id)
        //{
        //    var tool = _toolService.GetObjectById(id); //metoda do utworzona do testu moq
        //    return tool;
        //}

        //public void RemoveToolById(int id)
        //{
        //    var tool = _toolService.GetObjectById(id);
        //    _toolService.RemoveObject(tool);
        //}
    }
}

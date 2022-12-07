using MagazynNarzedziowy.App.Abstract;
using MagazynNarzedziowy.App.Concrete;
using MagazynNarzedziowy.App.Managers;
using MagazynNarzedziowy.Domain.Entity;
using System;
using System.Collections.Generic;

namespace Magazyn_narzedziowy
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuActionServise actionService = new MenuActionServise();
            ToolManager toolManager = new ToolManager(actionService); 


            Console.WriteLine("Witaj w bazie narzedzi");
            while (true)
            {
                Console.WriteLine("Wybierz co chcesz zrobić:");
                var mainMenu = actionService.ShowMenu("Main");
                for (int i = 0; i < mainMenu.Count; i++)
                    Console.WriteLine($"{mainMenu[i].Id}.{mainMenu[i].Name}");

                var operation = Console.ReadKey();
                Console.WriteLine("");

                switch (operation.KeyChar)
                {
                    case '1':
                        var newId = toolManager.AddNewTool();
                        break;

                    case '2':
                        var removeId = toolManager.RemoveTool();
                        break;

                    case '3':
                        //Tools tool = new Tools();
                        //tool = toolManager.ShowToolDetail();

                        var tool=toolManager.ShowToolDetail();
                        Console.WriteLine($"Tool id:{tool.Id}");
                        Console.WriteLine($"Tool name:{tool.Name}");
                        Console.WriteLine($"Tool type:{tool.TypeId}");

                        break;

                    case '4':
                        List<Tools> xxx = new List<Tools>();
                        xxx = toolManager.ShowToolList();
                        for (int i = 0; i < xxx.Count; i++)
                            Console.WriteLine($"{xxx[i].Id}.{xxx[i].Name}");

                        break;


                    default:
                        Console.WriteLine("Wybrana akcja nie istnieje");
                        break;

                }


            }
        }
       


    }

}

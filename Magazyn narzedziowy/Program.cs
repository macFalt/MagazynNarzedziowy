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
            ToolService toolService = new ToolService();
            ToolManager toolManager = new ToolManager(actionService,toolService); 


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
                        toolManager.AddNewTool();
                        break;

                    case '2':
                        toolManager.RemoveTool();
                        break;

                    case '3':
                        toolManager.ShowToolDetail();
                        break;

                    case '4':
                  
                        toolManager.ShowToolList();
                      
                        break;


                    default:
                        Console.WriteLine("Wybrana akcja nie istnieje");
                        break;

                }


            }
        }
       


    }

}

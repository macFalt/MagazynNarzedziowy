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

                switch (operation.KeyChar)
                {
                    case '1':
                        var newId = toolManager.AddNewTool();
                        break;

                    //case '2':
                    //    var removeId = toolManager.RemoveItemView();
                    //    toolManager.RemoveItem(removeId);

                    //    break;

                    //case '3':
                    //    var showDetails = toolManager.ShowDetailsView();
                    //    toolManager.ShowDetails(showDetails);
                    //    break;

                    //case '4':
                    //    toolService.showAllToolsView();
                    //    break;


                    default:
                        Console.WriteLine("Wybrana akcja nie istnieje");
                        break;

                }


            }
        }
       


    }

}

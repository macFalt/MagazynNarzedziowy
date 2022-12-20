using MagazynNarzedziowy.App.Abstract;
using MagazynNarzedziowy.App.Common;
using MagazynNarzedziowy.App.Concrete;
using MagazynNarzedziowy.App.Managers;
using MagazynNarzedziowy.Domain.Entity;
using System;
using System.Collections.Generic;
using System.IO;

namespace Magazyn_narzedziowy
{
    class Program
    { 
        static void Main(string[] args)
        {
            FileInfo fileInfo = new FileInfo(@"/Users/maciejfaltynski/Documents/Visual Studio/Magazyn narzedziowy/proba.json");

            if(!fileInfo.Exists)
            {
                using (FileStream fs = File.Create(@"/Users/maciejfaltynski/Documents/Visual Studio/Magazyn narzedziowy/proba.json"));
            }
        
            bool x = true;
            MenuActionServise actionService = new MenuActionServise();
            ToolService toolService = new ToolService();
            FileService fileService = new FileService();
            ToolManager toolManager = new ToolManager(actionService,toolService,fileService);
            
            toolManager.UpdateToolList();

            Console.WriteLine("Witaj w bazie narzedzi");
            while (x)
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
                    case '5':
                        Console.WriteLine("Czy chcesz wyjsc z programu?");
                        Console.WriteLine("T/N");
                        var value = Console.ReadLine();
                        char xxx = Convert.ToChar(value);
                        if (xxx == 'T' || xxx=='t')
                        {

                            x = false;
                        }
                        else
                            continue;
                        
                        break;


                    default:
                        Console.WriteLine("Wybrana akcja nie istnieje");
                        break;

                }


            }
        }
       


    }

}

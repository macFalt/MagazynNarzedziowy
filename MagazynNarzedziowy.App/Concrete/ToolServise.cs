using MagazynNarzedziowy.App.Common;
using System;
using System.Collections.Generic;
using System.Text;
using MagazynNarzedziowy.Domain.Entity;

namespace MagazynNarzedziowy.App.Concrete
{
    public class ToolServise : BaseService<Tools>
    {

        //public ConsoleKeyInfo AddNewToolView(MenuActionServise actionServise)
        //{
        //    var addNewToolMenu = actionServise.ShowMenu("RodzajNarzedzi");
        //    Console.WriteLine("Wybierz typ");

        //    for (int i = 0; i < addNewToolMenu.Count; i++)
        //    {
        //        Console.WriteLine($"{addNewToolMenu[i].Id}.{addNewToolMenu[i].Name}");
        //    }

        //    var operation = Console.ReadKey();
        //    return operation;
        //}


        //public int ShowDetailsView()
        //{
        //    Console.WriteLine("Podaj id narzedzia do wgladu");
        //    var id = Console.ReadLine();
        //    int toolId;
        //    Int32.TryParse(id, out toolId);
        //    return (toolId);
        //}

        //public void ShowDetails(int showId)
        //{
        //    Tools idToolToShow = new Tools();
        //    foreach (var item in Tool)
        //    {
        //        if (item.Id == showId)
        //        {
        //            idToolToShow = item;
        //            break;
        //        }
        //    }

        //    Console.WriteLine($"Item id: {idToolToShow.Id}");
        //    Console.WriteLine($"Item name: {idToolToShow.Name}");
        //    Console.WriteLine($"Item type id: {idToolToShow.TypeId}");

        //}

        //public void showAllToolsView()
        //{
        //    Tools ToolShow = new Tools();

        //    foreach (var tool in Tool)
        //    {
        //        Console.WriteLine($"Item id: {tool.Id}");
        //        Console.WriteLine($"Item name: {tool.Name}");
        //        Console.WriteLine($"Item type id: {tool.TypeId}");
        //        Console.WriteLine(  "   "    );


        //    }

        //}















    }
}

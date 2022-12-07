using MagazynNarzedziowy.App.Common;
using MagazynNarzedziowy.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagazynNarzedziowy.App.Concrete
{
    public class MenuActionServise : BaseService<MenuAction>
    {
        public MenuActionServise() 
        {
            Initialize();
        }

        public List<MenuAction> ShowMenu(string menuName)
        {
            List<MenuAction> result = new List<MenuAction>();
            foreach (var menuAction in Objects)
            {
                if(menuAction.MenuName==menuName)
                {
                    result.Add(menuAction);
                }
            }
            return result;


        }


        private  void Initialize()
        {
            AddObject(new MenuAction(1, "Dodaj narzedzie", "Main"));
            AddObject(new MenuAction(2, "Usuń narzedzie", "Main"));
            AddObject(new MenuAction(3, "Pokaż szczegóły po id", "Main"));
            AddObject(new MenuAction(4, "Lista narzedzi", "Main"));

            AddObject(new MenuAction(1, "Wiertła", "RodzajNarzedzi"));
            AddObject(new MenuAction(2, "Frezy", "RodzajNarzedzi"));
            AddObject(new MenuAction(3, "Głowice", "RodzajNarzedzi"));

     

        }


    }
}

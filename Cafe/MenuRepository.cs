using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    class MenuRepository : MenuItem
    {

        protected readonly List<MenuItem> _menu = new List<MenuItem>();


        public bool AddToMenu(MenuItem menuItem)
        {
            int menuLength = _menu.Count();
            _menu.Add(menuItem);
            bool wasAdded = menuLength + 1 == _menu.Count();
            return wasAdded;

        }
        public List<MenuItem> DisplayMenu()
        {
            return _menu;
        }


        public MenuItem GetItemByName(string mealName)
        {
            foreach (MenuItem menuItem in _menu)
            {
                if (menuItem.MealName.ToLower() == mealName.ToLower())
                {
                    return menuItem;
                }
            }
            return null;
        }


        public MenuItem GetItemByNumber(int mealNumber)
        {
            foreach (MenuItem menuItem in _menu)
            {
                if (menuItem.MealNumber == mealNumber)
                {
                    return menuItem;
                }
            }
            return null;
        }


        public bool DeleteMenuItem(string mealName)
        {
            MenuItem menuItem = GetItemByName(mealName);
            bool deletedItem = _menu.Remove(menuItem);
            return deletedItem;
        }
        
    }
}



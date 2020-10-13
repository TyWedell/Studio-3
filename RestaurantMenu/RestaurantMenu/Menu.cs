using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    class Menu
    {
        private DateTime lastChanged;
        private List<MenuItem> AllMenutItems = new List<MenuItem>();
        private List<MenuItem> appetizers = new List<MenuItem>();
        private List<MenuItem> mainCourses = new List<MenuItem>();
        private List<MenuItem> desserts = new List<MenuItem>();

        public List<MenuItem> AllMenuItems { get; set; }

        private void SortMenuItems (List<MenuItem> menuItems)
        {
            foreach (MenuItem menuItem in menuItems)
            {
                if( menuItem.Category == "appetizer")
                {
                    appetizers.Add(menuItem);
                }
                else if ( menuItem.Category == "mainCourse")
                {
                    mainCourses.Add(menuItem);
                }
                else if ( menuItem.Category == "dessert")
                {
                    desserts.Add(menuItem);
                }
            }
        }

    }
}

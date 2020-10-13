using System;


namespace RestaurantMenu
{
    class MenuItem
    {
        private string category;
        private string description;
        private float price;
        private bool isNew;

        public string Category { get { return category; } }
        public string Description { get { return description; } }
        public float Price { get { return price; } }
        public bool IsNew { get { return isNew; } }

        public MenuItem (float price, string description, string category, bool isNew = true)
        {
            this.price = price;
            this.description = description;
            this.category = category;
            this.isNew = isNew;
        }
    }
}

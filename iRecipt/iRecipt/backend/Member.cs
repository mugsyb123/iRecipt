using System;
using System.Collections.Generic;
namespace iRecipt.backend
{
    class Member
    {
        public String name;
        private List<Item> items;

        public Member(String name)
        {
            setName(name);
        }

        private void setName(String name)
        {
            this.name = name;
        }

        /**
        * Returns true if the item could be added,
        * false if it already exists and could not
        * be added.
        */
        public bool addItem(Item item)
        {
            if (items.Contains(item) ){
                return false;
            }
            else
            {
                items.Add(item);
                return true;
            }
        }

        public String getName()
        {
            return name;
        }

        public List<Item> getItems()
        {
            return items;
        }
    }
}

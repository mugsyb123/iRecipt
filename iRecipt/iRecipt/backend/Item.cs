using System;

namespace iRecipt.backend
{
    class Item
    {
        private double price;

        private String name;
        
        private String referenceId;

        public Item(double price, String name, String referenceId)
        {
            setPrice(price);
            setName(name);
            setReferenceId(referenceId);
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setReferenceId(String referenceId)
        {
            this.referenceId = referenceId;
        }

        public String getName()
        {
            return this.name;
        }

        public String getReferenceId() 
        {
            return this.referenceId;
        }
        
        public double getPrice()
        {
            return this.price;
        }
    }
}

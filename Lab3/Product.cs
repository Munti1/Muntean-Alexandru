using System;

namespace InventoryManagementSystem 
{
    public class Product : Item
    {
        private int quantity;
        private decimal price;
        private Category category;
        private Supplier supplier;

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Quantity cannot be negative.");
                quantity = value;
            }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Price cannot be negative.");
                price = value;
            }
        }

        public Category Category
        {
            get { return category; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Category cannot be null.");
                category = value;
            }
        }

        public Supplier Supplier
        {
            get { return supplier; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Supplier cannot be null.");
                supplier = value;
            }
        }

        public Product(int itemId, string itemName, int quantity, decimal price, Category category, Supplier supplier) 
            : base(itemId, itemName)
        {
            Quantity = quantity;
            Price = price;
            Category = category;
            Supplier = supplier;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Quantity: {Quantity}, Price: {Price:C}, Category: {Category.CategoryName}, Supplier: {Supplier.SupplierName}";
        }
    }
}

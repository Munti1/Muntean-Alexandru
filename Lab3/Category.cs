using System;

namespace InventoryManagementSystem
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public Category(int categoryId, string categoryName)
        {
            this.CategoryId = categoryId; 
            this.CategoryName = categoryName;
        }

        public override string ToString()
        {
            return $"Category ID: {CategoryId}, Name: {CategoryName}";
        }
    }
}
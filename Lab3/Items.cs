using System;

namespace InventoryManagementSystem
{
    public class Item
    {
        private int itemId;
        private string itemName; 

        public int ItemId
        {
            get { return itemId; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Item ID must be greater than 0");
                itemId = value;
            }
        }

        public string ItemName
        {
            get { return itemName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Item name cannot be null or empty");
                itemName = value;
            }
        }

        public Item(int itemId, string itemName)
        {
            ItemId = itemId;
            ItemName = itemName;
        }

        public override string ToString()
        {
            return $"Item ID: {ItemId}, Name: {ItemName}";
        }
    }
}

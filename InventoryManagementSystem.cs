using System;

class Item
{
    public string ItemName;
    public int ItemID;
    public int Quantity;
    public double Price;
    public Item Next;
}

class InventoryManagementSystem
{
    Item head;

    public void AddAtBeginning(string itemName, int itemID, int quantity, double price)
    {
        Item newItem = new Item
        {
            ItemName = itemName,
            ItemID = itemID,
            Quantity = quantity,
            Price = price,
            Next = head
        };
        head = newItem;
    }

    public void AddAtEnd(string itemName, int itemID, int quantity, double price)
    {
        Item newItem = new Item
        {
            ItemName = itemName,
            ItemID = itemID,
            Quantity = quantity,
            Price = price
        };

        if (head == null)
        {
            head = newItem;
        }
        else
        {
            Item temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newItem;
        }
    }

    public void AddAtPosition(string itemName, int itemID, int quantity, double price, int position)
    {
        Item newItem = new Item
        {
            ItemName = itemName,
            ItemID = itemID,
            Quantity = quantity,
            Price = price
        };

        if (position == 0)
        {
            AddAtBeginning(itemName, itemID, quantity, price);
            return;
        }

        Item temp = head;
        for (int i = 0; i < position - 1 && temp != null; i++)
        {
            temp = temp.Next;
        }

        if (temp != null)
        {
            newItem.Next = temp.Next;
            temp.Next = newItem;
        }
    }

    public void RemoveByItemID(int itemID)
    {
        if (head == null) return;

        if (head.ItemID == itemID)
        {
            head = head.Next;
            return;
        }

        Item temp = head;
        while (temp.Next != null && temp.Next.ItemID != itemID)
        {
            temp = temp.Next;
        }

        if (temp.Next != null)
        {
            temp.Next = temp.Next.Next;
        }
    }

    public void UpdateQuantityByItemID(int itemID, int newQuantity)
    {
        Item temp = head;
        while (temp != null)
        {
            if (temp.ItemID == itemID)
            {
                temp.Quantity = newQuantity;
                return;
            }
            temp = temp.Next;
        }
    }

    public Item SearchByItemID(int itemID)
    {
        Item temp = head;
        while (temp != null)
        {
            if (temp.ItemID == itemID)
            {
                return temp;
            }
            temp = temp.Next;
        }
        return null;
    }

    public Item SearchByItemName(string itemName)
    {
        Item temp = head;
        while (temp != null)
        {
            if (temp.ItemName == itemName)
            {
                return temp;
            }
            temp = temp.Next;
        }
        return null;
    }

    public double CalculateTotalValue()
    {
        double totalValue = 0;
        Item temp = head;
        while (temp != null)
        {
            totalValue += temp.Price * temp.Quantity;
            temp = temp.Next;
        }
        return totalValue;
    }

    public void SortInventoryByName(bool ascending)
    {
        if (head == null) return;

        for (Item temp1 = head; temp1 != null; temp1 = temp1.Next)
        {
            for (Item temp2 = temp1.Next; temp2 != null; temp2 = temp2.Next)
            {
                if ((ascending && temp1.ItemName.CompareTo(temp2.ItemName) > 0) || (!ascending && temp1.ItemName.CompareTo(temp2.ItemName) < 0))
                {
                    string tempName = temp1.ItemName;
                    int tempID = temp1.ItemID;
                    int tempQuantity = temp1.Quantity;
                    double tempPrice = temp1.Price;

                    temp1.ItemName = temp2.ItemName;
                    temp1.ItemID = temp2.ItemID;
                    temp1.Quantity = temp2.Quantity;
                    temp1.Price = temp2.Price;

                    temp2.ItemName = tempName;
                    temp2.ItemID = tempID;
                    temp2.Quantity = tempQuantity;
                    temp2.Price = tempPrice;
                }
            }
        }
    }

    public void SortInventoryByPrice(bool ascending)
    {
        if (head == null) return;

        for (Item temp1 = head; temp1 != null; temp1 = temp1.Next)
        {
            for (Item temp2 = temp1.Next; temp2 != null; temp2 = temp2.Next)
            {
                if ((ascending && temp1.Price > temp2.Price) || (!ascending && temp1.Price < temp2.Price))
                {
					
                    string tempName = temp1.ItemName;
                    int tempID = temp1.ItemID;
                    int tempQuantity = temp1.Quantity;
                    double tempPrice = temp1.Price;

                    temp1.ItemName = temp2.ItemName;
                    temp1.ItemID = temp2.ItemID;
                    temp1.Quantity = temp2.Quantity;
                    temp1.Price = temp2.Price;

                    temp2.ItemName = tempName;
                    temp2.ItemID = tempID;
                    temp2.Quantity = tempQuantity;
                    temp2.Price = tempPrice;
                }
            }
        }
    }

    public void DisplayAllItems()
    {
        Item temp = head;
        while (temp != null)
        {
            Console.WriteLine("Item Name: " + temp.ItemName + ", Item ID: " + temp.ItemID + ", Quantity: " + temp.Quantity + ", Price: " + temp.Price);
            temp = temp.Next;
        }
    }
    static void Main(string[] args)
    {
        InventoryManagementSystem inventory = new InventoryManagementSystem();

        inventory.AddAtBeginning("Speaker", 1, 10, 1000.0);
        inventory.AddAtEnd("Monile", 2, 20, 500.0);
        inventory.AddAtEnd("Watch", 3, 15, 300.0);
        inventory.AddAtPosition("Computor", 4, 5, 150.0, 2);

        Console.WriteLine("All items in inventory:");
        inventory.DisplayAllItems();

        inventory.UpdateQuantityByItemID(2, 25);
        Console.WriteLine("After updating quantity of Phone:");
        inventory.DisplayAllItems();

        inventory.RemoveByItemID(3);
        Console.WriteLine("After removing Tablet:");
        inventory.DisplayAllItems();

        Item foundItem = inventory.SearchByItemID(2);
        if (foundItem != null)
        {
            Console.WriteLine("Found item by Item ID: " + foundItem.ItemName);
        }
        else
        {
            Console.WriteLine("Item not found by Item ID.");
        }

        double totalValue = inventory.CalculateTotalValue();
        Console.WriteLine("Total inventory value: " + totalValue);

        inventory.SortInventoryByName(true);
        Console.WriteLine("Items sorted by Item Name in ascending order:");
        inventory.DisplayAllItems();

        inventory.SortInventoryByPrice(false);
        Console.WriteLine("Items sorted by Price in descending order:");
        inventory.DisplayAllItems();
    }
}

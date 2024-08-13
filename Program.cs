
Dictionary<string, decimal> menu = new Dictionary<string, decimal>
        {
            { "Apple", 0.50m },
            { "Banana", 0.30m },
            { "Orange", 0.60m },
            { "Milk", 1.00m },
            { "Bread", 1.20m },
            { "Eggs", 2.00m },
            { "Cheese", 2.50m },
            { "Chicken", 5.00m }
        };


List<string> shoppingList = new List<string>();
bool continueShopping = true;


Console.WriteLine("Menu:");
foreach (var item in menu)
{
    Console.WriteLine($"{item.Key}: ${item.Value}");
}


while (continueShopping)
{
    Console.Write("Enter an item name or type done to finish: ");
    string userInput = Console.ReadLine();

    if (userInput.ToLower() == "done")
    {
        continueShopping = false;
        break;
    }

    if (menu.ContainsKey(userInput))
    {
        shoppingList.Add(userInput);
        Console.WriteLine($"Added {userInput} - ${menu[userInput]} to your order.");

        Console.Write("Do you want to add another item? (yes/no): ");
        string response = Console.ReadLine();
        if (response.ToLower() != "yes")
        {
            continueShopping = false;
        }
    }
    else
    {
        Console.WriteLine("Error: Item does not exist in the menu. Please try again.");
    }
}

Console.WriteLine("\nYour order summary:");
decimal totalPrice = 0m;

foreach (var item in shoppingList)
{
    Console.WriteLine($"{item}: ${menu[item]}");
    totalPrice += menu[item];
}

Console.WriteLine($"Total Price: ${totalPrice}");
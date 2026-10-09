// Holds the items and takes care of loading and saving them.
class ShoppingList
{
    private List<Item> items = new List<Item>();
    private string path;
    private int budget;

    public ShoppingList(string path, int budget)
    {
        this.path = path;
        this.budget = budget;
    }

    public int Budget => budget;

    public bool Add(Item item)
    {
        if (Total() + item.Price > budget)
        {
            Console.WriteLine($"Kan inte lägga till {item.Name}. Budgeten på {budget} kr överskrids.");
            return false;
        }
        items.Add(item);
        return true;
    }

    // Removes the item the user sees as number 1, 2, 3 ...
    public bool RemoveAt(int number)
    {
        if (number < 1 || number > items.Count) return false;
        items.RemoveAt(number - 1);
        return true;
    }
    

    // Adds up the price of every item on the list.
    public long Total()
    {
        long sum = 0;

        for (int i = 0; i < items.Count; i++)
        {
            sum += items[i].Price;
        }

        return sum;
    }

    // Looks up an item by its name. Returns null if there is no such item.
    public Item Find(string name)
    {
        foreach (Item item in items)
        {
            if (item.Name == name)
            {
                return item;
            }
        }

        return null;
    }

    public void Print()
    {
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {items[i]}");
        }

        Console.WriteLine($"Totalt: {Total()} kr");
    }

    // Writes one item per line, as "price;name".
    public void Save()
    {
        List<string> lines = new List<string>();

        foreach (Item item in items)
        {
            lines.Add($"{item.Price};{item.Name}");
        }

        try
        {
            File.WriteAllLines(path, lines);
            Console.WriteLine("Listan är sparad.");
        }
        catch (IOException error)
        {
            Console.WriteLine($"Kunde inte spara listan: {error.Message}");
        }
        catch (UnauthorizedAccessException error)
        {
            Console.WriteLine($"Åtkomst nekad vid sparande av fil: {error.Message}");
        }
    }

    // Reads the file back into the list.
    public void Load()
    {
        if (!File.Exists(path)) return;
        
        try
        {
        foreach (string line in File.ReadAllLines(path))
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

             string[] parts = line.Split(';');
            if (parts.Length == 2 && int.TryParse(parts[0], out int price))
            {
                try { items.Add(new Item(parts[1], price)); }
                catch (ArgumentException)
                {
                    Console.WriteLine($"Fel vid läsning av rad: {line}");
                }
            }
            else
            {
                Console.WriteLine($"Hoppade över ogiltig rad: {line}");
                continue;
            }
        }
        }
        catch (IOException error)
        {
            Console.WriteLine($"Fel vid läsning av fil: {error.Message}");
        }
    }
}



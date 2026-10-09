// One item on the shopping list.
class Item
{
    public string Name { get; set; }
    public int Price { get; set; }

    public Item(string name, int price)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Namnet får inte vara tomt.");
        }
        if (price < 0)
        {
            throw new ArgumentOutOfRangeException("Priset får inte vara negativt.");
        }
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name} - {Price} kr";
    }
}

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode() + Price.GetHashCode();
    }
    public override bool Equals(object p)
    {
        if (!(p is Product))
        { return false; }
        Product other = p as Product;
        return Name.Equals(other.Name) && Price.Equals(other.Price);
    }
}
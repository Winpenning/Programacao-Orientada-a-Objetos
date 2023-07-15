namespace Lambda__delegates_e_LINQ.Entities
{
    public class Product : IComparable<Product>
    {
        private string name;
        private double price;
        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public int CompareTo(Product other)
        {
            return name.ToUpper().CompareTo(other.name.ToUpper());
        }
        public override string ToString()
        {
            return name + " " + price;
        }
    }
}

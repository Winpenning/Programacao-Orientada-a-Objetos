using System.Linq;
namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);

            IEnumerable<int> enumerable = 
                list.Where(x => x % 2 == 0).Select(x => x * 10); ;

            foreach (int x in enumerable)
            {
                Console.WriteLine(x);
            }
        }
    }
}
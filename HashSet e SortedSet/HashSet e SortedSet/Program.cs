using System.Collections.Generic;
using HashSet_e_SortedSet.Entities;


/*HashSet<People> peoples = new HashSet<People>();
peoples.Add(new People(09909999990, "Paulo Henrique", "paulo@gmail.com"));
peoples.Add(new People(099099999950, "Maria Antonieta", "maria@gmail.com"));
peoples.Add(new People(09909999950, "Sun Tzu", "sun@gmail.com"));*/

HashSet<string> setviahash = new HashSet<string>();

setviahash.Add("Antônio");
setviahash.Add("Clara");
setviahash.Add("Lúcia");
setviahash.Add("Rosevelt");

Console.WriteLine(setviahash.Contains("Antônio"));

foreach (string item in setviahash)
{
    Console.WriteLine(item);
}
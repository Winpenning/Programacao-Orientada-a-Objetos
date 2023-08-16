using System.Collections.Generic;

SortedSet<int> a = new SortedSet<int>() { 0,1,2,3,5,7,9 };
SortedSet<int> b = new SortedSet<int>() { 2,4,6,8 };

// UNIÃO DE CONJUNTOS
SortedSet<int> c = new SortedSet<int>(a);
c.UnionWith(b);
Print(c);

// INTERSECÇÃO DE CONJUNTOS
SortedSet<int> d = new SortedSet<int>(a);
d.Intersect(b);
Print(d);

//DIFERENÇA
SortedSet<int> e = a;
e.ExceptWith(b);
Print(e);



static void Print<T>(IEnumerable<T> collection)
{
    foreach(var obj in collection) 
    {
        Console.Write(obj + " ");
    }
    Console.WriteLine();
}
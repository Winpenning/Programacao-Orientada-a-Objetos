using GetHashCode_e_Equals.Entities;

Client a = new Client("Maria", "maria@gmail.com", 09505533950);
Client b = new Client("Pedro", "pedro@gmail.com", 09505533950);

// Compara se os objetos têm mesmo conteúdo
Console.WriteLine(a.Equals(b));

// Compara a referência do ponteiro de memória do objeto (se a posição na memória é igual
Console.WriteLine(a == b);

Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());
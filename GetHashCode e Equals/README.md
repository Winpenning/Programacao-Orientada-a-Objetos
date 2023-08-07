# GetHashCode e Equals

---

<aside>
💡 São métodos da classe Object utilizadas para comparar se um método é igual a outro.

</aside>

- **************Equals:************** lento, resposta 100% precisa;
    - `objectA.Equals(objectB);`
- ********************GetHashCode:******************** rápido, a resposta 100% precisa (é quase 100%).
    - `objectA.GetHashCode();`
    

> Os tipos pré-definidos já possuem implementação para esses métodos. Classes e Structs personalizadas precisam sobrepô-las.
> 

---

## Equals

Método que compara se um objeto é igual ao outro, retornando true or false.

```csharp
string nameA = "Maria";
string nameB = "Maria";
Console.Writ(nameA.Equals(nameB));
// OUTPUT: true
```

```csharp
string nameA = "Maria";
string nameB = "Alex";
Console.Write(nameA.Equals(nameB));
// OUTPUT: false
```

---

## GetHashCode

Método que retorna um número inteiro representando um código gerado a partir das informações do objeto.

```csharp
string nameA = "Maria";
Console.WriteLine(nameA.GetHashCode());
// OUTPUT: algum número gerado com base em seus parâmetros (exemplo: 17473958)
```

## Regra de ouro do GetHashCode

Se o código de dois objetos forem diferente, então **os dois objetos com certeza são diferentes**.

![Untitled](GetHashCode%20e%20Equals%20b06323cffeb841d4b335237a69cdcf2d/Untitled.png)

Se o código de dois objetos forem iguais, então **********************************************************************************muito provavelmente os objetos são iguais**********************************************************************************.

> um exemplo: Se estiver comparando elementos em uma lista, use o GetHashCode para compará-los, ele acertará os objetos diferentes, quando um objeto tem o mesmo código que o outro, deve-se usar o Equals para confirmar que são iguais.
> 

---
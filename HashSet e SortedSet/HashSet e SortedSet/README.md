# HashSet<T> e SortedSet<T>

---

<aside>
💡 São conjuntos de elementos (similares a conjuntos da álgebra)

</aside>

```csharp
HashSet<string> hash = new HashSet<string>();
SortedSet<string> sorted = new SortedSet<string>();
```

- Não admitem repetições;
- Elementos não possuem posição;
- Acesso, inserção e remoção de elementos são rápidos;
- Oferecem operações eficientes de conjunto: união, interseção, diferença.

---

## Diferenças

### HashSet

- Armazenamento em uma tabela hash;
- Extremamente rápido: inserção, remoção e busca:
    - Ordem de 1 passo.
- Os elementos não são ordenados.

### SortedSet

- Armazenamento em árvore;
- Rápido: inserção, remoção e busca;
    - Ordem de log|(n) passos:
        - Exemplo em árvore binária balanceada: Se 2^10 = 1024. O log de 1024 na base 2 é 10, portanto se tiverem 1024 elementos em uma árvore,  serão gastos no máximo 10 passos para acessar um elemento específico.
- Os elementos são armazenados de forma ordenada conforme implementação do IComparer<T>.

---

## Alguns métodos importantes

- `Add`: Adiciona um elemento ao conjunto;
- `Clear`: Limpa o conjunto;
- `Contains`: Verifica se um elemento está no conjunto;
- `UnionWith(other)`: União de conjuntos;
- `IntersectWith(other)`: Interseção de conjuntos;
- `ExceptWith(B)`: Remove do conjunto todos os elementos contidos em B.
- `Remove(e)`: Remove um elemento;
- `RemoveWhere(predicate)`: Remove seguindo uma condição
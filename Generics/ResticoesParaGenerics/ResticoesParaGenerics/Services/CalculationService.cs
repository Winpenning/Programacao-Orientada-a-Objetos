using System.Collections.Generic;
namespace ResticoesParaGenerics.Services
{
    public class CalculationService
    {
        // UM MÉTODO GENÉRICO QUE ACEITA QUALQUER TIDO DE DADOS DESDE QUE O TIPO IMPLEMENTE
        // A INTERFACE IComparable
        public T Max<T>(List<T> list) where T : IComparable
        {
            if(list.Count == 0)
            {
                throw new ArgumentException("EXCEPTION! The list cannot be empty!");
            }
            else
            {
                // AQUI PODERIAMOS UTILIZAR LINQ MAS PARA FINS DE APRENDIZADO DE RESTRIÇÕES
                // DE GENERICS, O ALGORITMO PARA ENCONTRAR O MAIOR VALOR SERÁ IMPLEMENTADO.
                T max = list[0];
                for(int i = 0; i < list.Count; i++)
                {
                    if (list[i].CompareTo(max) > 0)
                    {
                        max = list[i];
                    }
                }
                return max;
            }
        }
    }
}

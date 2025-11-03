//using System;

class Program
{
    static void Main()
    {
        int[] vetor = [5, 3, 8, 2, 9, 1, 11, 0, 4];

        InsertionSort(vetor);

        Console.WriteLine("\nInsertion ordenado:");
        ExibirVetor(vetor);

        vetor = [25, 20, 22, 11, 8, 18 ];

        SelectionSort(vetor);

        Console.WriteLine("\nSelection ordenado:");
        ExibirVetor(vetor);
    }

    static void InsertionSort(int[] vetor)
    {
        for (int i = 1; i < vetor.Length; i++)
        {
            int chave = vetor[i];
            int aux = i - 1;

            while (aux >= 0 && vetor[aux] > chave)
            {
                vetor[aux + 1] = vetor[aux];
                aux--;
            }

            vetor[aux + 1] = chave;
        }
    }

    static void SelectionSort(int[] vetor)
    {
        int aux = vetor.Length;

        for (int indice = 0; indice < aux - 1; indice++)
        {
            int indiceMenor = indice;

            for (int indiceAux = indice + 1; indiceAux < aux; indiceAux++)
            {
                if (vetor[indiceAux] < vetor[indiceMenor])
                    indiceMenor = indiceAux;
            }

            int temp = vetor[indiceMenor];
            vetor[indiceMenor] = vetor[indice];
            vetor[indice] = temp;
        }
    }

    static void ExibirVetor(int[] arr)
    {
        foreach (int valor in arr)
            Console.Write(valor + " ");
        Console.WriteLine();
    }
}

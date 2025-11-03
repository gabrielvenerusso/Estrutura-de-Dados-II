import java.util.Comparator;
import java.util.Arrays;

public final class InsertionSort {

    public static void ordenar(int[] vetor) {
        if (vetor == null || vetor.length < 2) 
            return;

        for (int indiceAtual = 1; indiceAtual < vetor.length; indiceAtual++) {
            int elementoChave = vetor[indiceAtual]; 
            int indiceAnterior = indiceAtual - 1;   

            while (indiceAnterior >= 0 && vetor[indiceAnterior] > elementoChave) {
                vetor[indiceAnterior + 1] = vetor[indiceAnterior];
                indiceAnterior--;
            }
            
            vetor[indiceAnterior + 1] = elementoChave; 
        }
    }

    public static <T extends Comparable<? super T>> void ordenar(T[] vetor) {
        ordenar(vetor, Comparator.naturalOrder());
    }

    public static <T> void ordenar(T[] vetor, Comparator<? super T> comparador) {
        if (vetor == null || vetor.length < 2) 
            return;

        for (int indiceAtual = 1; indiceAtual < vetor.length; indiceAtual++) {
            T elementoChave = vetor[indiceAtual];
            int indiceAnterior = indiceAtual - 1;

            while (indiceAnterior >= 0 && comparador.compare(vetor[indiceAnterior], elementoChave) > 0) {
                vetor[indiceAnterior + 1] = vetor[indiceAnterior];
                indiceAnterior--;
            }

            vetor[indiceAnterior + 1] = elementoChave;
        }
    }

    public static void main(String[] args) {
        int[] numeros = {5, 3, 8, 2, 9, 1, 11, 0, 4};
        InsertionSort.ordenar(numeros);
        System.out.println(Arrays.toString(numeros));
    }
}

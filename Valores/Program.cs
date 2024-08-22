int[] vetor = new int[1000];
Random random = new Random();

for (int i = 0; i < vetor.Length; i++) {
    vetor[i] = random.Next(1,10001);
}

Console.WriteLine("Vetor original:");
ImprimirVetor(vetor);

BubbleSort(vetor);

Console.WriteLine("\nVetor ordenado:");
ImprimirVetor(vetor);

static void BubbleSort(int[] vetor) {
    int n = vetor.Length;

    for (int i = 0; i < n - 1; i++) {
        for (int j = 0; j < n - i - 1; j++) {
            if (vetor[j] > vetor[j + 1]) {
                int temp = vetor[j + 1];
                vetor[j + 1] = vetor[j];
                vetor[j] = temp;
            }
        }
    }
}

static void ImprimirVetor(int[] vetor) {
    foreach (int valor in vetor) {
        Console.Write(valor + " ");
    }
    Console.WriteLine();
}
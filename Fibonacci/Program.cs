Console.Write("Digite um número positivo: ");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero <= 0) {
    Console.WriteLine("Por favor, insira um número positivo.");
    return;
}

int a = 0, b = 1;

Console.Write("Sequência de Fibonacci: ");

while (a <= numero) {
    Console.Write(a + " ");
    int temp = a;
    a = b;
    b = temp + b;
}

Console.WriteLine(); 
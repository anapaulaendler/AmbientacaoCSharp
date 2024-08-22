/* Crie um algoritmo que permita fazer três conversões monetárias. O algoritmo deve receber o valor 
em real (R$) e apresentar os valores convertidos em:

1. Dólar (1 dólar = 5,17 reais)
2. Euro (1 euro = 6,14 reais)
3. Peso argentino (1 peso argentino = 0,05 reais) */

Console.WriteLine("Digite a quantia de dinheiro, em reais: ");
double real = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite para converter em:\n1: Dólar\n2: Euro\n3: Peso Argentino\n0: Sair");
double final = 0;
int escolha = 0;

do {
    escolha = Convert.ToInt32(Console.ReadLine());
    switch (escolha) {
        case 1: final = real / 5.17; Console.WriteLine(real + " reais equivalem a " + final + " dólares"); break;
        case 2: final = real / 6.14; Console.WriteLine(real + " reais equivalem a " + final + " euros"); break;
        case 3: final = real / 0.05; Console.WriteLine(real + " reais equivalem a " + final + " pesos argentinos"); break;
        case 0: Console.WriteLine("Saindo..."); break;
        default: Console.WriteLine("Dígito inválido"); break;
    }
} while (escolha != 0);
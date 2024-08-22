Console.WriteLine("Digite sua idade em anos: ");
int idade = Convert.ToInt32(Console.ReadLine());

if (idade <= 13) {
    Console.WriteLine("Criança");
} else if (13 < idade && idade <= 18) {
    Console.WriteLine("Adolescente");
} else if (18 < idade && idade <= 60) {
    Console.WriteLine("Adulto");
} else {
    Console.WriteLine("Idoso");
}
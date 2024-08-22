Console.WriteLine("Digite seus números inteiros: ");
string[] nums = Console.ReadLine().Split();

int a = Convert.ToInt32(nums[0]);
int b = Convert.ToInt32(nums[1]);

if (a > b) {
    Console.WriteLine(a + " é maior!");
} else if (b > a) {
    Console.WriteLine(b + " é maior!");
} else {
    Console.WriteLine("Os dois são iguais!");
}
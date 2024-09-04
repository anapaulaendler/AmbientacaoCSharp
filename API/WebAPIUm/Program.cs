/* Testar as APIs
   - Rest Client - Extensão do VS Code
   - Postman
   - Insomnia
   Minimal APIs */

using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using API.modelos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

/* endpoints: funcionalidades */

// lista utilizada no sexto item:
List<UserInfo> listaUser = new List<UserInfo>();

/* EndPoints: Funcionalidades 
   Configurar a URL e o método/verbo */

// ✧ primeiro:
app.MapGet("/", () => "Hello World em C#!");

// ✧ segundo, texto da valesca:
app.MapGet("/valescapopozuda", () => "Desejo a todas inimigas vida longa, Pra que elas vejam cada dia mais nossa vitória. Valesca Popozuda.");

// ✧ terceiro, endereço:
app.MapGet("/retornarendereco", () => {
    dynamic endereco = new {
        rua = "Penal",
        numero = 66,
        CEP = "111111111111111111"

    };
    return endereco;
});

/* TAREFA: criar uma funcionalidade para:
   ♡ receber informações pela URL da requisição
   ♡ receber informações pelo corpo da requisição 
   ♡ guardar as informações em uma lista */

// ✧ quarto, receber informações pela url da requisição:
app.MapGet("/receberinfo/{nome}/{idade}", (string nome, int idade) => {
    return $"Nome: {nome}, idade: {idade}";
});

// ✧ quinto, receber informações pelo corpo da requisição:
/* a classe UserInfo tá depois do app.Run();
   deu um erro na primeira tentativa, precisei especificar explicitamente 
   que o parâmetro userInfo deve ser lido do corpo da requisição => solução foi o [FromBody] */

app.MapGet("/receberinfocorpo", ([FromBody] UserInfo userInfo) => {
    listaUser.Add(userInfo);
    // a linha acima é relacionada ao sexto exercício!
    return $"Nome: {userInfo.Nome}, idade: {userInfo.Idade} - foi adicionado à lista. :)";
});

// ✧ sexto: guardar as informações em uma lista:
/* a lista tá lá no começo do cógigo */
app.MapGet("/lista", () => listaUser);

app.Run();

/* LEMBRETE: não colocar ; no final, e nem : depois do nome do atributo :p
   ✧ "warning CS8618: O propriedade não anulável 'Nome' precisa conter um 
   valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável." 
   por isso o ? do lado de string */
public class UserInfo
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
}

/* material feito na aula do dia 04.09: */

/* JAVA ABAIXO (UTILIZAÇÃO DOS GETS E SETS)
Produto produto = new Produto();
produto.setPreco(5);
Console.WriteLine("Preço: R$ " + produto.getPreco()); */

// C#: utilização dos gets e sets
Produto produto = new Produto();
produto.Preco = 5;
Console.WriteLine("Preco: R$ " + produto.Preco);
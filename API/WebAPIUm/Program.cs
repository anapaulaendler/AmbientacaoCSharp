/* Testar as APIs
- Rest Client - Extensão do VS Code
- Postman
- Insomnia
Minimal APIs */
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

/* EndPoints: Funcionalidades 
Configurar a URL e o método / verbo */

app.MapGet("/", () => "Hello World em C#endregion! ");

app.MapGet("/valescapopozuda", () => "Hello World em C#endregion! ");

app.MapGet("/retornarendereco", () => {
    dynamic endereco = new {
        rua = "Penal",
        numero = 66,
        CEP = "111111111111111111"

    };
    return endereco;
});

app.Run();

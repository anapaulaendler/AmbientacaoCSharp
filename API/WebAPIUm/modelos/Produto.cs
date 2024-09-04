namespace WebAPIUm.modelos;

public class Produto 
{
    // C#: Construtor da classe
    public Produto()
    {
        CriadoEm = DateTime.Now;
        Id = Guid.NewGuid().ToString();
    }
    // C#: atributo com get e set
    // tudo em letra maiuscula
    // basicamente, o c# entende automaticamente que o atributo é privado, deixando público somente o get e o set
    public string? Id { get; set; }
    public double Preco { get; set; }
    public string? Nome { get; set; }
    public int Quantidade { get; set; }
    public DateTime CriadoEm { get; set; }
    // criado com 'prop' + enter

    /* JAVA: costumes abaixo
    private double preco;
    
    public double getPreco()
    {
        return preco;
    }

    public void setPreco(double preco) 
    {
        this.preco= preco * 3;
    }
    */

}
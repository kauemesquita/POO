//Variavel
// TIPO NOME

using POO;

// Instanciar
Carro carroDoMesquita  = new Carro();

carroDoMesquita.Modelo = "Honda Civic";
carroDoMesquita.Marca = "Honda";
carroDoMesquita.Ano = 2018;

carroDoMesquita.ExibirInformacoes();

Carro carroDoMesquita2 = new Carro();

carroDoMesquita2.Modelo = "BYD";
carroDoMesquita2.Marca = "Tesla";
carroDoMesquita2.Ano = 2020;

carroDoMesquita2.ExibirInformacoes();



//Classe Pedido
// NomeDoCliente, Item, Quantidade, Preco

Pedido pedidoDaLanchonete = new Pedido();

pedidoDaLanchonete.Item = "Pizza";
pedidoDaLanchonete.Quantidade = 2;
pedidoDaLanchonete.Preco = 15;

pedidoDaLanchonete.ExibirInformacoes();

//Classe pessoa

Pessoa pessoasExc = new Pessoa();

pessoasExc.Nome = "Ana";

Pessoa pessoasExc2 = new Pessoa();
pessoasExc2.Nome = "Bruno";

pessoasExc.Idade = 25;
pessoasExc2.Idade = 31;


pessoasExc.ExibirInformacoes();
pessoasExc2.ExibirInformacoes();

//Classe Retangulo

Retangulo contaArea = new Retangulo();
contaArea.Altura = 20;
contaArea.Largura = 4;

Retangulo contaPerimetro = new Retangulo();
contaPerimetro.Altura = 10;
contaPerimetro.Largura = 20;

Console.WriteLine(contaArea.CalcularArea());
Console.WriteLine(contaPerimetro.CalcularPerimetro());


PessoaMetodo2 ana = new PessoaMetodo2();
ana.Nome = "Ana";

ana.Cumprimentar();
ana.CumprimentarAlguem("Bruno");

string frase = ana.ObterApresentacao();
Console.WriteLine(frase);

Retangulo2 rtg = new Retangulo2();
rtg.Altura = 3;
rtg.Largura = 5;

rtg.CalcularArea();
rtg.CalcularPerimetro();

Console.WriteLine(rtg.CalcularArea());
Console.WriteLine(rtg.CalcularPerimetro());
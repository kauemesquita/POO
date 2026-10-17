//-------Program:

using PilaresPoo.Polimorfismo;
using PilaresPoo.Polimorfismo.Exercicios;
using static PilaresPoo.Polimorfismo.PolimorfismoSobreEscrita;

PolimorfismoExemplo poli = new PolimorfismoExemplo();

poli.Somar(2.5, 3.7);

poli.Somar(2, 3, 5);


Animal a = new Animal();
a.FazerSom();

Cachorro c = new Cachorro();
c.FazerSom();

Gato g = new Gato();
g.FazerSom();

Saudacao s = new Saudacao();

s.Cumprimentar();
s.Cumprimentar("Ana");
s.Cumprimentar("Bruno", 25);

CalculadoraDeArea calc = new CalculadoraDeArea();

Console.WriteLine($"Quadrado: {calc.CalcularArea(4)}");
Console.WriteLine($"Retângulo: {calc.CalcularArea(3, 5)}");


Instrumento instrumento = new Instrumento();
Violao violao = new Violao();

instrumento.Tocar();
violao.Tocar();
// Formas de utilizar lambda expressions

// Func são delegates que recebem algum ou alguns argumentos e retornam algo.
Func<int, int> teste = numero => numero * numero;

// Action são delegates que recebem algum ou alguns argumentos e não retornam nada.
Action<int> teste2 = numero => Console.WriteLine(teste(numero));

// O interessante a se notar é que esses delegates podem ser definidos através de lambdas

Console.WriteLine(teste(5));
teste2(4);

// Forma que eu mais utilizo:
List<Pessoa> pessoas = new()
{
    new("Rodrigo", 10),
    new("Mariana", 15),
    new("Vanessa", 30)
};

Pessoa maisJovem = pessoas.MinBy(pessoa => pessoa.Idade);
Pessoa maisVelha = pessoas.MaxBy(pessoa => pessoa.Idade);


Console.WriteLine($"O nome da pessoa mais nova é {maisJovem.Nome}");
Console.WriteLine($"O nome da pessoa mais velha é {maisVelha.Nome}");

Console.ReadLine();

record Pessoa(string Nome, int Idade);
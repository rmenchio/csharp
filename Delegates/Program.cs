using Delegates;

Animal animal = new("Billy");
Animal animal2 = new("Thomas");

OperacoesAnimal acoes =  new OperacoesAnimal();

// Utilizando delegates de uma única função
acoes.InteragirComAnimal(animal, new AcoesAnimal().FazerAniversario);
acoes.InteragirComAnimal(animal, new AcoesAnimal().CrescerAltura);
acoes.InteragirComAnimal(animal, new AcoesAnimal().Engordar);

// Utilizando delegates de várias funções
AcoesAnimal pacoteDeAcoes = new AcoesAnimal();

AcoesAnimalHandler delegator = pacoteDeAcoes.FazerAniversario;
delegator += pacoteDeAcoes.FazerAniversario;
delegator += pacoteDeAcoes.FazerAniversario;
delegator += pacoteDeAcoes.Engordar;

acoes.InteragirComAnimal(animal2, delegator);

// Da pra criar delegates sem a necessidade de fazer assinaturas, como o abaixo

Action<Animal> action = pacoteDeAcoes.FazerAniversario;

// Aqui precisaria alterar a assinatura do método para aceitar action, ao inves do delegate personalizado.
// acoes.InteragirComAnimal(animal2, action);



Console.ReadLine();
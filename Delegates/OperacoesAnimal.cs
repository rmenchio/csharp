namespace Delegates
{
    public delegate void AcoesAnimalHandler(Animal animal);
    public class OperacoesAnimal
    {
        public void InteragirComAnimal(Animal animal, AcoesAnimalHandler acoes) 
        {
            Console.WriteLine($"{animal.Nome} tem {animal.Idade} anos, {animal.Peso} quilos e {animal.Altura} centímetros de altura.");
            Console.WriteLine("Executando delegate....");
            acoes(animal);
            Console.WriteLine($"{animal.Nome} tem {animal.Idade} anos, {animal.Peso} quilos e {animal.Altura} centímetros de altura.");
        }
    }
}

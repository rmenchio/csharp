namespace Delegates
{
    public class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; } = 0;
        public int Peso { get; set; } = 2;
        public int Altura { get; set; } = 30;

        public Animal(string nome)
        {
            Nome = nome;
        }
    }
}

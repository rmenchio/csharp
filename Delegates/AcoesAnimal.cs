namespace Delegates
{
    public class AcoesAnimal
    {
        public void FazerAniversario(Animal animal)
        {
            animal.Idade++;
        }

        public void CrescerAltura(Animal animal)
        {
            animal.Altura++;
        }

        public void Engordar(Animal animal)
        {
            animal.Peso++;
        }
    }
}